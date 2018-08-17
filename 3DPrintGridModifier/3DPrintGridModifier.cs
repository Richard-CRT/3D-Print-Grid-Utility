using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DPrintGridModifier
{
    public partial class Form3DPrintGridModifier : Form
    {

        /*
         * 
         * Grid View
         * 
         */

        private const int cellDimensions = 35;

        DataTable dataTable;
        private bool FileLoaded = false;
        private int Radius;
        private int Dimension;

        public Form3DPrintGridModifier()
        {
            InitializeComponent();
        }

        private void Form3DPrintGridModifier_Load(object sender, EventArgs e)
        {
            //DoubleToBinaryBytes(Math.Pow(10, -38));

            /*
             * grid
             */
            ToolTip.SetToolTip(ButtonOpenFile, "Opens a .grid file for editing/viewing from a chosen location");
            ToolTip.SetToolTip(ButtonSave, "Saves a .grid file to a chosen location");
            ToolTip.SetToolTip(ButtonClose, "Closes the currently open .grid file");
            ToolTip.SetToolTip(TextBoxCellEditor, "Field to enter/edit the height value of a cell");
            ToolTip.SetToolTip(ButtonSetGrid, "Copies the value in the field to the left into the cell");
            ToolTip.SetToolTip(TextBoxMultiply, "Field to enter a multiplication factor");
            ToolTip.SetToolTip(ButtonMultiply, "Multiplies all the selected cell values by the factor in the field to the left");
            ToolTip.SetToolTip(TextBoxAdd, "Field to enter an addition offset (negative for subtraction)");
            ToolTip.SetToolTip(ButtonAdd, "Adds the value in the field to the left to all selected cell values");
            ToolTip.SetToolTip(LabelDimension, "Displays the dimension/count of the grid being displayed");
            ToolTip.SetToolTip(LabelRadius, "Displays the radius (mm) of the circle in the grid being displayed");
            ToolTip.SetToolTip(LabelGridXCoord, "Displays the X coordinate of the selected cell");
            ToolTip.SetToolTip(LabelGridYCoord, "Displays the Y coordinate of the selected cell");

            /*
             * radial
             */
            ToolTip.SetToolTip(LabelRings, "Specifies the number of rings on the circle");
            ToolTip.SetToolTip(NumericUpDownRingCount, "Field to change the number of rings on the circle");
            ToolTip.SetToolTip(LabelPerimeterPoints, "Specifies the number of nodes on the rings (must be a divisor of 360)");
            ToolTip.SetToolTip(NumericUpDownPerimeterPoints, "Field to change the number of nodes on the rings (must be a divisor of 360)");
            ToolTip.SetToolTip(LabelRadialDimension, "Specifies the dimension of the grid that is generated");
            ToolTip.SetToolTip(NumericUpDownDimension, "Field to change the dimension of the grid that is generated");
            ToolTip.SetToolTip(LabelOuterRadius, "Specifies the outer radius of the circle in the grid file that is generated (mm)");
            ToolTip.SetToolTip(NumericUpDownOuterRadius, "Field to change the radius of the circle in the grid file that is generated (mm)");
            ToolTip.SetToolTip(LabelInnerRadius, "Specifies the inner radius of the circle (mm). The center node will always have a height of 0");
            ToolTip.SetToolTip(NumericUpDownOuterRadius, "Field to change the inner radius of the circle (mm). The center node will always have a height of 0");
            ToolTip.SetToolTip(LabelRadialXCoord, "Displays the X coordinate of the point last clicked (mm)");
            ToolTip.SetToolTip(LabelRadialYCoord, "Displays the Y coordinate of the point last clicked (mm)");
            ToolTip.SetToolTip(LabelRadialHeight, "Displays the interpolated height value of the point last clicked");
            ToolTip.SetToolTip(TextBoxRadialValue, "Field to enter/edit the height value of a node");
            ToolTip.SetToolTip(ButtonSet, "Sets the height value of the selected node to the value in the field to the left");
            ToolTip.SetToolTip(ButtonSetAll, "Sets the height value of all nodes to the value in the field to the left");
            ToolTip.SetToolTip(ButtonInterpolateLine, "Will automatically calculate a smooth gradient for the nodes on a selected spoke between the inner-most node and outer-most node");
            ToolTip.SetToolTip(ButtonExportGrid, "Exports (saves) a .grid file using interpolated heights to a chosen location. This format cannot be reloaded into the radial editor");
            ToolTip.SetToolTip(ButtonSaveRadialData, "Saves a .raddata file that can be reloaded into the radial editor to a chosen location. This file is not compatible with the grid editor");
            ToolTip.SetToolTip(ButtonLoadRadialData, "Loads a previously saved .raddata file back into the radial editor from a chosen location");
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            //double[] decimalValues = new double[] { -0.1066, -0.0877, -0.0063, -0.0313, -0.094, -0.1316, -0.2131, -0.3323, -0.3385, -0.3448, -0.3448, -0.4074, -0.4702, -0.5078, -0.42, -0.3322, -0.4137, -0.4639, -0.1379, -0.0439, -0.2319, -0.0064, -0.0878, -0.0752, -0.0125, -0.0627, -0.1128, -0.1379, -0.1943, -0.257, -0.2633, -0.2946, -0.3448, -0.3949, -0.3699, -0.3134, -0.3824, -0.3886, -0.1693, -0.1128, -0.2194, -0.3009, -0.0001, -0.0063, -0.069, -0.0627, -0.0188, -0.094, -0.1317, -0.1442, -0.1755, -0.1818, -0.2132, -0.2821, -0.3197, -0.351, -0.351, -0.3134, -0.2006, -0.1818, -0.2068, -0.2319, -0.3072, -0.0063, -0.0063, -0.0063, -0.0502, -0.0502, -0.0753, -0.1254, -0.1129, -0.1317, -0.1317, -0.1567, -0.1818, -0.2194, -0.2508, -0.2382, -0.2445, -0.2508, -0.1943, -0.2132, -0.2382, -0.3134, 0, -0.0189, -0.0126, -0.0063, -0.0314, -0.0377, -0.0815, -0.0941, -0.0752, -0.0815, -0.1254, -0.1191, -0.1505, -0.1567, -0.1881, -0.1693, -0.1818, -0.2069, -0.1693, -0.2194, -0.2507, -0.025, 0, -0.0188, -0.0188, -0.0126, -0.0502, -0.0627, -0.0627, -0.0627, -0.0439, -0.0502, -0.069, -0.0878, -0.1003, -0.0941, -0.069, -0.069, -0.1003, -0.1254, -0.1505, -0.1442, -0.0501, -0.0251, 0, 0.025, 0, -0.0126, -0.0188, -0.0314, -0.0251, 0, -0.0126, -0.0188, -0.0439, -0.0376, -0.0314, -0.0188, -0.0063, -0.0314, -0.069, -0.0564, -0.0376, -0.0753, -0.0502, -0.0188, -0.0376, -0.0063, -0.0314, -0.0251, -0.0314, -0.0125, 0.025, 0, 0.0062, -0.0188, 0, 0.0251, 0.0251, 0.0439, 0.0313, 0.0313, 0.0063, 0.0125, -0.1066, -0.0502, -0.0251, -0.0502, -0.0063, -0.0251, -0.0314, -0.0063, 0, 0.0125, 0.0313, 0.0188, 0.0125, 0.0313, 0.0501, 0.0501, 0.0564, 0.0501, 0.0439, 0.0376, 0.0627, -0.1379, -0.0941, -0.0502, -0.0439, -0.0753, -0.0377, -0.0439, -0.0502, -0.0126, 0, 0.0313, 0.0251, 0.0251, 0.0125, 0.0564, 0.0752, 0.0627, 0.0627, 0.0627, 0.0564, 0.0501, -0.1693, -0.1129, -0.0752, -0.0439, -0.069, -0.0377, -0.0502, -0.0564, -0.0376, -0.0251, -0.0063, 0.0188, 0.0188, -0.0063, 0.0627, 0.0439, 0.0627, 0.0627, 0.0376, 0.0564, 0.0376, -0.1693, -0.1442, -0.1191, -0.1066, -0.0941, -0.1129, -0.1003, -0.069, -0.069, -0.0063, -0.0063, -0.0063, 0, -0.0063, 0.0376, 0.0188, 0.0439, 0.0313, 0.0689, 0.0251, -0.0188, -0.1818, -0.1505, -0.1191, -0.1254, -0.0941, -0.0941, -0.1003, -0.0439, -0.0815, -0.0815, -0.0564, -0.0188, -0.0188, 0.0251, 0.0063, 0, 0.0188, -0.0063, 0.0062, -0.0188, -0.0439, -0.1818, -0.163, -0.1693, -0.1505, -0.1505, -0.1567, -0.1379, -0.1254, -0.1129, -0.094, -0.069, -0.0439, -0.0251, -0.0188, -0.0251, -0.0314, -0.0063, -0.0377, -0.0439, -0.0188, -0.069, -0.2068, -0.2194, -0.1881, -0.163, -0.1755, -0.1505, -0.1066, -0.1129, -0.1066, -0.1129, -0.0564, -0.069, -0.0188, -0.0188, 0.0313, -0.0376, -0.0313, -0.0439, -0.0753, -0.0502, -0.0439, -0.2508, -0.2257, -0.2006, -0.1943, -0.1755, -0.1567, -0.1442, -0.1317, -0.1191, -0.1191, -0.0941, -0.0627, -0.0627, -0.0314, -0.0126, -0.0251, -0.0251, -0.0439, -0.0627, -0.0815, -0.0564, -0.2633, -0.2319, -0.2006, -0.1944, -0.1818, -0.1693, -0.1505, -0.1254, -0.1254, -0.1129, -0.1066, -0.0752, -0.0564, -0.0251, -0.0313, -0.0251, -0.0377, -0.0627, -0.0627, -0.0815, -0.0878, -0.2633, -0.2132, -0.2132, -0.2132, -0.2006, -0.1693, -0.163, -0.1317, -0.1254, -0.1129, -0.1066, -0.0752, -0.0753, -0.0439, -0.0565, -0.0439, -0.0377, -0.0439, -0.0627, -0.0815, -0.1003, -0.2258, -0.232, -0.2445, -0.232, -0.1881, -0.1818, -0.1442, -0.1505, -0.1254, -0.1003, -0.0815, -0.0439, -0.0752, -0.0627, -0.0502, -0.069, -0.069, -0.0502, -0.0502, -0.0628, -0.1004, -0.2509, -0.2758, -0.2633, -0.2069, -0.1818, -0.1567, -0.1317, -0.1191, -0.0752, -0.0753, -0.0376, -0.0251, -0.0439, -0.0376, -0.0564, -0.0752, -0.094, -0.0941, -0.0627, -0.044, -0.0628, -0.3072, -0.2946, -0.2257, -0.1819, -0.1693, -0.1317, -0.1129, -0.0753, -0.0627, -0.0502, -0.0376, -0.0063, 0.025, -0.0125, -0.0501, -0.0815, -0.1128, -0.1379, -0.1191, -0.0753, -0.0314 };

            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Grid Files|*.grid";
            openFileDialog.Title = "Select a grid";

            // Show the Dialog.  
            // If the user clicked OK in the dialog
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.CheckFileExists)
            {
                byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);

                Dimension = (int)fileBytes[0];
                TextBoxDimension.Text = Dimension.ToString();

                Radius = (int)BinaryBytesToDouble(fileBytes[1], fileBytes[2], fileBytes[3], fileBytes[4]);
                TextBoxRadius.Text = Radius.ToString();

                dataTable = new DataTable();
                DataGridView1.DataSource = dataTable;
                DataGridView1.RowHeadersWidth = 50;

                DataColumn headerColumn = new DataColumn();

                for (int i = 1; i <= Dimension; i++)
                {
                    DataColumn tempColumn = new DataColumn();
                    tempColumn.DataType = Type.GetType("System.Double");
                    tempColumn.ColumnName = i.ToString();
                    dataTable.Columns.Add(tempColumn);

                    DataGridView1.Columns[i - 1].Width = (int)Math.Floor((DataGridView1.Width - 50) / (double)Dimension);
                    DataGridView1.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 1; i <= Dimension; i++)
                {
                    DataRow tempRow = dataTable.NewRow();
                    dataTable.Rows.Add(tempRow);

                    DataGridView1.Rows[i - 1].Height = (int)Math.Floor((DataGridView1.Width - 50) / (double)Dimension);
                    DataGridView1.Rows[i - 1].HeaderCell.Value = i.ToString();
                }

                List<List<byte[]>> data = new List<List<byte[]>>();

                for (int y = 0; y < Dimension; y++)
                {
                    List<byte[]> tempList = new List<byte[]>();
                    for (int x = 0; x < Dimension; x++)
                    {
                        int i = y * Dimension + x;
                        byte[] tempByteArray = new byte[] { fileBytes[1 + ((i + 1) * 4)], fileBytes[1 + ((i + 1) * 4) + 1], fileBytes[1 + ((i + 1) * 4) + 2], fileBytes[1 + ((i + 1) * 4) + 3] };

                        tempList.Add(tempByteArray);
                    }
                    data.Add(tempList);
                }
                data.Reverse();

                for (int y = 0; y < Dimension; y++)
                {
                    for (int x = 0; x < Dimension; x++)
                    {
                        dataTable.Rows[y][x] = BinaryBytesToDouble(data[y][x][0], data[y][x][1], data[y][x][2], data[y][x][3]);

                        int adjustedX = Math.Abs(x - ((Dimension - 1) / 2)) * (Radius / ((Dimension - 1) / 2));
                        int adjustedY = Math.Abs(y - ((Dimension - 1) / 2)) * (Radius / ((Dimension - 1) / 2));
                        double hypotenus = Math.Sqrt(Math.Pow(adjustedX, 2) + Math.Pow(adjustedY, 2));
                        if (hypotenus > Radius)
                        {
                            DataGridView1.Rows[y].Cells[x].Style.Font = new Font(DataGridView1.DefaultCellStyle.Font, FontStyle.Bold);
                        }
                    }
                }

                UpdateBoard();
                //DataRow tempRow = dataTable.NewRow();
                //dataTable.Rows.Add();

                FileLoaded = true;
                ButtonSave.Enabled = true;
                ButtonClose.Enabled = true;
                ButtonMultiply.Enabled = true;
                ButtonAdd.Enabled = true;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (FileLoaded)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "Grid Files|*.grid";
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<byte> fileBytes = new List<byte>();

                    // Dimension
                    fileBytes.Add((byte)Dimension);

                    // Radius
                    byte[] radiusBytes = DoubleToBinaryBytes(Radius);
                    fileBytes.AddRange(radiusBytes);

                    // Grid
                    List<List<byte[]>> data = new List<List<byte[]>>();

                    for (int y = 0; y < Dimension; y++)
                    {
                        List<byte[]> tempList = new List<byte[]>();
                        for (int x = 0; x < Dimension; x++)
                        {
                            byte[] tempByteArray = DoubleToBinaryBytes((double)dataTable.Rows[y][x]);

                            tempList.Add(tempByteArray);
                        }
                        data.Add(tempList);
                    }
                    data.Reverse();

                    for (int y = 0; y < Dimension; y++)
                    {
                        for (int x = 0; x < Dimension; x++)
                        {
                            fileBytes.AddRange(data[y][x]);
                        }
                    }

                    File.WriteAllBytes(saveFileDialog.FileName, fileBytes.ToArray());
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (FileLoaded)
            {
                Radius = 0;
                Dimension = 0;
                DataGridView1.Columns.Clear();
                dataTable.Clear();
                dataTable.Dispose();
                TextBoxDimension.Text = "";
                TextBoxRadius.Text = "";
                TextBoxCellEditor.Text = "";
                TextBoxGridXCoord.Text = "";
                TextBoxGridYCoord.Text = "";

                FileLoaded = false;
                ButtonSave.Enabled = false;
                ButtonClose.Enabled = false;
                ButtonMultiply.Enabled = false;
                ButtonAdd.Enabled = false;
            }
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            if (FileLoaded)
            {
                try
                {
                    double factor = Double.Parse(TextBoxMultiply.Text);
                    for (int i = 0; i < DataGridView1.SelectedCells.Count; i++)
                    {
                        DataGridView1.SelectedCells[i].Value = ((double)DataGridView1.SelectedCells[i].Value) * factor;
                    }
                    UpdateBoard();
                }
                catch (FormatException)
                {

                }
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (FileLoaded)
            {
                try
                {
                    double offset = Double.Parse(TextBoxAdd.Text);
                    for (int i = 0; i < DataGridView1.SelectedCells.Count; i++)
                    {
                        DataGridView1.SelectedCells[i].Value = ((double)DataGridView1.SelectedCells[i].Value) + offset;
                    }
                    UpdateBoard();
                }
                catch (FormatException)
                {

                }
            }
        }

        byte[] DoubleToBinaryBytes(double value)
        {
            string binaryString = "";
            if (value < 0)
            {
                binaryString += '1';
            }
            else
            {
                binaryString += '0';
            }
            value = Math.Abs(value);

            int exponent = 0;
            double resultant = 0;

            while (exponent > -127 && exponent < 126 && (resultant < 1 || resultant >= 2))
            {
                if (resultant < 1)
                {
                    exponent--;
                }
                else
                {
                    exponent++;
                }
                resultant = value / Math.Pow(2, exponent);
            }

            exponent += 127;

            if (exponent > 0)
            {
                resultant -= 1;
            }
            else
            {
                resultant = value / Math.Pow(2, -126);
            }

            binaryString += Convert.ToString(exponent, 2).PadLeft(8, '0');

            binaryString += FractionDoubleToBinaryString(resultant);

            byte[] byteArray = new byte[4];
            byteArray[3] = Convert.ToByte(binaryString.Substring(0, 8), 2);
            byteArray[2] = Convert.ToByte(binaryString.Substring(8, 8), 2);
            byteArray[1] = Convert.ToByte(binaryString.Substring(16, 8), 2);
            byteArray[0] = Convert.ToByte(binaryString.Substring(24, 8), 2);

            return byteArray;
        }

        string FractionDoubleToBinaryString(double fraction)
        {
            string binaryString = "";

            for (int i = 1; i <= 23; i++)
            {
                double currentBinaryFraction = Math.Pow(2, -i);
                if (fraction >= currentBinaryFraction)
                {
                    fraction -= currentBinaryFraction;
                    binaryString += '1';
                }
                else
                {
                    binaryString += '0';
                }
            }

            return binaryString;
        }

        double BinaryBytesToDouble(byte byte1, byte byte2, byte byte3, byte byte4)
        {
            string binaryString = "";
            binaryString += Convert.ToString(byte4, 2).PadLeft(8, '0');
            binaryString += Convert.ToString(byte3, 2).PadLeft(8, '0');
            binaryString += Convert.ToString(byte2, 2).PadLeft(8, '0');
            binaryString += Convert.ToString(byte1, 2).PadLeft(8, '0');

            /*
            Console.Write(binaryString.Substring(0, 1) + " ");
            Console.Write(binaryString.Substring(1, 8) + " ");
            Console.Write(binaryString.Substring(9));

            Console.Write(" : ");

            if (binaryString[0] == 0)
            {
                Console.Write("+ve ");
            }
            else
            {
                Console.Write("-ve ");
            }
            */

            int exponent = Convert.ToInt32(binaryString.Substring(1, 8), 2) - 127;
            bool underflow = false;
            if (exponent == -127)
            {
                underflow = true;
                exponent = -126;
            }
            //Console.Write("2^" + exponent + " ");

            double mantissa = BinaryStringToFractionDouble(binaryString.Substring(9));
            //Console.Write(mantissa + " ");
            if (!underflow)
            {
                mantissa += 1;
            }

            //Console.Write(" : ");

            double value = (mantissa) * Math.Pow(2, exponent);
            if (binaryString[0] == '1')
            {
                value *= -1;
            }

            //Console.Write(value);

            //Console.WriteLine();

            return value;
        }

        double BinaryStringToFractionDouble(string binaryString)
        {
            double totalValue = 0;

            for (int i = 1; i <= binaryString.Length; i++)
            {
                if (binaryString[i - 1] == '1')
                {
                    totalValue += Math.Pow(2, -i);
                }
            }

            return totalValue;
        }

        private void UpdateBoard()
        {
            double largestValue = GetLargestAbsoluteValue();

            for (int y = 0; y < Dimension; y++)
            {
                for (int x = 0; x < Dimension; x++)
                {
                    double value = (double)dataTable.Rows[y][x];

                    double percentage = 1 - (Math.Abs(value) / largestValue);
                    if ( percentage < 0)
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

                    DataGridView1.Rows[y].Cells[x].Style.BackColor = newCellColour;
                }
            }
        }

        private double GetLargestAbsoluteValue()
        {
            double largestAbsoluteValue = 0;

            for (int y = 0; y < Dimension; y++)
            {
                for (int x = 0; x < Dimension; x++)
                {
                    int adjustedX = Math.Abs(x - ((Dimension - 1) / 2)) * (Radius / ((Dimension - 1) / 2));
                    int adjustedY = Math.Abs(y - ((Dimension - 1) / 2)) * (Radius / ((Dimension - 1) / 2));
                    double hypotenus = Math.Sqrt(Math.Pow(adjustedX, 2) + Math.Pow(adjustedY, 2));

                    if (hypotenus <= Radius)
                    {
                        double abs = Math.Abs((double)dataTable.Rows[y][x]);
                        if (abs > largestAbsoluteValue)
                        {
                            largestAbsoluteValue = abs;
                        }
                    }
                }
            }

            return largestAbsoluteValue;
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TextBoxCellEditor.Text = ((double)dataTable.Rows[e.RowIndex][e.ColumnIndex]).ToString("N9");
            TextBoxGridXCoord.Text = (e.ColumnIndex + 1).ToString();
            TextBoxGridYCoord.Text = (e.RowIndex + 1).ToString();
        }

        private void TextBoxCellEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && FileLoaded)
            {
                e.SuppressKeyPress = true;
                ButtonSetGrid_Click(null, null);
                UpdateBoard();
            }
        }

        private void ButtonSetGrid_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridView1.SelectedCells.Count; i++)
            {
                try
                {
                    DataGridView1.SelectedCells[i].Value = Double.Parse(TextBoxCellEditor.Text);
                }
                catch (FormatException)
                {

                }
            }
            UpdateBoard();
        }

        /*
         * 
         * Radial View
         * 
         */

        private void NumericUpDownRingCount_ValueChanged(object sender, EventArgs e)
        {
            RadialGenerator1.Rings = (int)((NumericUpDown)sender).Value;
            ClearCusor();
        }

        private void NumericUpDownPerimeterPoints_ValueChanged(object sender, EventArgs e)
        {
            RadialGenerator1.PerimeterPoints = (int)((NumericUpDown)sender).Value;
            ClearCusor();
        }

        private void NumericUpDownDimension_ValueChanged(object sender, EventArgs e)
        {
            RadialGenerator1.Dimension = (int)((NumericUpDown)sender).Value;
        }

        private void NumericUpDownOuterRadius_ValueChanged(object sender, EventArgs e)
        {
            RadialGenerator1.OuterRadius = (int)((NumericUpDown)sender).Value;
            ClearCusor();
        }

        private void NumericUpDownInnerRadius_ValueChanged(object sender, EventArgs e)
        {
            RadialGenerator1.InnerRadius = (int)((NumericUpDown)sender).Value;
            ClearCusor();
        }

        private void TextBoxRadialValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButtonSet_Click(null, null);
            }
        }

        private void RadialGenerator1_NodeSelected(object sender, EventArgs e)
        {
            RingPoint ringPoint = sender as RingPoint;
            TextBoxRadialValue.Text = ringPoint.Value.ToString("N9");
        }

        private void RadialGenerator1_NodeUnselected(object sender, EventArgs e)
        {
            TextBoxRadialValue.Text = "";
        }

        private void RadialGenerator1_GridClicked(double x, double y, double height)
        {
            TextBoxRadialXCoord.Text = x.ToString("N5");
            TextBoxRadialYCoord.Text = y.ToString("N5");
            TextBoxRadialHeight.Text = height.ToString("N12");
        }

        private void ClearCusor()
        {
            TextBoxRadialXCoord.Text = "";
            TextBoxRadialYCoord.Text = "";
            TextBoxRadialHeight.Text = "";
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadialGenerator1.SelectedRingPoint != null)
                {
                    RadialGenerator1.SelectedRingPoint.Value = Double.Parse(TextBoxRadialValue.Text);
                    ClearCusor();
                }
            }
            catch (FormatException)
            {

            }
        }

        private void ButtonSetAll_Click(object sender, EventArgs e)
        {
            try
            {
                RadialGenerator1.SetAll(Double.Parse(TextBoxRadialValue.Text));
                ClearCusor();
            }
            catch (FormatException)
            {

            }
        }

        private void ButtonInterpolateLine_Click(object sender, EventArgs e)
        {
            RadialGenerator1.InterpolateLine();
            ClearCusor();
        }

        private void ButtonExportGrid_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Grid Files|*.grid";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<byte> fileBytes = new List<byte>();

                // Dimension
                fileBytes.Add((byte)RadialGenerator1.Dimension);

                // Radius
                byte[] radiusBytes = DoubleToBinaryBytes(RadialGenerator1.OuterRadius);
                fileBytes.AddRange(radiusBytes);

                // Grid
                List<List<byte[]>> data = new List<List<byte[]>>();

                for (int y = 0; y < RadialGenerator1.Dimension; y++)
                {
                    List<byte[]> tempList = new List<byte[]>();
                    for (int x = 0; x < RadialGenerator1.Dimension; x++)
                    {
                        byte[] tempByteArray = DoubleToBinaryBytes(RadialGenerator1.Grid[y, x].Value);

                        tempList.Add(tempByteArray);
                    }
                    data.Add(tempList);
                }
                data.Reverse();

                for (int y = 0; y < RadialGenerator1.Dimension; y++)
                {
                    for (int x = 0; x < RadialGenerator1.Dimension; x++)
                    {
                        fileBytes.AddRange(data[y][x]);
                    }
                }

                File.WriteAllBytes(saveFileDialog.FileName, fileBytes.ToArray());
            }
        }

        private void ButtonSaveRadialData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Radial Data Files|*.raddata";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<byte> fileBytes = new List<byte>();

                fileBytes.Add((byte)RadialGenerator1.Rings);
                fileBytes.Add((byte)RadialGenerator1.PerimeterPoints);
                fileBytes.Add((byte)RadialGenerator1.Dimension);
                fileBytes.Add((byte)RadialGenerator1.OuterRadius);
                fileBytes.Add((byte)RadialGenerator1.InnerRadius);

                for (int i = 0; i < RadialGenerator1.Rings; i++)
                {
                    for (int j = 0; j < RadialGenerator1.PerimeterPoints; j++)
                    {
                        fileBytes.AddRange(BitConverter.GetBytes(RadialGenerator1.RingArray[i].ringPoints[j].Value));
                    }
                }

                File.WriteAllBytes(saveFileDialog.FileName, fileBytes.ToArray());
            }
        }

        private void ButtonLoadRadialData_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Radial Data Files|*.raddata";
            openFileDialog.Title = "Select a radial data file";

            // Show the Dialog.  
            // If the user clicked OK in the dialog
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog.CheckFileExists)
            {
                byte[] fileBytes = File.ReadAllBytes(openFileDialog.FileName);

                RadialGenerator1.Rings = fileBytes[0];
                NumericUpDownRingCount.Value = RadialGenerator1.Rings;
                RadialGenerator1.PerimeterPoints = fileBytes[1];
                NumericUpDownPerimeterPoints.Value = RadialGenerator1.PerimeterPoints;
                RadialGenerator1.Dimension = fileBytes[2];
                NumericUpDownDimension.Value = RadialGenerator1.Dimension;
                RadialGenerator1.OuterRadius = fileBytes[3];
                NumericUpDownOuterRadius.Value = RadialGenerator1.OuterRadius;
                RadialGenerator1.InnerRadius = fileBytes[4];
                NumericUpDownInnerRadius.Value = RadialGenerator1.InnerRadius;

                for (int i = 0; i < RadialGenerator1.Rings; i++)
                {
                    int frameStartIndex = 5 + (i * RadialGenerator1.PerimeterPoints * 8);
                    for (int j = 0; j < RadialGenerator1.PerimeterPoints; j++)
                    {
                        int subFrameStartIndex = frameStartIndex + (j * 8);
                        double value = BitConverter.ToDouble(fileBytes, subFrameStartIndex);
                        RadialGenerator1.RingArray[i].ringPoints[j].QuickSetValue(value);
                    }
                }

                ClearCusor();
                RadialGenerator1.ValueChanged();
            }
        }
    }
}
