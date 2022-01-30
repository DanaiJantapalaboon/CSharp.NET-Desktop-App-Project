
namespace MSFS2020_Pilot_Logbook
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNEWPILOT = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportxlsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCHGPHOTO = new System.Windows.Forms.Button();
            this.lblPilotName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeptPlace = new System.Windows.Forms.TextBox();
            this.cbbPlane = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAppend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fltDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ArrTime = new System.Windows.Forms.DateTimePicker();
            this.txtArrPlace = new System.Windows.Forms.TextBox();
            this.deptTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLDGNight = new System.Windows.Forms.TextBox();
            this.txtTONight = new System.Windows.Forms.TextBox();
            this.txtLDGDay = new System.Windows.Forms.TextBox();
            this.txtFltNo = new System.Windows.Forms.TextBox();
            this.txtTODay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotFltTime = new System.Windows.Forms.Label();
            this.lblSumTODay = new System.Windows.Forms.Label();
            this.lblSumLDGDay = new System.Windows.Forms.Label();
            this.lblSumTONight = new System.Windows.Forms.Label();
            this.lblSumLDGNight = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbPilot = new System.Windows.Forms.ComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lbltotFlight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSumDistance = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1323, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNEWPILOT,
            this.newPlaneToolStripMenuItem,
            this.exportxlsxToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNEWPILOT
            // 
            this.menuNEWPILOT.Name = "menuNEWPILOT";
            this.menuNEWPILOT.Size = new System.Drawing.Size(215, 26);
            this.menuNEWPILOT.Text = "New/Delete Pilot...";
            // 
            // newPlaneToolStripMenuItem
            // 
            this.newPlaneToolStripMenuItem.Name = "newPlaneToolStripMenuItem";
            this.newPlaneToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.newPlaneToolStripMenuItem.Text = "New Plane...";
            // 
            // exportxlsxToolStripMenuItem
            // 
            this.exportxlsxToolStripMenuItem.Name = "exportxlsxToolStripMenuItem";
            this.exportxlsxToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.exportxlsxToolStripMenuItem.Text = "Export (.xlsx)";
            this.exportxlsxToolStripMenuItem.Click += new System.EventHandler(this.exportxlsxToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(21, 357);
            this.gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersWidth = 51;
            this.gridView.RowTemplate.Height = 24;
            this.gridView.Size = new System.Drawing.Size(1279, 320);
            this.gridView.TabIndex = 2;
            this.gridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridView_MouseClick);
            // 
            // btnCHGPHOTO
            // 
            this.btnCHGPHOTO.Location = new System.Drawing.Point(520, 222);
            this.btnCHGPHOTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCHGPHOTO.Name = "btnCHGPHOTO";
            this.btnCHGPHOTO.Size = new System.Drawing.Size(137, 42);
            this.btnCHGPHOTO.TabIndex = 5;
            this.btnCHGPHOTO.Text = "Change Photo";
            this.btnCHGPHOTO.UseVisualStyleBackColor = true;
            // 
            // lblPilotName
            // 
            this.lblPilotName.AutoSize = true;
            this.lblPilotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPilotName.Location = new System.Drawing.Point(19, 48);
            this.lblPilotName.Name = "lblPilotName";
            this.lblPilotName.Size = new System.Drawing.Size(205, 25);
            this.lblPilotName.TabIndex = 9;
            this.lblPilotName.Text = "Pilot Name Logbook";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "DEPARTURE";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(179, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "TIME";
            // 
            // txtDeptPlace
            // 
            this.txtDeptPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtDeptPlace.Location = new System.Drawing.Point(275, 132);
            this.txtDeptPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeptPlace.Name = "txtDeptPlace";
            this.txtDeptPlace.Size = new System.Drawing.Size(183, 27);
            this.txtDeptPlace.TabIndex = 1;
            // 
            // cbbPlane
            // 
            this.cbbPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbPlane.FormattingEnabled = true;
            this.cbbPlane.Location = new System.Drawing.Point(117, 52);
            this.cbbPlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPlane.Name = "cbbPlane";
            this.cbbPlane.Size = new System.Drawing.Size(340, 28);
            this.cbbPlane.TabIndex = 8;
            this.cbbPlane.Text = "Select Plane...";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATE";
            // 
            // btnAppend
            // 
            this.btnAppend.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAppend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAppend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAppend.Location = new System.Drawing.Point(763, 129);
            this.btnAppend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(203, 98);
            this.btnAppend.TabIndex = 6;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = false;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "PLANE";
            // 
            // fltDate
            // 
            this.fltDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fltDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.fltDate.Location = new System.Drawing.Point(117, 16);
            this.fltDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fltDate.Name = "fltDate";
            this.fltDate.Size = new System.Drawing.Size(340, 27);
            this.fltDate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.cbbType);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAppend);
            this.panel1.Controls.Add(this.ArrTime);
            this.panel1.Controls.Add(this.txtArrPlace);
            this.panel1.Controls.Add(this.fltDate);
            this.panel1.Controls.Add(this.deptTime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLDGNight);
            this.panel1.Controls.Add(this.txtTONight);
            this.panel1.Controls.Add(this.txtLDGDay);
            this.panel1.Controls.Add(this.txtFltNo);
            this.panel1.Controls.Add(this.txtTODay);
            this.panel1.Controls.Add(this.txtDeptPlace);
            this.panel1.Controls.Add(this.cbbPlane);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(317, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 245);
            this.panel1.TabIndex = 9;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "GA",
            "Mission",
            "Commercial"});
            this.cbbType.Location = new System.Drawing.Point(623, 52);
            this.cbbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(120, 28);
            this.cbbType.TabIndex = 9;
            this.cbbType.Text = "GA";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(763, 15);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 98);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ArrTime
            // 
            this.ArrTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ArrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArrTime.Location = new System.Drawing.Point(275, 169);
            this.ArrTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArrTime.Name = "ArrTime";
            this.ArrTime.Size = new System.Drawing.Size(183, 27);
            this.ArrTime.TabIndex = 7;
            // 
            // txtArrPlace
            // 
            this.txtArrPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtArrPlace.Location = new System.Drawing.Point(275, 199);
            this.txtArrPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArrPlace.Name = "txtArrPlace";
            this.txtArrPlace.Size = new System.Drawing.Size(183, 27);
            this.txtArrPlace.TabIndex = 1;
            // 
            // deptTime
            // 
            this.deptTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.deptTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.deptTime.Location = new System.Drawing.Point(275, 101);
            this.deptTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deptTime.Name = "deptTime";
            this.deptTime.Size = new System.Drawing.Size(183, 27);
            this.deptTime.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(9, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "ARRIVAL";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(600, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "NIGHT";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(600, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "NIGHT";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(600, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "DAY";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(600, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "DAY";
            // 
            // txtLDGNight
            // 
            this.txtLDGNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLDGNight.Location = new System.Drawing.Point(683, 199);
            this.txtLDGNight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLDGNight.Name = "txtLDGNight";
            this.txtLDGNight.Size = new System.Drawing.Size(60, 27);
            this.txtLDGNight.TabIndex = 1;
            this.txtLDGNight.Text = "0";
            // 
            // txtTONight
            // 
            this.txtTONight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTONight.Location = new System.Drawing.Point(683, 132);
            this.txtTONight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTONight.Name = "txtTONight";
            this.txtTONight.Size = new System.Drawing.Size(60, 27);
            this.txtTONight.TabIndex = 1;
            this.txtTONight.Text = "0";
            // 
            // txtLDGDay
            // 
            this.txtLDGDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtLDGDay.Location = new System.Drawing.Point(683, 169);
            this.txtLDGDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLDGDay.Name = "txtLDGDay";
            this.txtLDGDay.Size = new System.Drawing.Size(60, 27);
            this.txtLDGDay.TabIndex = 1;
            this.txtLDGDay.Text = "0";
            // 
            // txtFltNo
            // 
            this.txtFltNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtFltNo.Location = new System.Drawing.Point(623, 16);
            this.txtFltNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFltNo.Name = "txtFltNo";
            this.txtFltNo.Size = new System.Drawing.Size(120, 27);
            this.txtFltNo.TabIndex = 1;
            this.txtFltNo.Text = "0";
            // 
            // txtTODay
            // 
            this.txtTODay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtTODay.Location = new System.Drawing.Point(683, 101);
            this.txtTODay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTODay.Name = "txtTODay";
            this.txtTODay.Size = new System.Drawing.Size(60, 27);
            this.txtTODay.TabIndex = 1;
            this.txtTODay.Text = "0";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(179, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "TIME";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(467, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 27);
            this.label15.TabIndex = 0;
            this.label15.Text = "LANDINGS";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(179, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "PLACE";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(467, 54);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(151, 27);
            this.label25.TabIndex = 0;
            this.label25.Text = "TYPE";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(467, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 27);
            this.label17.TabIndex = 0;
            this.label17.Text = "FLIGHT NO.";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(467, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "TAKEOFFS";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(179, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "PLACE";
            // 
            // lblTotFltTime
            // 
            this.lblTotFltTime.AutoSize = true;
            this.lblTotFltTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotFltTime.Location = new System.Drawing.Point(20, 335);
            this.lblTotFltTime.Name = "lblTotFltTime";
            this.lblTotFltTime.Size = new System.Drawing.Size(134, 20);
            this.lblTotFltTime.TabIndex = 12;
            this.lblTotFltTime.Text = "Total Flight Time";
            // 
            // lblSumTODay
            // 
            this.lblSumTODay.AutoSize = true;
            this.lblSumTODay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumTODay.Location = new System.Drawing.Point(480, 335);
            this.lblSumTODay.Name = "lblSumTODay";
            this.lblSumTODay.Size = new System.Drawing.Size(126, 20);
            this.lblSumTODay.TabIndex = 12;
            this.lblSumTODay.Text = "Takeoffs DAY 0";
            // 
            // lblSumLDGDay
            // 
            this.lblSumLDGDay.AutoSize = true;
            this.lblSumLDGDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumLDGDay.Location = new System.Drawing.Point(669, 335);
            this.lblSumLDGDay.Name = "lblSumLDGDay";
            this.lblSumLDGDay.Size = new System.Drawing.Size(130, 20);
            this.lblSumLDGDay.TabIndex = 12;
            this.lblSumLDGDay.Text = "Landings DAY 0";
            // 
            // lblSumTONight
            // 
            this.lblSumTONight.AutoSize = true;
            this.lblSumTONight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumTONight.Location = new System.Drawing.Point(861, 335);
            this.lblSumTONight.Name = "lblSumTONight";
            this.lblSumTONight.Size = new System.Drawing.Size(144, 20);
            this.lblSumTONight.TabIndex = 12;
            this.lblSumTONight.Text = "Takeoffs NIGHT 0";
            // 
            // lblSumLDGNight
            // 
            this.lblSumLDGNight.AutoSize = true;
            this.lblSumLDGNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumLDGNight.Location = new System.Drawing.Point(1063, 335);
            this.lblSumLDGNight.Name = "lblSumLDGNight";
            this.lblSumLDGNight.Size = new System.Drawing.Size(148, 20);
            this.lblSumLDGNight.TabIndex = 12;
            this.lblSumLDGNight.Text = "Landings NIGHT 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MSFS2020_Pilot_Logbook.Properties.Resources.msf_logo;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::MSFS2020_Pilot_Logbook.Properties.Resources.avatar_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(21, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.SystemColors.Control;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(326, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 27);
            this.label26.TabIndex = 0;
            this.label26.Text = "NOTES";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNotes.Location = new System.Drawing.Point(434, 45);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(340, 27);
            this.txtNotes.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtid.Location = new System.Drawing.Point(940, 46);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(54, 27);
            this.txtid.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(19, 690);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECT PILOTS";
            // 
            // cbbPilot
            // 
            this.cbbPilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbbPilot.FormattingEnabled = true;
            this.cbbPilot.Location = new System.Drawing.Point(220, 689);
            this.cbbPilot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbPilot.Name = "cbbPilot";
            this.cbbPilot.Size = new System.Drawing.Size(244, 28);
            this.cbbPilot.TabIndex = 8;
            this.cbbPilot.Text = "Select Pilot...";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDOB.Location = new System.Drawing.Point(477, 694);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(115, 20);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAge.Location = new System.Drawing.Point(749, 694);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 20);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGender.Location = new System.Drawing.Point(871, 694);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(74, 20);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender :";
            // 
            // lbltotFlight
            // 
            this.lbltotFlight.AutoSize = true;
            this.lbltotFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbltotFlight.Location = new System.Drawing.Point(313, 335);
            this.lbltotFlight.Name = "lbltotFlight";
            this.lbltotFlight.Size = new System.Drawing.Size(106, 20);
            this.lbltotFlight.TabIndex = 12;
            this.lbltotFlight.Text = "Total Flight 0";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(780, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID SEARCH";
            // 
            // lblSumDistance
            // 
            this.lblSumDistance.AutoSize = true;
            this.lblSumDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblSumDistance.Location = new System.Drawing.Point(1070, 694);
            this.lblSumDistance.Name = "lblSumDistance";
            this.lblSumDistance.Size = new System.Drawing.Size(118, 20);
            this.lblSumDistance.TabIndex = 15;
            this.lblSumDistance.Text = "Distance 0 nm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1323, 726);
            this.Controls.Add(this.lblSumDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSumLDGNight);
            this.Controls.Add(this.lblSumLDGDay);
            this.Controls.Add(this.lblSumTONight);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lbltotFlight);
            this.Controls.Add(this.lblSumTODay);
            this.Controls.Add(this.lblTotFltTime);
            this.Controls.Add(this.lblPilotName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCHGPHOTO);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cbbPilot);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1341, 773);
            this.MinimumSize = new System.Drawing.Size(1341, 773);
            this.Name = "Form1";
            this.Text = "MSFS2020 Pilot Logbook v1.00";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCHGPHOTO;
        private System.Windows.Forms.ToolStripMenuItem menuNEWPILOT;
        private System.Windows.Forms.Label lblPilotName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeptPlace;
        private System.Windows.Forms.ComboBox cbbPlane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fltDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker deptTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker ArrTime;
        private System.Windows.Forms.TextBox txtArrPlace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTONight;
        private System.Windows.Forms.TextBox txtTODay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLDGNight;
        private System.Windows.Forms.TextBox txtLDGDay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTotFltTime;
        private System.Windows.Forms.Label lblSumTODay;
        private System.Windows.Forms.Label lblSumLDGDay;
        private System.Windows.Forms.Label lblSumTONight;
        private System.Windows.Forms.Label lblSumLDGNight;
        private System.Windows.Forms.TextBox txtFltNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolStripMenuItem exportxlsxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaneToolStripMenuItem;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbPilot;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lbltotFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSumDistance;
    }
}

