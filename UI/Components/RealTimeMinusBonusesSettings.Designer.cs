namespace LiveSplit.UI.Components
{
    partial class RealTimeMinusBonusesSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "10",
            "300"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "20",
            "200"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "30",
            "100"}, -1);
            this.tableLayoutSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupTimeInput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.s_InputMethodIGT = new System.Windows.Forms.RadioButton();
            this.s_InputMethodPoints = new System.Windows.Forms.RadioButton();
            this.groupCountdownSpeed = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s_PointsPerFrame = new System.Windows.Forms.NumericUpDown();
            this.s_fpsNTSCHalf = new System.Windows.Forms.RadioButton();
            this.s_fpsNTSCFull = new System.Windows.Forms.RadioButton();
            this.s_fpsPALHalf = new System.Windows.Forms.RadioButton();
            this.s_fpsPALFull = new System.Windows.Forms.RadioButton();
            this.s_fpsCustom = new System.Windows.Forms.RadioButton();
            this.s_fpsPC = new System.Windows.Forms.RadioButton();
            this.s_fpsGenSMS = new System.Windows.Forms.RadioButton();
            this.s_fpsCustomValue = new System.Windows.Forms.NumericUpDown();
            this.groupIGTLookup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.IGTRemoveRows = new System.Windows.Forms.Button();
            this.s_LookupTable = new System.Windows.Forms.ListView();
            this.maxIGT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearIGTTable = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lookupAddButton = new System.Windows.Forms.Button();
            this.lookupAddPoints = new System.Windows.Forms.TextBox();
            this.lookupAddMaxIGT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkReadme = new System.Windows.Forms.LinkLabel();
            this.groupPointsEntry = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.s_PointsMultiplicationFactor = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutSettings.SuspendLayout();
            this.groupTimeInput.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupCountdownSpeed.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_PointsPerFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_fpsCustomValue)).BeginInit();
            this.groupIGTLookup.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupPointsEntry.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_PointsMultiplicationFactor)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutSettings
            // 
            this.tableLayoutSettings.ColumnCount = 1;
            this.tableLayoutSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutSettings.Controls.Add(this.groupTimeInput, 0, 0);
            this.tableLayoutSettings.Controls.Add(this.groupCountdownSpeed, 0, 1);
            this.tableLayoutSettings.Controls.Add(this.groupIGTLookup, 0, 3);
            this.tableLayoutSettings.Controls.Add(this.label4, 0, 4);
            this.tableLayoutSettings.Controls.Add(this.linkReadme, 0, 5);
            this.tableLayoutSettings.Controls.Add(this.groupPointsEntry, 0, 2);
            this.tableLayoutSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutSettings.Name = "tableLayoutSettings";
            this.tableLayoutSettings.RowCount = 6;
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutSettings.Size = new System.Drawing.Size(605, 552);
            this.tableLayoutSettings.TabIndex = 0;
            // 
            // groupTimeInput
            // 
            this.groupTimeInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTimeInput.Controls.Add(this.tableLayoutPanel2);
            this.groupTimeInput.Location = new System.Drawing.Point(3, 3);
            this.groupTimeInput.Name = "groupTimeInput";
            this.groupTimeInput.Size = new System.Drawing.Size(599, 55);
            this.groupTimeInput.TabIndex = 100;
            this.groupTimeInput.TabStop = false;
            this.groupTimeInput.Text = "Input Method";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.s_InputMethodIGT, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.s_InputMethodPoints, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(587, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // s_InputMethodIGT
            // 
            this.s_InputMethodIGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_InputMethodIGT.AutoSize = true;
            this.s_InputMethodIGT.Location = new System.Drawing.Point(3, 3);
            this.s_InputMethodIGT.Name = "s_InputMethodIGT";
            this.s_InputMethodIGT.Size = new System.Drawing.Size(287, 21);
            this.s_InputMethodIGT.TabIndex = 101;
            this.s_InputMethodIGT.TabStop = true;
            this.s_InputMethodIGT.Text = "Enter IGT (auto-lookup points bonus)";
            this.s_InputMethodIGT.UseVisualStyleBackColor = true;
            this.s_InputMethodIGT.CheckedChanged += new System.EventHandler(this.TimeInputIGT_CheckedChanged);
            // 
            // s_InputMethodPoints
            // 
            this.s_InputMethodPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_InputMethodPoints.AutoSize = true;
            this.s_InputMethodPoints.Location = new System.Drawing.Point(296, 3);
            this.s_InputMethodPoints.Name = "s_InputMethodPoints";
            this.s_InputMethodPoints.Size = new System.Drawing.Size(288, 21);
            this.s_InputMethodPoints.TabIndex = 102;
            this.s_InputMethodPoints.TabStop = true;
            this.s_InputMethodPoints.Text = "Enter points bonus directly";
            this.s_InputMethodPoints.UseVisualStyleBackColor = true;
            // 
            // groupCountdownSpeed
            // 
            this.groupCountdownSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCountdownSpeed.Controls.Add(this.tableLayoutPanel3);
            this.groupCountdownSpeed.Location = new System.Drawing.Point(3, 64);
            this.groupCountdownSpeed.Name = "groupCountdownSpeed";
            this.groupCountdownSpeed.Size = new System.Drawing.Size(599, 129);
            this.groupCountdownSpeed.TabIndex = 200;
            this.groupCountdownSpeed.TabStop = false;
            this.groupCountdownSpeed.Text = "Countdown speed";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.s_PointsPerFrame, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsNTSCHalf, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsNTSCFull, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsPALHalf, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsPALFull, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsCustom, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsPC, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsGenSMS, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.s_fpsCustomValue, 5, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(581, 102);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points per frame:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frames per second:";
            // 
            // s_PointsPerFrame
            // 
            this.s_PointsPerFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.s_PointsPerFrame, 4);
            this.s_PointsPerFrame.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.s_PointsPerFrame.Location = new System.Drawing.Point(143, 3);
            this.s_PointsPerFrame.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.s_PointsPerFrame.Name = "s_PointsPerFrame";
            this.s_PointsPerFrame.Size = new System.Drawing.Size(435, 22);
            this.s_PointsPerFrame.TabIndex = 201;
            // 
            // s_fpsNTSCHalf
            // 
            this.s_fpsNTSCHalf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsNTSCHalf.AutoSize = true;
            this.s_fpsNTSCHalf.Location = new System.Drawing.Point(143, 78);
            this.s_fpsNTSCHalf.Name = "s_fpsNTSCHalf";
            this.s_fpsNTSCHalf.Size = new System.Drawing.Size(148, 21);
            this.s_fpsNTSCHalf.TabIndex = 212;
            this.s_fpsNTSCHalf.Text = "29.97 (NTSC/30)";
            this.s_fpsNTSCHalf.UseVisualStyleBackColor = true;
            this.s_fpsNTSCHalf.CheckedChanged += new System.EventHandler(this.s_fpsNTSCHalf_CheckedChanged);
            // 
            // s_fpsNTSCFull
            // 
            this.s_fpsNTSCFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsNTSCFull.AutoSize = true;
            this.s_fpsNTSCFull.Location = new System.Drawing.Point(143, 53);
            this.s_fpsNTSCFull.Name = "s_fpsNTSCFull";
            this.s_fpsNTSCFull.Size = new System.Drawing.Size(148, 19);
            this.s_fpsNTSCFull.TabIndex = 211;
            this.s_fpsNTSCFull.Text = "59.94 (NTSC/60)";
            this.s_fpsNTSCFull.UseVisualStyleBackColor = true;
            this.s_fpsNTSCFull.CheckedChanged += new System.EventHandler(this.s_fpsNTSC_CheckedChanged);
            // 
            // s_fpsPALHalf
            // 
            this.s_fpsPALHalf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsPALHalf.AutoSize = true;
            this.s_fpsPALHalf.Location = new System.Drawing.Point(297, 78);
            this.s_fpsPALHalf.Name = "s_fpsPALHalf";
            this.s_fpsPALHalf.Size = new System.Drawing.Size(105, 21);
            this.s_fpsPALHalf.TabIndex = 214;
            this.s_fpsPALHalf.Text = "25 (PAL/25)";
            this.s_fpsPALHalf.UseVisualStyleBackColor = true;
            this.s_fpsPALHalf.CheckedChanged += new System.EventHandler(this.s_fpsPALHalf_CheckedChanged);
            // 
            // s_fpsPALFull
            // 
            this.s_fpsPALFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsPALFull.AutoSize = true;
            this.s_fpsPALFull.Location = new System.Drawing.Point(297, 53);
            this.s_fpsPALFull.Name = "s_fpsPALFull";
            this.s_fpsPALFull.Size = new System.Drawing.Size(105, 19);
            this.s_fpsPALFull.TabIndex = 213;
            this.s_fpsPALFull.Text = "50 (PAL/50)";
            this.s_fpsPALFull.UseVisualStyleBackColor = true;
            this.s_fpsPALFull.CheckedChanged += new System.EventHandler(this.s_fpsPAL_CheckedChanged);
            // 
            // s_fpsCustom
            // 
            this.s_fpsCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsCustom.AutoSize = true;
            this.s_fpsCustom.Location = new System.Drawing.Point(408, 78);
            this.s_fpsCustom.Name = "s_fpsCustom";
            this.s_fpsCustom.Size = new System.Drawing.Size(80, 21);
            this.s_fpsCustom.TabIndex = 215;
            this.s_fpsCustom.Text = "Custom:";
            this.s_fpsCustom.UseVisualStyleBackColor = true;
            this.s_fpsCustom.CheckedChanged += new System.EventHandler(this.s_fpsCustom_CheckedChanged);
            // 
            // s_fpsPC
            // 
            this.s_fpsPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsPC.AutoSize = true;
            this.s_fpsPC.Location = new System.Drawing.Point(408, 53);
            this.s_fpsPC.Name = "s_fpsPC";
            this.s_fpsPC.Size = new System.Drawing.Size(80, 19);
            this.s_fpsPC.TabIndex = 217;
            this.s_fpsPC.Text = "60 (PC)";
            this.s_fpsPC.UseVisualStyleBackColor = true;
            this.s_fpsPC.CheckedChanged += new System.EventHandler(this.s_fpsPC_CheckedChanged);
            // 
            // s_fpsGenSMS
            // 
            this.s_fpsGenSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsGenSMS.AutoSize = true;
            this.s_fpsGenSMS.Location = new System.Drawing.Point(143, 28);
            this.s_fpsGenSMS.Name = "s_fpsGenSMS";
            this.s_fpsGenSMS.Size = new System.Drawing.Size(148, 19);
            this.s_fpsGenSMS.TabIndex = 218;
            this.s_fpsGenSMS.Text = "59.9228 (SG/SMS)";
            this.s_fpsGenSMS.UseVisualStyleBackColor = true;
            this.s_fpsGenSMS.CheckedChanged += new System.EventHandler(this.s_fpsGenSMS_CheckedChanged);
            // 
            // s_fpsCustomValue
            // 
            this.s_fpsCustomValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_fpsCustomValue.DecimalPlaces = 6;
            this.s_fpsCustomValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.s_fpsCustomValue.Location = new System.Drawing.Point(494, 78);
            this.s_fpsCustomValue.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.s_fpsCustomValue.Name = "s_fpsCustomValue";
            this.s_fpsCustomValue.Size = new System.Drawing.Size(84, 22);
            this.s_fpsCustomValue.TabIndex = 216;
            this.s_fpsCustomValue.ValueChanged += new System.EventHandler(this.s_fpsCustomValue_ValueChanged);
            // 
            // groupIGTLookup
            // 
            this.groupIGTLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupIGTLookup.Controls.Add(this.tableLayoutPanel4);
            this.groupIGTLookup.Location = new System.Drawing.Point(3, 260);
            this.groupIGTLookup.Name = "groupIGTLookup";
            this.groupIGTLookup.Size = new System.Drawing.Size(599, 247);
            this.groupIGTLookup.TabIndex = 300;
            this.groupIGTLookup.TabStop = false;
            this.groupIGTLookup.Text = "IGT Lookup Table (only relevant when \"Enter IGT\" above is selected)";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel4.Controls.Add(this.IGTRemoveRows, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.s_LookupTable, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ClearIGTTable, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 21);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(586, 220);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // IGTRemoveRows
            // 
            this.IGTRemoveRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IGTRemoveRows.Location = new System.Drawing.Point(332, 133);
            this.IGTRemoveRows.Name = "IGTRemoveRows";
            this.IGTRemoveRows.Size = new System.Drawing.Size(120, 50);
            this.IGTRemoveRows.TabIndex = 226;
            this.IGTRemoveRows.Text = "Remove Selected Row(s)";
            this.IGTRemoveRows.UseVisualStyleBackColor = true;
            this.IGTRemoveRows.Click += new System.EventHandler(this.IGTRemoveRows_Click);
            // 
            // s_LookupTable
            // 
            this.s_LookupTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.s_LookupTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maxIGT,
            this.points});
            this.s_LookupTable.FullRowSelect = true;
            this.s_LookupTable.GridLines = true;
            this.s_LookupTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.s_LookupTable.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            this.s_LookupTable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.s_LookupTable.Location = new System.Drawing.Point(3, 3);
            this.s_LookupTable.Name = "s_LookupTable";
            this.tableLayoutPanel4.SetRowSpan(this.s_LookupTable, 2);
            this.s_LookupTable.Size = new System.Drawing.Size(323, 180);
            this.s_LookupTable.TabIndex = 221;
            this.s_LookupTable.UseCompatibleStateImageBehavior = false;
            this.s_LookupTable.View = System.Windows.Forms.View.Details;
            // 
            // maxIGT
            // 
            this.maxIGT.Text = "Maximum IGT (s)";
            this.maxIGT.Width = 128;
            // 
            // points
            // 
            this.points.Text = "Points Bonus";
            this.points.Width = 128;
            // 
            // ClearIGTTable
            // 
            this.ClearIGTTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearIGTTable.AutoSize = true;
            this.ClearIGTTable.Location = new System.Drawing.Point(332, 3);
            this.ClearIGTTable.Name = "ClearIGTTable";
            this.ClearIGTTable.Size = new System.Drawing.Size(120, 27);
            this.ClearIGTTable.TabIndex = 225;
            this.ClearIGTTable.Text = "Clear List...";
            this.ClearIGTTable.UseVisualStyleBackColor = true;
            this.ClearIGTTable.Click += new System.EventHandler(this.ClearIGTTable_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.Controls.Add(this.lookupAddButton, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.lookupAddPoints, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.lookupAddMaxIGT, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(323, 28);
            this.tableLayoutPanel9.TabIndex = 3;
            // 
            // lookupAddButton
            // 
            this.lookupAddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lookupAddButton.Location = new System.Drawing.Point(249, 3);
            this.lookupAddButton.Name = "lookupAddButton";
            this.lookupAddButton.Size = new System.Drawing.Size(70, 22);
            this.lookupAddButton.TabIndex = 224;
            this.lookupAddButton.Text = "Add";
            this.lookupAddButton.UseVisualStyleBackColor = true;
            this.lookupAddButton.Click += new System.EventHandler(this.lookupAddButton_Click);
            // 
            // lookupAddPoints
            // 
            this.lookupAddPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupAddPoints.Location = new System.Drawing.Point(126, 3);
            this.lookupAddPoints.Name = "lookupAddPoints";
            this.lookupAddPoints.Size = new System.Drawing.Size(117, 22);
            this.lookupAddPoints.TabIndex = 223;
            this.lookupAddPoints.Enter += new System.EventHandler(this.lookupAddPoints_Enter);
            this.lookupAddPoints.Leave += new System.EventHandler(this.lookupAddPoints_Leave);
            // 
            // lookupAddMaxIGT
            // 
            this.lookupAddMaxIGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lookupAddMaxIGT.Location = new System.Drawing.Point(3, 3);
            this.lookupAddMaxIGT.Name = "lookupAddMaxIGT";
            this.lookupAddMaxIGT.Size = new System.Drawing.Size(117, 22);
            this.lookupAddMaxIGT.TabIndex = 222;
            this.lookupAddMaxIGT.Enter += new System.EventHandler(this.lookupAddMaxIGT_Enter);
            this.lookupAddMaxIGT.Leave += new System.EventHandler(this.lookupAddMaxIGT_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 510);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "For information on how to use this component, please view the README:";
            // 
            // linkReadme
            // 
            this.linkReadme.AutoSize = true;
            this.linkReadme.Location = new System.Drawing.Point(3, 530);
            this.linkReadme.Name = "linkReadme";
            this.linkReadme.Size = new System.Drawing.Size(549, 17);
            this.linkReadme.TabIndex = 231;
            this.linkReadme.TabStop = true;
            this.linkReadme.Text = "https://github.com/Sophira/LiveSplit.RealTimeMinusBonuses/blob/master/README.md";
            this.linkReadme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkReadme_LinkClicked);
            // 
            // groupPointsEntry
            // 
            this.groupPointsEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPointsEntry.Controls.Add(this.tableLayoutPanel5);
            this.groupPointsEntry.Location = new System.Drawing.Point(3, 199);
            this.groupPointsEntry.Name = "groupPointsEntry";
            this.groupPointsEntry.Size = new System.Drawing.Size(599, 55);
            this.groupPointsEntry.TabIndex = 301;
            this.groupPointsEntry.TabStop = false;
            this.groupPointsEntry.Text = "Points Entry options (only relevant when \"Enter points bonus directly\" is selecte" +
    "d)";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 408F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.s_PointsMultiplicationFactor, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(9, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(590, 30);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Multiply entered values by:";
            // 
            // s_PointsMultiplicationFactor
            // 
            this.s_PointsMultiplicationFactor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.s_PointsMultiplicationFactor.Location = new System.Drawing.Point(185, 4);
            this.s_PointsMultiplicationFactor.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.s_PointsMultiplicationFactor.Name = "s_PointsMultiplicationFactor";
            this.s_PointsMultiplicationFactor.Size = new System.Drawing.Size(402, 22);
            this.s_PointsMultiplicationFactor.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutSettings, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(611, 559);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // RealTimeMinusBonusesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RealTimeMinusBonusesSettings";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(635, 579);
            this.Load += new System.EventHandler(this.RealTimeMinusBonusesSettings_Load);
            this.tableLayoutSettings.ResumeLayout(false);
            this.tableLayoutSettings.PerformLayout();
            this.groupTimeInput.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupCountdownSpeed.ResumeLayout(false);
            this.groupCountdownSpeed.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_PointsPerFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_fpsCustomValue)).EndInit();
            this.groupIGTLookup.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupPointsEntry.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_PointsMultiplicationFactor)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutSettings;
        private System.Windows.Forms.GroupBox groupTimeInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton s_InputMethodIGT;
        private System.Windows.Forms.RadioButton s_InputMethodPoints;
        private System.Windows.Forms.GroupBox groupCountdownSpeed;
        private System.Windows.Forms.Button ClearIGTTable;
        private System.Windows.Forms.Button IGTRemoveRows;
        private System.Windows.Forms.TextBox lookupAddPoints;
        private System.Windows.Forms.TextBox lookupAddMaxIGT;
        private System.Windows.Forms.Button lookupAddButton;
        private System.Windows.Forms.ListView s_LookupTable;
        private System.Windows.Forms.ColumnHeader maxIGT;
        private System.Windows.Forms.ColumnHeader points;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton s_fpsNTSCFull;
        private System.Windows.Forms.RadioButton s_fpsPALFull;
        private System.Windows.Forms.RadioButton s_fpsCustom;
        private System.Windows.Forms.GroupBox groupIGTLookup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkReadme;
        private System.Windows.Forms.NumericUpDown s_PointsPerFrame;
        private System.Windows.Forms.NumericUpDown s_fpsCustomValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton s_fpsNTSCHalf;
        private System.Windows.Forms.RadioButton s_fpsPALHalf;
        private System.Windows.Forms.RadioButton s_fpsPC;
        private System.Windows.Forms.GroupBox groupPointsEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown s_PointsMultiplicationFactor;
        private System.Windows.Forms.RadioButton s_fpsGenSMS;
    }
}
