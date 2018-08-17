using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPrintGridModifier
{
    public delegate void ValueChangedMethod();

    public delegate void GridClickedEventHandler(double x, double y, double height);

    public partial class RadialGenerator : UserControl
    {
        public event EventHandler NodeSelected;
        public event EventHandler NodeUnselected;
        public event GridClickedEventHandler GridClicked;

        private int GraphicalRadius;
        private Point GraphicalMidpoint;
        private double graphicalScalar
        {
            get
            {
                return (double)GraphicalRadius / ((Dimension * gridStep) / 2);
            }
        }

        private int dimension = 21;
        public int Dimension
        {
            get
            {
                return dimension;
            }
            set
            {
                if (value % 2 == 1)
                {
                    dimension = value;
                    ValueChanged();
                }
            }
        }

        public GridPoint[,] Grid;
        private double gridStep
        {
            get
            {
                return (double)(OuterRadius * 2) / (Dimension - 1);
            }
        }

        public RingPoint SelectedRingPoint = null;

        private int ringArcStep
        {
            get
            {
                return 360 / PerimeterPoints;
            }
        }

        private double ringRadiusStep
        {
            get
            {
                return (double)(OuterRadius - InnerRadius) / (Rings - 1);
            }
        }

        private int perimeterPoints = 5;
        public int PerimeterPoints
        {
            get
            {
                return perimeterPoints;
            }
            set
            {
                // ensure correct number of points
                if (360 % value == 0 && RingArray != null)
                {
                    perimeterPoints = value;
                    UpdateRings();
                }
            }
        }

        public Ring[] RingArray;
        private int rings;
        public int Rings
        {
            get
            {
                return rings;
            }
            set
            {
                if (value >= 2)
                {
                    rings = value;
                    UpdateRings();
                }
            }
        }

        private int outerRadius = 150;
        public int OuterRadius
        {
            get
            {
                return outerRadius;
            }
            set
            {
                outerRadius = value;
                UpdateRings();
            }
        }

        private int innerRadius = 10;
        public int InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                innerRadius = value;
                UpdateRings();
            }
        }

        public RadialGenerator()
        {
            Rings = 5;
            ValueChanged();

            InitializeComponent();

            GraphicalRadius = 325;
            GraphicalMidpoint = new Point(Width / 2, Height / 2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // rings
            using (Pen thinBlackPen = new Pen(Color.Black, 3))
            using (Pen thickBlackPen = new Pen(Color.Black, 5))
            using (Pen thinWhitePen = new Pen(Color.White, 1))

            using (Pen gridLinePen = new Pen(Color.Black, 1))

            using (Pen spokePen = new Pen(Color.Black, 3))
            using (Pen spokeSelectedPen = new Pen(Color.LightGreen, 3))

            using (Pen ringPen = new Pen(Color.Black, 3))
            using (Pen majorRingPen = new Pen(Color.Black, 5))
            using (Pen ringSelectedPen = new Pen(Color.LightGreen, 3))
            using (Pen majorRingSelectedPen = new Pen(Color.LightGreen, 5))

            using (SolidBrush ringPointBrush = new SolidBrush(Color.Red))
            using (SolidBrush ringPointSelectedBrush = new SolidBrush(Color.Blue))
            {
                spokePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                spokeSelectedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                gridLinePen.DashCap = System.Drawing.Drawing2D.DashCap.Round;
                gridLinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                double graphicalGridStep = gridStep * graphicalScalar;

                // coloured cells
                double largestAbsoluteValue = 0;
                for (int y = 0; y < Dimension; y++)
                {
                    for (int x = 0; x < Dimension; x++)
                    {
                        if (Grid[y, x].InCircle)
                        {
                            double abs = Math.Abs(Grid[y, x].Value);
                            if (abs > largestAbsoluteValue)
                            {
                                largestAbsoluteValue = abs;
                            }
                        }
                    }
                }

                int halfDimension = (Dimension - 1) / 2;

                for (int y = 0; y < Dimension; y++)
                {
                    for (int x = 0; x < Dimension; x++)
                    {
                        double value = Grid[y, x].Value;

                        double percentage = 1 - (Math.Abs(value) / largestAbsoluteValue);
                        if (percentage < 0)
                        {
                            percentage = 0;
                        }
                        int colourValue = (int)Math.Round(percentage * 255);

                        Color newCellColour;

                        if (value < 0)
                        {
                            newCellColour = Color.FromArgb(255, colourValue, colourValue);
                        }
                        else if (value > 0)
                        {
                            newCellColour = Color.FromArgb(colourValue, colourValue, 255);
                        }
                        else
                        {
                            newCellColour = Color.White;
                        }

                        Rectangle cellRect = new Rectangle((int)Math.Round(GraphicalMidpoint.X + ((x - halfDimension) * graphicalGridStep) - (graphicalGridStep / 2)),
                                                            (int)Math.Round(GraphicalMidpoint.Y + ((y - halfDimension) * graphicalGridStep) - (graphicalGridStep / 2)),
                                                            (int)Math.Round(graphicalGridStep),
                                                            (int)Math.Round(graphicalGridStep));

                        e.Graphics.DrawRectangle(new Pen(newCellColour), cellRect);
                        e.Graphics.FillRectangle(new SolidBrush(newCellColour), cellRect);
                    }
                }

                // grid centre dot
                /*
                double step = (double)OuterRadius / halfDimension;
                Console.WriteLine(step);
                for (int y = 0; y < Dimension; y++)
                {
                    for (int x = 0; x < Dimension; x++)
                    {
                        double xCoord = (x - halfDimension) * step;
                        double yCoord = (y - halfDimension) * step;

                        e.Graphics.DrawEllipse(Pens.Black, GraphicalMidpoint.X + (float)(xCoord * graphicalScalar), GraphicalMidpoint.Y + (float)(yCoord * graphicalScalar), 2, 2);

                        //double interpolatedHeight = GetHeight(xCoord, yCoord);
                    }
                }
                */

                // grid lines
                for (int x = -halfDimension - 1; x <= halfDimension + 1; x++)
                {
                    int xCoord;
                    if (x < 0)
                    {
                        xCoord = (int)Math.Round(GraphicalMidpoint.X + (x * graphicalGridStep) + (graphicalGridStep / 2));
                    }
                    else if (x > 0)
                    {
                        xCoord = (int)Math.Round(GraphicalMidpoint.X + (x * graphicalGridStep) - (graphicalGridStep / 2));
                    }
                    else
                    {
                        continue;
                    }
                    Point start = new Point(xCoord, GraphicalMidpoint.X - (int)Math.Round((halfDimension + 0.5) * graphicalGridStep));
                    Point end = new Point(xCoord, GraphicalMidpoint.Y + (int)Math.Round((halfDimension + 0.5) * graphicalGridStep));

                    e.Graphics.DrawLine(gridLinePen, start, end);
                }
                for (int y = -halfDimension - 1; y <= halfDimension + 1; y++)
                {
                    int yCoord;
                    if (y < 0)
                    {
                        yCoord = (int)Math.Round(GraphicalMidpoint.Y + (y * graphicalGridStep) + (graphicalGridStep / 2));
                    }
                    else if (y > 0)
                    {
                        yCoord = (int)Math.Round(GraphicalMidpoint.Y + (y * graphicalGridStep) - (graphicalGridStep / 2));
                    }
                    else
                    {
                        continue;
                    }
                    Point start = new Point(GraphicalMidpoint.Y - (int)Math.Round((halfDimension + 0.5) * graphicalGridStep), yCoord);
                    Point end = new Point(GraphicalMidpoint.Y + (int)Math.Round((halfDimension + 0.5) * graphicalGridStep), yCoord);

                    e.Graphics.DrawLine(gridLinePen, start, end);
                }

                // spokes
                for (int i = 0; i < PerimeterPoints; i++)
                {
                    Point graphicalInnerRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[0].ringPoints[i].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[0].ringPoints[i].Y * graphicalScalar));
                    Point graphicalOuterRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[Rings - 1].ringPoints[i].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[Rings - 1].ringPoints[i].Y * graphicalScalar));

                    if (SelectedRingPoint == null || SelectedRingPoint.ParentRing.ringPoints[i] != SelectedRingPoint)
                    {
                        e.Graphics.DrawLine(spokePen, GraphicalMidpoint, graphicalOuterRingPointPoint);
                    }
                    else
                    {
                        e.Graphics.DrawLine(spokePen, GraphicalMidpoint, graphicalInnerRingPointPoint);
                    }
                }
                for (int i = 0; i < PerimeterPoints; i++)
                {
                    Point graphicalInnerRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[0].ringPoints[i].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[0].ringPoints[i].Y * graphicalScalar));
                    Point graphicalOuterRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[Rings - 1].ringPoints[i].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[Rings - 1].ringPoints[i].Y * graphicalScalar));

                    if (SelectedRingPoint != null && SelectedRingPoint.ParentRing.ringPoints[i] == SelectedRingPoint)
                    {
                        e.Graphics.DrawLine(spokeSelectedPen, graphicalInnerRingPointPoint, graphicalOuterRingPointPoint);
                    }
                }

                // rings & ring points
                for (int i = 0; i < Rings; i++)
                {
                    double graphicalRingRadius = RingArray[i].RingRadius * graphicalScalar;
                    Rectangle ringRect = new Rectangle((int)Math.Round(GraphicalMidpoint.X - graphicalRingRadius),
                                                        (int)Math.Round(GraphicalMidpoint.Y - graphicalRingRadius),
                                                        (int)Math.Round(graphicalRingRadius * 2),
                                                        (int)Math.Round(graphicalRingRadius * 2));
                    if (i == 0 || i == Rings - 1)
                    {
                        if (SelectedRingPoint != null && SelectedRingPoint.ParentRing == RingArray[i])
                        {
                            e.Graphics.DrawEllipse(majorRingSelectedPen, ringRect);
                        }
                        else
                        {
                            e.Graphics.DrawEllipse(majorRingPen, ringRect);
                        }
                    }
                    else
                    {
                        if (SelectedRingPoint != null && SelectedRingPoint.ParentRing == RingArray[i])
                        {
                            e.Graphics.DrawEllipse(ringSelectedPen, ringRect);
                        }
                        else
                        {
                            e.Graphics.DrawEllipse(ringPen, ringRect);
                        }
                    }

                    for (int j = 0; j < PerimeterPoints; j++)
                    {
                        if (RingArray[i].ringPoints[j] != SelectedRingPoint)
                        {
                            Point graphicalRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[i].ringPoints[j].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[i].ringPoints[j].Y * graphicalScalar));

                            Rectangle ringPointRect = new Rectangle(graphicalRingPointPoint.X - 6,
                                                                graphicalRingPointPoint.Y - 6,
                                                                13,
                                                                13);
                            e.Graphics.DrawEllipse(thinWhitePen, ringPointRect);
                        }
                    }

                    for (int j = 0; j < PerimeterPoints; j++)
                    {
                        if (RingArray[i].ringPoints[j] != SelectedRingPoint)
                        {
                            Point graphicalRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[i].ringPoints[j].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[i].ringPoints[j].Y * graphicalScalar));

                            Rectangle ringPointRect = new Rectangle(graphicalRingPointPoint.X - 6,
                                                                graphicalRingPointPoint.Y - 6,
                                                                13,
                                                                13);
                            e.Graphics.FillEllipse(ringPointBrush, ringPointRect);
                        }
                    }
                }

                for (int i = 0; i < Rings; i++)
                {
                    for (int j = 0; j < PerimeterPoints; j++)
                    {
                        if (RingArray[i].ringPoints[j] == SelectedRingPoint)
                        {
                            Point graphicalRingPointPoint = new Point(GraphicalMidpoint.X + (int)Math.Round(RingArray[i].ringPoints[j].X * graphicalScalar), GraphicalMidpoint.Y + (int)Math.Round(RingArray[i].ringPoints[j].Y * graphicalScalar));

                            Rectangle ringPointRect = new Rectangle(graphicalRingPointPoint.X - 7,
                                                                graphicalRingPointPoint.Y - 7,
                                                                15,
                                                                15);
                            e.Graphics.FillEllipse(ringPointSelectedBrush, ringPointRect);
                            e.Graphics.DrawEllipse(thinWhitePen, ringPointRect);
                        }
                    }
                }
            }

            // border
            using (Pen blackPen = new Pen(Color.Black, 3))
            {
                Rectangle borderRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                e.Graphics.DrawRectangle(blackPen, borderRect);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point mousePoint = e.Location;
            mousePoint.X -= GraphicalMidpoint.X;
            mousePoint.Y -= GraphicalMidpoint.Y;

            double scaledMousePointX = mousePoint.X / graphicalScalar;
            double scaledMousePointY = mousePoint.Y / graphicalScalar;

            //;

            if (Math.Abs(mousePoint.X) < GraphicalRadius && Math.Abs(mousePoint.Y) < GraphicalRadius)
            {
                double height = GetHeight(scaledMousePointX, scaledMousePointY);
                GridClicked?.Invoke(scaledMousePointX, scaledMousePointY, height);
            }

            RingPoint closestPoint = null;
            double shortestSquaredDistance = 0;
            SelectedRingPoint = null;

            for (int i = 0; i < Rings; i++)
            {
                for (int j = 0; j < PerimeterPoints; j++)
                {
                    //Console.WriteLine(mousePoint.X + ", " + mousePoint.Y + " : " + (RingArray[i].ringPoints[j].X * graphicalScalar) + ", " + (RingArray[i].ringPoints[j].Y * graphicalScalar));
                    double distanceSquared = ((scaledMousePointX - RingArray[i].ringPoints[j].X) * (scaledMousePointX - RingArray[i].ringPoints[j].X) +
                                            (scaledMousePointY - RingArray[i].ringPoints[j].Y) * (scaledMousePointY - RingArray[i].ringPoints[j].Y));
                    if (closestPoint == null || distanceSquared < shortestSquaredDistance)
                    {
                        closestPoint = RingArray[i].ringPoints[j];
                        shortestSquaredDistance = distanceSquared;
                    }
                }
            }

            double shortestDistance = Math.Sqrt(shortestSquaredDistance);

            if (shortestDistance <= 8)
            {
                // clicked on closestPoint
                SelectedRingPoint = closestPoint;

                NodeSelected?.Invoke(closestPoint, e);
            }
            else
            {
                NodeUnselected?.Invoke(closestPoint, e);
            }

            this.Refresh();

            base.OnMouseClick(e);
        }

        private void UpdateRings()
        {
            RingArray = new Ring[Rings];

            SelectedRingPoint = null;

            for (int i = 0; i < Rings; i++)
            {
                double ringRadius = InnerRadius + i * ringRadiusStep;
                RingArray[i] = new Ring(ringRadius, PerimeterPoints, ValueChanged);
            }
            ValueChanged();
        }

        private double GetHeight(double x, double y)
        {
            double radius = Math.Sqrt((x * x) + (y * y));

            double arc;

            if (x != 0 || y != 0)
            {
                int quadrant = 0;

                if (x >= 0 && y < 0)
                {
                    double temp = y;
                    y = x;
                    x = -temp;

                    quadrant = 0;
                }
                else if (y >= 0 && x > 0)
                {
                    // no change needed
                    quadrant = 1;
                }
                else if (x <= 0 && y > 0)
                {
                    double temp = y;
                    y = -x;
                    x = temp;
                    quadrant = 2;
                }
                else if (y <= 0 && x < 0)
                {
                    y = -y;
                    x = -x;
                    quadrant = 3;
                }

                arc = (Math.Atan2(y, x) * (180 / Math.PI)) + (quadrant * 90);
            }
            else
            {
                arc = 0;
            }

            int segmentOuterRing = Rings - 1;

            for (int i = 0; i < Rings; i++)
            {
                if (InnerRadius + i * ringRadiusStep >= radius)
                {
                    segmentOuterRing = i;
                    break;
                }
            }

            double interpolatedHeight;

            int firstRingPoint = (int)Math.Floor(arc / ringArcStep);
            int secondRingPoint = firstRingPoint + 1;
            if (secondRingPoint == PerimeterPoints)
            {
                secondRingPoint = 0;
            }

            double angleDifference = arc - (firstRingPoint * ringArcStep);

            double outerRingInterpolatedHeight = Interpolate(RingArray[segmentOuterRing].ringPoints[firstRingPoint], RingArray[segmentOuterRing].ringPoints[secondRingPoint], angleDifference);
            double innerRingInterpolatedHeight;
            double innerRingRadius;
            if (segmentOuterRing != 0)
            {
                innerRingRadius = RingArray[segmentOuterRing - 1].RingRadius;
                innerRingInterpolatedHeight = Interpolate(RingArray[segmentOuterRing - 1].ringPoints[firstRingPoint], RingArray[segmentOuterRing - 1].ringPoints[secondRingPoint], angleDifference);
            }
            else
            {
                innerRingRadius = 0;
                innerRingInterpolatedHeight = 0;
            }

            interpolatedHeight = Interpolate(innerRingRadius, innerRingInterpolatedHeight, RingArray[segmentOuterRing].RingRadius, outerRingInterpolatedHeight, radius);
            //Console.WriteLine(interpolatedHeight);
            return interpolatedHeight;
        }

        private double Interpolate(RingPoint ringPoint1, RingPoint ringPoint2, double angleDifference)
        {
            double percentageProgress = angleDifference / ringArcStep;
            double interpolatedHeight = ringPoint1.Value + ((ringPoint2.Value - ringPoint1.Value) * percentageProgress);
            return interpolatedHeight;
        }

        private double Interpolate(double radius1, double height1, double radius2, double height2, double pointRadius)
        {
            double radiusDifference = pointRadius - radius1;
            double radiusStep = radius2 - radius1;
            double percentageProgress = radiusDifference / radiusStep;
            double interpolatedHeight = height1 + ((height2 - height1) * percentageProgress);

            return interpolatedHeight;
        }

        public void ValueChanged()
        {
            Grid = new GridPoint[Dimension, Dimension];
            int halfDimension = (Dimension - 1) / 2;
            double step = (double)OuterRadius / halfDimension;
            for (int y = 0; y < Dimension; y++)
            {
                for (int x = 0; x < Dimension; x++)
                {
                    Grid[y, x] = new GridPoint();
                    double xCoord = (x - halfDimension) * step;
                    double yCoord = (y - halfDimension) * step;
                    double radiusSquare = (xCoord * xCoord) + (yCoord * yCoord);
                    if (radiusSquare <= OuterRadius * OuterRadius)
                    {
                        Grid[y, x].InCircle = true;
                    }
                    else
                    {
                        Grid[y, x].InCircle = false;
                    }

                    double interpolatedHeight = GetHeight(xCoord, yCoord);
                    Grid[y, x].Value = interpolatedHeight;
                }
            }

            this.Refresh();
        }

        public void SetAll(double value)
        {
            for (int i = 0; i < Rings; i++)
            {
                for (int j = 0; j < PerimeterPoints; j++)
                {
                    RingArray[i].ringPoints[j].QuickSetValue(value);
                }
            }
            ValueChanged();
        }

        public void InterpolateLine()
        {
            if (SelectedRingPoint != null)
            {
                double start = RingArray[0].ringPoints[SelectedRingPoint.SpokeIndex].Value;
                double end = RingArray[Rings - 1].ringPoints[SelectedRingPoint.SpokeIndex].Value;
                double step = (end - start) / (Rings - 1);

                for (int i = 1; i < Rings - 1; i++)
                {
                    RingArray[i].ringPoints[SelectedRingPoint.SpokeIndex].QuickSetValue(start + (i * step));
                }
                ValueChanged();
            }
        }
    }

    public class Ring
    {
        public RingPoint[] ringPoints;
        public double RingRadius;

        public Ring(double ringRadius, int perimeterPoints, ValueChangedMethod valueChanged)
        {
            RingRadius = ringRadius;
            ringPoints = new RingPoint[perimeterPoints];
            int ringArcStep = 360 / perimeterPoints;

            for (int j = 0; j < perimeterPoints; j++)
            {
                int arcAngle = j * ringArcStep;
                int workAngle = arcAngle % 90;

                double y = Math.Cos(workAngle * (Math.PI / 180));
                double x = Math.Sin(workAngle * (Math.PI / 180));

                if (arcAngle >= 0 && arcAngle < 90)
                {
                    y = -y;
                }
                else if (arcAngle >= 90 && arcAngle < 180)
                {
                    double temp = y;
                    y = x;
                    x = temp;
                }
                else if (arcAngle >= 180 && arcAngle < 270)
                {
                    x = -x;
                }
                else if (arcAngle >= 270 && arcAngle < 360)
                {
                    double temp = y;
                    y = -x;
                    x = -temp;
                }

                double scaledX = x * ringRadius;
                double scaledY = y * ringRadius;

                ringPoints[j] = new RingPoint(this, scaledX, scaledY, j, valueChanged);
            }
        }
    }

    public class RingPoint
    {
        public Ring ParentRing;
        public double X;
        public double Y;
        public int SpokeIndex;
        private double value;
        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
                ValueChanged();
            }
        }

        ValueChangedMethod ValueChanged;

        public RingPoint(Ring parentRing, double x, double y, int spokeIndex, ValueChangedMethod valueChanged)
        {
            ParentRing = parentRing;
            X = x;
            Y = y;
            SpokeIndex = spokeIndex;
            ValueChanged = valueChanged;
        }

        /// <summary>
        /// Only use this to bypass the automatic ValueChanged() call included in the standard value changed. I.e. when changing a lot of values at once. Remember to call ValueChanged() manually
        /// </summary>
        /// <param name="value"></param>
        public void QuickSetValue(double value)
        {
            this.value = value;
        }
    }

    public class GridPoint
    {
        public double Value = 0;
        public bool InCircle = false;
    }
}
