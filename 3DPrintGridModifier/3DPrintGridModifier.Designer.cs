namespace _3DPrintGridModifier
{
    partial class Form3DPrintGridModifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3DPrintGridModifier));
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxCellEditor = new System.Windows.Forms.TextBox();
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelRadius = new System.Windows.Forms.Label();
            this.TextBoxRadius = new System.Windows.Forms.TextBox();
            this.TextBoxDimension = new System.Windows.Forms.TextBox();
            this.LabelDimension = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxMultiply = new System.Windows.Forms.TextBox();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TextBoxAdd = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxGridYCoord = new System.Windows.Forms.TextBox();
            this.LabelGridYCoord = new System.Windows.Forms.Label();
            this.LabelGridXCoord = new System.Windows.Forms.Label();
            this.TextBoxGridXCoord = new System.Windows.Forms.TextBox();
            this.ButtonSetGrid = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.LabelRadialHeight = new System.Windows.Forms.Label();
            this.TextBoxRadialHeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxRadialYCoord = new System.Windows.Forms.TextBox();
            this.LabelRadialYCoord = new System.Windows.Forms.Label();
            this.LabelRadialXCoord = new System.Windows.Forms.Label();
            this.TextBoxRadialXCoord = new System.Windows.Forms.TextBox();
            this.LabelInnerRadius = new System.Windows.Forms.Label();
            this.LabelOuterRadius = new System.Windows.Forms.Label();
            this.LabelRadialDimension = new System.Windows.Forms.Label();
            this.LabelPerimeterPoints = new System.Windows.Forms.Label();
            this.LabelRings = new System.Windows.Forms.Label();
            this.ButtonLoadRadialData = new System.Windows.Forms.Button();
            this.ButtonSaveRadialData = new System.Windows.Forms.Button();
            this.NumericUpDownInnerRadius = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownOuterRadius = new System.Windows.Forms.NumericUpDown();
            this.ButtonExportGrid = new System.Windows.Forms.Button();
            this.ButtonSet = new System.Windows.Forms.Button();
            this.ButtonInterpolateLine = new System.Windows.Forms.Button();
            this.NumericUpDownDimension = new System.Windows.Forms.NumericUpDown();
            this.ButtonSetAll = new System.Windows.Forms.Button();
            this.TextBoxRadialValue = new System.Windows.Forms.TextBox();
            this.NumericUpDownPerimeterPoints = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRingCount = new System.Windows.Forms.NumericUpDown();
            this.RadialGenerator1 = new _3DPrintGridModifier.RadialGenerator();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInnerRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOuterRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDimension)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPerimeterPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRingCount)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N9";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(6, 63);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView1.Size = new System.Drawing.Size(787, 758);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // TextBoxCellEditor
            // 
            this.TextBoxCellEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCellEditor.Location = new System.Drawing.Point(249, 7);
            this.TextBoxCellEditor.Name = "TextBoxCellEditor";
            this.TextBoxCellEditor.Size = new System.Drawing.Size(463, 22);
            this.TextBoxCellEditor.TabIndex = 1;
            this.TextBoxCellEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxCellEditor_KeyDown);
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Location = new System.Drawing.Point(6, 6);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenFile.TabIndex = 2;
            this.ButtonOpenFile.Text = "Open";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(87, 6);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelRadius
            // 
            this.LabelRadius.AutoSize = true;
            this.LabelRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRadius.Location = new System.Drawing.Point(510, 38);
            this.LabelRadius.Name = "LabelRadius";
            this.LabelRadius.Size = new System.Drawing.Size(54, 16);
            this.LabelRadius.TabIndex = 4;
            this.LabelRadius.Text = "Radius:";
            // 
            // TextBoxRadius
            // 
            this.TextBoxRadius.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRadius.Location = new System.Drawing.Point(564, 34);
            this.TextBoxRadius.Name = "TextBoxRadius";
            this.TextBoxRadius.ReadOnly = true;
            this.TextBoxRadius.Size = new System.Drawing.Size(64, 22);
            this.TextBoxRadius.TabIndex = 5;
            this.TextBoxRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TextBoxDimension
            // 
            this.TextBoxDimension.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDimension.Location = new System.Drawing.Point(440, 34);
            this.TextBoxDimension.Name = "TextBoxDimension";
            this.TextBoxDimension.ReadOnly = true;
            this.TextBoxDimension.Size = new System.Drawing.Size(64, 22);
            this.TextBoxDimension.TabIndex = 6;
            this.TextBoxDimension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelDimension
            // 
            this.LabelDimension.AutoSize = true;
            this.LabelDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDimension.Location = new System.Drawing.Point(361, 37);
            this.LabelDimension.Name = "LabelDimension";
            this.LabelDimension.Size = new System.Drawing.Size(75, 16);
            this.LabelDimension.TabIndex = 7;
            this.LabelDimension.Text = "Dimension:";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Enabled = false;
            this.ButtonClose.Location = new System.Drawing.Point(168, 6);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 8;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TextBoxMultiply
            // 
            this.TextBoxMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMultiply.Location = new System.Drawing.Point(6, 35);
            this.TextBoxMultiply.Name = "TextBoxMultiply";
            this.TextBoxMultiply.Size = new System.Drawing.Size(66, 22);
            this.TextBoxMultiply.TabIndex = 9;
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Enabled = false;
            this.ButtonMultiply.Location = new System.Drawing.Point(78, 34);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(99, 23);
            this.ButtonMultiply.TabIndex = 10;
            this.ButtonMultiply.Text = "Multiply Selected";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(807, 853);
            this.TabControl1.TabIndex = 11;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.TextBoxAdd);
            this.TabPage1.Controls.Add(this.ButtonAdd);
            this.TabPage1.Controls.Add(this.label10);
            this.TabPage1.Controls.Add(this.TextBoxGridYCoord);
            this.TabPage1.Controls.Add(this.LabelGridYCoord);
            this.TabPage1.Controls.Add(this.LabelGridXCoord);
            this.TabPage1.Controls.Add(this.TextBoxGridXCoord);
            this.TabPage1.Controls.Add(this.ButtonSetGrid);
            this.TabPage1.Controls.Add(this.ButtonOpenFile);
            this.TabPage1.Controls.Add(this.DataGridView1);
            this.TabPage1.Controls.Add(this.ButtonMultiply);
            this.TabPage1.Controls.Add(this.TextBoxCellEditor);
            this.TabPage1.Controls.Add(this.TextBoxMultiply);
            this.TabPage1.Controls.Add(this.ButtonSave);
            this.TabPage1.Controls.Add(this.ButtonClose);
            this.TabPage1.Controls.Add(this.LabelRadius);
            this.TabPage1.Controls.Add(this.LabelDimension);
            this.TabPage1.Controls.Add(this.TextBoxRadius);
            this.TabPage1.Controls.Add(this.TextBoxDimension);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(799, 827);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Grid Modifier";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // TextBoxAdd
            // 
            this.TextBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAdd.Location = new System.Drawing.Point(183, 35);
            this.TextBoxAdd.Name = "TextBoxAdd";
            this.TextBoxAdd.Size = new System.Drawing.Size(66, 22);
            this.TextBoxAdd.TabIndex = 21;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.Location = new System.Drawing.Point(256, 34);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(99, 23);
            this.ButtonAdd.TabIndex = 20;
            this.ButtonAdd.Text = "Add to Selected";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(632, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "mm";
            // 
            // TextBoxGridYCoord
            // 
            this.TextBoxGridYCoord.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxGridYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGridYCoord.Location = new System.Drawing.Point(753, 34);
            this.TextBoxGridYCoord.Name = "TextBoxGridYCoord";
            this.TextBoxGridYCoord.ReadOnly = true;
            this.TextBoxGridYCoord.Size = new System.Drawing.Size(40, 22);
            this.TextBoxGridYCoord.TabIndex = 17;
            this.TextBoxGridYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelGridYCoord
            // 
            this.LabelGridYCoord.AutoSize = true;
            this.LabelGridYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGridYCoord.Location = new System.Drawing.Point(736, 37);
            this.LabelGridYCoord.Name = "LabelGridYCoord";
            this.LabelGridYCoord.Size = new System.Drawing.Size(18, 16);
            this.LabelGridYCoord.TabIndex = 16;
            this.LabelGridYCoord.Text = "y:";
            // 
            // LabelGridXCoord
            // 
            this.LabelGridXCoord.AutoSize = true;
            this.LabelGridXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGridXCoord.Location = new System.Drawing.Point(670, 37);
            this.LabelGridXCoord.Name = "LabelGridXCoord";
            this.LabelGridXCoord.Size = new System.Drawing.Size(17, 16);
            this.LabelGridXCoord.TabIndex = 14;
            this.LabelGridXCoord.Text = "x:";
            // 
            // TextBoxGridXCoord
            // 
            this.TextBoxGridXCoord.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxGridXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxGridXCoord.Location = new System.Drawing.Point(687, 34);
            this.TextBoxGridXCoord.Name = "TextBoxGridXCoord";
            this.TextBoxGridXCoord.ReadOnly = true;
            this.TextBoxGridXCoord.Size = new System.Drawing.Size(40, 22);
            this.TextBoxGridXCoord.TabIndex = 15;
            this.TextBoxGridXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonSetGrid
            // 
            this.ButtonSetGrid.Location = new System.Drawing.Point(718, 6);
            this.ButtonSetGrid.Name = "ButtonSetGrid";
            this.ButtonSetGrid.Size = new System.Drawing.Size(75, 24);
            this.ButtonSetGrid.TabIndex = 13;
            this.ButtonSetGrid.Text = "Set";
            this.ButtonSetGrid.UseVisualStyleBackColor = true;
            this.ButtonSetGrid.Click += new System.EventHandler(this.ButtonSetGrid_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.LabelRadialHeight);
            this.TabPage2.Controls.Add(this.TextBoxRadialHeight);
            this.TabPage2.Controls.Add(this.label12);
            this.TabPage2.Controls.Add(this.label11);
            this.TabPage2.Controls.Add(this.TextBoxRadialYCoord);
            this.TabPage2.Controls.Add(this.LabelRadialYCoord);
            this.TabPage2.Controls.Add(this.LabelRadialXCoord);
            this.TabPage2.Controls.Add(this.TextBoxRadialXCoord);
            this.TabPage2.Controls.Add(this.LabelInnerRadius);
            this.TabPage2.Controls.Add(this.LabelOuterRadius);
            this.TabPage2.Controls.Add(this.LabelRadialDimension);
            this.TabPage2.Controls.Add(this.LabelPerimeterPoints);
            this.TabPage2.Controls.Add(this.LabelRings);
            this.TabPage2.Controls.Add(this.ButtonLoadRadialData);
            this.TabPage2.Controls.Add(this.ButtonSaveRadialData);
            this.TabPage2.Controls.Add(this.NumericUpDownInnerRadius);
            this.TabPage2.Controls.Add(this.NumericUpDownOuterRadius);
            this.TabPage2.Controls.Add(this.ButtonExportGrid);
            this.TabPage2.Controls.Add(this.ButtonSet);
            this.TabPage2.Controls.Add(this.ButtonInterpolateLine);
            this.TabPage2.Controls.Add(this.NumericUpDownDimension);
            this.TabPage2.Controls.Add(this.ButtonSetAll);
            this.TabPage2.Controls.Add(this.TextBoxRadialValue);
            this.TabPage2.Controls.Add(this.NumericUpDownPerimeterPoints);
            this.TabPage2.Controls.Add(this.NumericUpDownRingCount);
            this.TabPage2.Controls.Add(this.RadialGenerator1);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(799, 827);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Radial Generator";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // LabelRadialHeight
            // 
            this.LabelRadialHeight.AutoSize = true;
            this.LabelRadialHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRadialHeight.Location = new System.Drawing.Point(586, 754);
            this.LabelRadialHeight.Name = "LabelRadialHeight";
            this.LabelRadialHeight.Size = new System.Drawing.Size(50, 16);
            this.LabelRadialHeight.TabIndex = 30;
            this.LabelRadialHeight.Text = "Height:";
            // 
            // TextBoxRadialHeight
            // 
            this.TextBoxRadialHeight.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRadialHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRadialHeight.Location = new System.Drawing.Point(636, 751);
            this.TextBoxRadialHeight.Name = "TextBoxRadialHeight";
            this.TextBoxRadialHeight.ReadOnly = true;
            this.TextBoxRadialHeight.Size = new System.Drawing.Size(112, 22);
            this.TextBoxRadialHeight.TabIndex = 29;
            this.TextBoxRadialHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 753);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(361, 722);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "mm";
            // 
            // TextBoxRadialYCoord
            // 
            this.TextBoxRadialYCoord.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRadialYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRadialYCoord.Location = new System.Drawing.Point(508, 751);
            this.TextBoxRadialYCoord.Name = "TextBoxRadialYCoord";
            this.TextBoxRadialYCoord.ReadOnly = true;
            this.TextBoxRadialYCoord.Size = new System.Drawing.Size(76, 22);
            this.TextBoxRadialYCoord.TabIndex = 26;
            this.TextBoxRadialYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelRadialYCoord
            // 
            this.LabelRadialYCoord.AutoSize = true;
            this.LabelRadialYCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRadialYCoord.Location = new System.Drawing.Point(492, 753);
            this.LabelRadialYCoord.Name = "LabelRadialYCoord";
            this.LabelRadialYCoord.Size = new System.Drawing.Size(18, 16);
            this.LabelRadialYCoord.TabIndex = 25;
            this.LabelRadialYCoord.Text = "y:";
            // 
            // LabelRadialXCoord
            // 
            this.LabelRadialXCoord.AutoSize = true;
            this.LabelRadialXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRadialXCoord.Location = new System.Drawing.Point(397, 753);
            this.LabelRadialXCoord.Name = "LabelRadialXCoord";
            this.LabelRadialXCoord.Size = new System.Drawing.Size(17, 16);
            this.LabelRadialXCoord.TabIndex = 23;
            this.LabelRadialXCoord.Text = "x:";
            // 
            // TextBoxRadialXCoord
            // 
            this.TextBoxRadialXCoord.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxRadialXCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRadialXCoord.Location = new System.Drawing.Point(414, 751);
            this.TextBoxRadialXCoord.Name = "TextBoxRadialXCoord";
            this.TextBoxRadialXCoord.ReadOnly = true;
            this.TextBoxRadialXCoord.Size = new System.Drawing.Size(76, 22);
            this.TextBoxRadialXCoord.TabIndex = 24;
            this.TextBoxRadialXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelInnerRadius
            // 
            this.LabelInnerRadius.AutoSize = true;
            this.LabelInnerRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInnerRadius.Location = new System.Drawing.Point(215, 752);
            this.LabelInnerRadius.Name = "LabelInnerRadius";
            this.LabelInnerRadius.Size = new System.Drawing.Size(86, 16);
            this.LabelInnerRadius.TabIndex = 22;
            this.LabelInnerRadius.Text = "Inner Radius:";
            // 
            // LabelOuterRadius
            // 
            this.LabelOuterRadius.AutoSize = true;
            this.LabelOuterRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOuterRadius.Location = new System.Drawing.Point(212, 723);
            this.LabelOuterRadius.Name = "LabelOuterRadius";
            this.LabelOuterRadius.Size = new System.Drawing.Size(89, 16);
            this.LabelOuterRadius.TabIndex = 21;
            this.LabelOuterRadius.Text = "Outer Radius:";
            // 
            // LabelRadialDimension
            // 
            this.LabelRadialDimension.AutoSize = true;
            this.LabelRadialDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRadialDimension.Location = new System.Drawing.Point(45, 782);
            this.LabelRadialDimension.Name = "LabelRadialDimension";
            this.LabelRadialDimension.Size = new System.Drawing.Size(75, 16);
            this.LabelRadialDimension.TabIndex = 20;
            this.LabelRadialDimension.Text = "Dimension:";
            // 
            // LabelPerimeterPoints
            // 
            this.LabelPerimeterPoints.AutoSize = true;
            this.LabelPerimeterPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPerimeterPoints.Location = new System.Drawing.Point(45, 753);
            this.LabelPerimeterPoints.Name = "LabelPerimeterPoints";
            this.LabelPerimeterPoints.Size = new System.Drawing.Size(109, 16);
            this.LabelPerimeterPoints.TabIndex = 19;
            this.LabelPerimeterPoints.Text = "Perimeter Points:";
            // 
            // LabelRings
            // 
            this.LabelRings.AutoSize = true;
            this.LabelRings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRings.Location = new System.Drawing.Point(45, 723);
            this.LabelRings.Name = "LabelRings";
            this.LabelRings.Size = new System.Drawing.Size(46, 16);
            this.LabelRings.TabIndex = 18;
            this.LabelRings.Text = "Rings:";
            // 
            // ButtonLoadRadialData
            // 
            this.ButtonLoadRadialData.Location = new System.Drawing.Point(635, 778);
            this.ButtonLoadRadialData.Name = "ButtonLoadRadialData";
            this.ButtonLoadRadialData.Size = new System.Drawing.Size(113, 23);
            this.ButtonLoadRadialData.TabIndex = 17;
            this.ButtonLoadRadialData.Text = "Load Radial Data";
            this.ButtonLoadRadialData.UseVisualStyleBackColor = true;
            this.ButtonLoadRadialData.Click += new System.EventHandler(this.ButtonLoadRadialData_Click);
            // 
            // ButtonSaveRadialData
            // 
            this.ButtonSaveRadialData.Location = new System.Drawing.Point(516, 778);
            this.ButtonSaveRadialData.Name = "ButtonSaveRadialData";
            this.ButtonSaveRadialData.Size = new System.Drawing.Size(113, 23);
            this.ButtonSaveRadialData.TabIndex = 16;
            this.ButtonSaveRadialData.Text = "Save Radial Data";
            this.ButtonSaveRadialData.UseVisualStyleBackColor = true;
            this.ButtonSaveRadialData.Click += new System.EventHandler(this.ButtonSaveRadialData_Click);
            // 
            // NumericUpDownInnerRadius
            // 
            this.NumericUpDownInnerRadius.Location = new System.Drawing.Point(307, 751);
            this.NumericUpDownInnerRadius.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NumericUpDownInnerRadius.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownInnerRadius.Name = "NumericUpDownInnerRadius";
            this.NumericUpDownInnerRadius.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownInnerRadius.TabIndex = 15;
            this.NumericUpDownInnerRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownInnerRadius.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownInnerRadius.ValueChanged += new System.EventHandler(this.NumericUpDownInnerRadius_ValueChanged);
            // 
            // NumericUpDownOuterRadius
            // 
            this.NumericUpDownOuterRadius.Location = new System.Drawing.Point(307, 722);
            this.NumericUpDownOuterRadius.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumericUpDownOuterRadius.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownOuterRadius.Name = "NumericUpDownOuterRadius";
            this.NumericUpDownOuterRadius.Size = new System.Drawing.Size(48, 20);
            this.NumericUpDownOuterRadius.TabIndex = 14;
            this.NumericUpDownOuterRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownOuterRadius.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            this.NumericUpDownOuterRadius.ValueChanged += new System.EventHandler(this.NumericUpDownOuterRadius_ValueChanged);
            // 
            // ButtonExportGrid
            // 
            this.ButtonExportGrid.Location = new System.Drawing.Point(400, 778);
            this.ButtonExportGrid.Name = "ButtonExportGrid";
            this.ButtonExportGrid.Size = new System.Drawing.Size(110, 23);
            this.ButtonExportGrid.TabIndex = 13;
            this.ButtonExportGrid.Text = "Export Grid File";
            this.ButtonExportGrid.UseVisualStyleBackColor = true;
            this.ButtonExportGrid.Click += new System.EventHandler(this.ButtonExportGrid_Click);
            // 
            // ButtonSet
            // 
            this.ButtonSet.Location = new System.Drawing.Point(592, 720);
            this.ButtonSet.Name = "ButtonSet";
            this.ButtonSet.Size = new System.Drawing.Size(75, 24);
            this.ButtonSet.TabIndex = 12;
            this.ButtonSet.Text = "Set";
            this.ButtonSet.UseVisualStyleBackColor = true;
            this.ButtonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // ButtonInterpolateLine
            // 
            this.ButtonInterpolateLine.Location = new System.Drawing.Point(215, 778);
            this.ButtonInterpolateLine.Name = "ButtonInterpolateLine";
            this.ButtonInterpolateLine.Size = new System.Drawing.Size(176, 23);
            this.ButtonInterpolateLine.TabIndex = 11;
            this.ButtonInterpolateLine.Text = "Interpolate Line";
            this.ButtonInterpolateLine.UseVisualStyleBackColor = true;
            this.ButtonInterpolateLine.Click += new System.EventHandler(this.ButtonInterpolateLine_Click);
            // 
            // NumericUpDownDimension
            // 
            this.NumericUpDownDimension.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownDimension.Location = new System.Drawing.Point(126, 781);
            this.NumericUpDownDimension.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.NumericUpDownDimension.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownDimension.Name = "NumericUpDownDimension";
            this.NumericUpDownDimension.Size = new System.Drawing.Size(80, 20);
            this.NumericUpDownDimension.TabIndex = 10;
            this.NumericUpDownDimension.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownDimension.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.NumericUpDownDimension.ValueChanged += new System.EventHandler(this.NumericUpDownDimension_ValueChanged);
            // 
            // ButtonSetAll
            // 
            this.ButtonSetAll.Location = new System.Drawing.Point(673, 720);
            this.ButtonSetAll.Name = "ButtonSetAll";
            this.ButtonSetAll.Size = new System.Drawing.Size(75, 24);
            this.ButtonSetAll.TabIndex = 9;
            this.ButtonSetAll.Text = "Set All";
            this.ButtonSetAll.UseVisualStyleBackColor = true;
            this.ButtonSetAll.Click += new System.EventHandler(this.ButtonSetAll_Click);
            // 
            // TextBoxRadialValue
            // 
            this.TextBoxRadialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRadialValue.Location = new System.Drawing.Point(400, 721);
            this.TextBoxRadialValue.Name = "TextBoxRadialValue";
            this.TextBoxRadialValue.Size = new System.Drawing.Size(186, 22);
            this.TextBoxRadialValue.TabIndex = 3;
            this.TextBoxRadialValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRadialValue_KeyDown);
            // 
            // NumericUpDownPerimeterPoints
            // 
            this.NumericUpDownPerimeterPoints.Location = new System.Drawing.Point(157, 751);
            this.NumericUpDownPerimeterPoints.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.NumericUpDownPerimeterPoints.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownPerimeterPoints.Name = "NumericUpDownPerimeterPoints";
            this.NumericUpDownPerimeterPoints.Size = new System.Drawing.Size(49, 20);
            this.NumericUpDownPerimeterPoints.TabIndex = 2;
            this.NumericUpDownPerimeterPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownPerimeterPoints.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericUpDownPerimeterPoints.ValueChanged += new System.EventHandler(this.NumericUpDownPerimeterPoints_ValueChanged);
            // 
            // NumericUpDownRingCount
            // 
            this.NumericUpDownRingCount.Location = new System.Drawing.Point(97, 722);
            this.NumericUpDownRingCount.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumericUpDownRingCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownRingCount.Name = "NumericUpDownRingCount";
            this.NumericUpDownRingCount.Size = new System.Drawing.Size(109, 20);
            this.NumericUpDownRingCount.TabIndex = 1;
            this.NumericUpDownRingCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumericUpDownRingCount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericUpDownRingCount.ValueChanged += new System.EventHandler(this.NumericUpDownRingCount_ValueChanged);
            // 
            // RadialGenerator1
            // 
            this.RadialGenerator1.Dimension = 21;
            this.RadialGenerator1.InnerRadius = 10;
            this.RadialGenerator1.Location = new System.Drawing.Point(48, 6);
            this.RadialGenerator1.Name = "RadialGenerator1";
            this.RadialGenerator1.OuterRadius = 170;
            this.RadialGenerator1.PerimeterPoints = 12;
            this.RadialGenerator1.Rings = 6;
            this.RadialGenerator1.Size = new System.Drawing.Size(700, 700);
            this.RadialGenerator1.TabIndex = 0;
            this.RadialGenerator1.NodeSelected += new System.EventHandler(this.RadialGenerator1_NodeSelected);
            this.RadialGenerator1.NodeUnselected += new System.EventHandler(this.RadialGenerator1_NodeUnselected);
            this.RadialGenerator1.GridClicked += new _3DPrintGridModifier.GridClickedEventHandler(this.RadialGenerator1_GridClicked);
            // 
            // Form3DPrintGridModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(833, 878);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3DPrintGridModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Print Grid Modifier";
            this.Load += new System.EventHandler(this.Form3DPrintGridModifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownInnerRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownOuterRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDimension)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPerimeterPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRingCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.TextBox TextBoxCellEditor;
        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelRadius;
        private System.Windows.Forms.TextBox TextBoxRadius;
        private System.Windows.Forms.TextBox TextBoxDimension;
        private System.Windows.Forms.Label LabelDimension;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.TextBox TextBoxMultiply;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private RadialGenerator RadialGenerator1;
        private System.Windows.Forms.NumericUpDown NumericUpDownRingCount;
        private System.Windows.Forms.NumericUpDown NumericUpDownPerimeterPoints;
        private System.Windows.Forms.TextBox TextBoxRadialValue;
        private System.Windows.Forms.Button ButtonSetAll;
        private System.Windows.Forms.NumericUpDown NumericUpDownDimension;
        private System.Windows.Forms.Button ButtonInterpolateLine;
        private System.Windows.Forms.Button ButtonSet;
        private System.Windows.Forms.Button ButtonExportGrid;
        private System.Windows.Forms.NumericUpDown NumericUpDownOuterRadius;
        private System.Windows.Forms.NumericUpDown NumericUpDownInnerRadius;
        private System.Windows.Forms.Button ButtonSaveRadialData;
        private System.Windows.Forms.Button ButtonLoadRadialData;
        private System.Windows.Forms.Label LabelInnerRadius;
        private System.Windows.Forms.Label LabelOuterRadius;
        private System.Windows.Forms.Label LabelRadialDimension;
        private System.Windows.Forms.Label LabelPerimeterPoints;
        private System.Windows.Forms.Label LabelRings;
        private System.Windows.Forms.Button ButtonSetGrid;
        private System.Windows.Forms.TextBox TextBoxGridYCoord;
        private System.Windows.Forms.Label LabelGridYCoord;
        private System.Windows.Forms.Label LabelGridXCoord;
        private System.Windows.Forms.TextBox TextBoxGridXCoord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxRadialYCoord;
        private System.Windows.Forms.Label LabelRadialYCoord;
        private System.Windows.Forms.Label LabelRadialXCoord;
        private System.Windows.Forms.TextBox TextBoxRadialXCoord;
        private System.Windows.Forms.Label LabelRadialHeight;
        private System.Windows.Forms.TextBox TextBoxRadialHeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextBoxAdd;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

