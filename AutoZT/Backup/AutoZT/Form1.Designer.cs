namespace AutoZT
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
            this.openExcelFile = new System.Windows.Forms.OpenFileDialog();
            this.fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExcelFileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIGS = new System.Windows.Forms.Button();
            this.txtPLCBox = new System.Windows.Forms.TextBox();
            this.labelPLCName = new System.Windows.Forms.Label();
            this.labelChannelName = new System.Windows.Forms.Label();
            this.txtChannelBox = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.siteInfoBox = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSiteNameBox = new System.Windows.Forms.TextBox();
            this.buttonSqlScript = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAObox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSoftwareBox = new System.Windows.Forms.ComboBox();
            this.groupBoxIFIX = new System.Windows.Forms.GroupBox();
            this.buttonIfixScript = new System.Windows.Forms.Button();
            this.buttonIfixDatabase = new System.Windows.Forms.Button();
            this.txtDatabasebox = new System.Windows.Forms.TextBox();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.comboDriverBox = new System.Windows.Forms.ComboBox();
            this.tabConTrolSetup = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.groupBoxSiteName = new System.Windows.Forms.GroupBox();
            this.comboSoftware = new System.Windows.Forms.ComboBox();
            this.txtSiteBox = new System.Windows.Forms.TextBox();
            this.txtAONumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOPC = new System.Windows.Forms.GroupBox();
            this.labelPLCNameOPC = new System.Windows.Forms.Label();
            this.labelCHNameOPC = new System.Windows.Forms.Label();
            this.txtPLCBoxOPC = new System.Windows.Forms.TextBox();
            this.txtChannelBoxOPC = new System.Windows.Forms.TextBox();
            this.buttonOPCFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSiteAssignedBox = new System.Windows.Forms.ComboBox();
            this.typeSoftwareBox = new System.Windows.Forms.GroupBox();
            this.membraneAreaBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioSquareMetres = new System.Windows.Forms.RadioButton();
            this.NoCassPerTrain = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.radioSquareFeet = new System.Windows.Forms.RadioButton();
            this.NoModulesPerCass = new System.Windows.Forms.NumericUpDown();
            this.NoAreaPerModule = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tagDetailsBox = new System.Windows.Forms.GroupBox();
            this.comboTemperatureBox = new System.Windows.Forms.ComboBox();
            this.comboflowrateUnitsBox = new System.Windows.Forms.ComboBox();
            this.fileMenu.SuspendLayout();
            this.siteInfoBox.SuspendLayout();
            this.groupBoxIFIX.SuspendLayout();
            this.tabConTrolSetup.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.groupBoxSiteName.SuspendLayout();
            this.groupBoxOPC.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.typeSoftwareBox.SuspendLayout();
            this.membraneAreaBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoCassPerTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoModulesPerCass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoAreaPerModule)).BeginInit();
            this.tagDetailsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.fileMenu.Size = new System.Drawing.Size(817, 26);
            this.fileMenu.TabIndex = 3;
            this.fileMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExcelFileStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openExcelFileStripMenuItem
            // 
            this.openExcelFileStripMenuItem.Name = "openExcelFileStripMenuItem";
            this.openExcelFileStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openExcelFileStripMenuItem.Text = "Open";
            this.openExcelFileStripMenuItem.Click += new System.EventHandler(this.openExcelFileStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonIGS
            // 
            this.buttonIGS.Enabled = false;
            this.buttonIGS.Location = new System.Drawing.Point(71, 133);
            this.buttonIGS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIGS.Name = "buttonIGS";
            this.buttonIGS.Size = new System.Drawing.Size(228, 37);
            this.buttonIGS.TabIndex = 4;
            this.buttonIGS.Text = "Save IGS File...";
            this.buttonIGS.UseVisualStyleBackColor = true;
            this.buttonIGS.Click += new System.EventHandler(this.buttonIGS_Click);
            // 
            // txtPLCBox
            // 
            this.txtPLCBox.Location = new System.Drawing.Point(12, 158);
            this.txtPLCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPLCBox.Name = "txtPLCBox";
            this.txtPLCBox.Size = new System.Drawing.Size(188, 22);
            this.txtPLCBox.TabIndex = 7;
            // 
            // labelPLCName
            // 
            this.labelPLCName.AutoSize = true;
            this.labelPLCName.Location = new System.Drawing.Point(8, 138);
            this.labelPLCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPLCName.Name = "labelPLCName";
            this.labelPLCName.Size = new System.Drawing.Size(117, 17);
            this.labelPLCName.TabIndex = 2;
            this.labelPLCName.Text = "Driver PLC Name";
            // 
            // labelChannelName
            // 
            this.labelChannelName.AutoSize = true;
            this.labelChannelName.Location = new System.Drawing.Point(8, 50);
            this.labelChannelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChannelName.Name = "labelChannelName";
            this.labelChannelName.Size = new System.Drawing.Size(143, 17);
            this.labelChannelName.TabIndex = 1;
            this.labelChannelName.Text = "Driver Channel Name";
            // 
            // txtChannelBox
            // 
            this.txtChannelBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtChannelBox.Location = new System.Drawing.Point(12, 70);
            this.txtChannelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChannelBox.Name = "txtChannelBox";
            this.txtChannelBox.Size = new System.Drawing.Size(188, 22);
            this.txtChannelBox.TabIndex = 6;
            // 
            // siteInfoBox
            // 
            this.siteInfoBox.BackColor = System.Drawing.SystemColors.Control;
            this.siteInfoBox.Controls.Add(this.label10);
            this.siteInfoBox.Controls.Add(this.txtSiteNameBox);
            this.siteInfoBox.Controls.Add(this.buttonSqlScript);
            this.siteInfoBox.Controls.Add(this.label5);
            this.siteInfoBox.Controls.Add(this.txtAObox);
            this.siteInfoBox.Controls.Add(this.label4);
            this.siteInfoBox.Location = new System.Drawing.Point(8, 194);
            this.siteInfoBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteInfoBox.Name = "siteInfoBox";
            this.siteInfoBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.siteInfoBox.Size = new System.Drawing.Size(368, 308);
            this.siteInfoBox.TabIndex = 4;
            this.siteInfoBox.TabStop = false;
            this.siteInfoBox.Text = "Site Information";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "**Database Name = AO Number + Site Name";
            // 
            // txtSiteNameBox
            // 
            this.txtSiteNameBox.Location = new System.Drawing.Point(65, 151);
            this.txtSiteNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSiteNameBox.Name = "txtSiteNameBox";
            this.txtSiteNameBox.Size = new System.Drawing.Size(211, 22);
            this.txtSiteNameBox.TabIndex = 6;
            // 
            // buttonSqlScript
            // 
            this.buttonSqlScript.Location = new System.Drawing.Point(65, 235);
            this.buttonSqlScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSqlScript.Name = "buttonSqlScript";
            this.buttonSqlScript.Size = new System.Drawing.Size(212, 32);
            this.buttonSqlScript.TabIndex = 16;
            this.buttonSqlScript.Text = "Create SQL Database Script...";
            this.buttonSqlScript.UseVisualStyleBackColor = true;
            this.buttonSqlScript.Click += new System.EventHandler(this.buttonSqlScript_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Site Name (ie NorthLake)";
            // 
            // txtAObox
            // 
            this.txtAObox.Location = new System.Drawing.Point(65, 73);
            this.txtAObox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAObox.Name = "txtAObox";
            this.txtAObox.Size = new System.Drawing.Size(211, 22);
            this.txtAObox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "AO Number (ie 500357)";
            // 
            // comboSoftwareBox
            // 
            this.comboSoftwareBox.FormattingEnabled = true;
            this.comboSoftwareBox.Items.AddRange(new object[] {
            "IFIX",
            "OPC Trend"});
            this.comboSoftwareBox.Location = new System.Drawing.Point(65, 43);
            this.comboSoftwareBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSoftwareBox.Name = "comboSoftwareBox";
            this.comboSoftwareBox.Size = new System.Drawing.Size(211, 24);
            this.comboSoftwareBox.TabIndex = 1;
            this.comboSoftwareBox.Text = "Data Logging Software ...";
            // 
            // groupBoxIFIX
            // 
            this.groupBoxIFIX.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIFIX.Controls.Add(this.txtPLCBox);
            this.groupBoxIFIX.Controls.Add(this.labelPLCName);
            this.groupBoxIFIX.Controls.Add(this.buttonIfixScript);
            this.groupBoxIFIX.Controls.Add(this.labelChannelName);
            this.groupBoxIFIX.Controls.Add(this.txtChannelBox);
            this.groupBoxIFIX.Controls.Add(this.buttonIfixDatabase);
            this.groupBoxIFIX.Controls.Add(this.txtDatabasebox);
            this.groupBoxIFIX.Controls.Add(this.labelDatabaseName);
            this.groupBoxIFIX.Location = new System.Drawing.Point(4, 229);
            this.groupBoxIFIX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxIFIX.Name = "groupBoxIFIX";
            this.groupBoxIFIX.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxIFIX.Size = new System.Drawing.Size(428, 279);
            this.groupBoxIFIX.TabIndex = 6;
            this.groupBoxIFIX.TabStop = false;
            this.groupBoxIFIX.Text = "IFIX Information";
            // 
            // buttonIfixScript
            // 
            this.buttonIfixScript.Location = new System.Drawing.Point(231, 219);
            this.buttonIfixScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIfixScript.Name = "buttonIfixScript";
            this.buttonIfixScript.Size = new System.Drawing.Size(189, 38);
            this.buttonIfixScript.TabIndex = 10;
            this.buttonIfixScript.Text = "Save IFIX Script...";
            this.buttonIfixScript.UseVisualStyleBackColor = true;
            this.buttonIfixScript.Click += new System.EventHandler(this.buttonIfixScript_Click);
            // 
            // buttonIfixDatabase
            // 
            this.buttonIfixDatabase.Enabled = false;
            this.buttonIfixDatabase.Location = new System.Drawing.Point(12, 219);
            this.buttonIfixDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIfixDatabase.Name = "buttonIfixDatabase";
            this.buttonIfixDatabase.Size = new System.Drawing.Size(189, 38);
            this.buttonIfixDatabase.TabIndex = 9;
            this.buttonIfixDatabase.Text = "Save IFIX Database File...";
            this.buttonIfixDatabase.UseVisualStyleBackColor = true;
            this.buttonIfixDatabase.Click += new System.EventHandler(this.buttonIFIX_Click);
            // 
            // txtDatabasebox
            // 
            this.txtDatabasebox.Location = new System.Drawing.Point(231, 158);
            this.txtDatabasebox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatabasebox.Name = "txtDatabasebox";
            this.txtDatabasebox.Size = new System.Drawing.Size(188, 22);
            this.txtDatabasebox.TabIndex = 8;
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.AutoSize = true;
            this.labelDatabaseName.Location = new System.Drawing.Point(227, 138);
            this.labelDatabaseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(110, 17);
            this.labelDatabaseName.TabIndex = 0;
            this.labelDatabaseName.Text = "Database Name";
            // 
            // comboDriverBox
            // 
            this.comboDriverBox.FormattingEnabled = true;
            this.comboDriverBox.Items.AddRange(new object[] {
            "IGS",
            "GE9"});
            this.comboDriverBox.Location = new System.Drawing.Point(71, 62);
            this.comboDriverBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboDriverBox.Name = "comboDriverBox";
            this.comboDriverBox.Size = new System.Drawing.Size(227, 24);
            this.comboDriverBox.TabIndex = 3;
            this.comboDriverBox.Text = "Select the driver used...";
            this.comboDriverBox.SelectionChangeCommitted += new System.EventHandler(this.comboDriverBox_SelectionChangeCommitted);
            // 
            // tabConTrolSetup
            // 
            this.tabConTrolSetup.Controls.Add(this.tabPage1);
            this.tabConTrolSetup.Controls.Add(this.tabPage2);
            this.tabConTrolSetup.Location = new System.Drawing.Point(0, 41);
            this.tabConTrolSetup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConTrolSetup.Name = "tabConTrolSetup";
            this.tabConTrolSetup.SelectedIndex = 0;
            this.tabConTrolSetup.Size = new System.Drawing.Size(817, 544);
            this.tabConTrolSetup.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxDriver);
            this.tabPage1.Controls.Add(this.groupBoxSiteName);
            this.tabPage1.Controls.Add(this.groupBoxOPC);
            this.tabPage1.Controls.Add(this.groupBoxIFIX);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(809, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Blackbox Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.comboDriverBox);
            this.groupBoxDriver.Controls.Add(this.buttonIGS);
            this.groupBoxDriver.Location = new System.Drawing.Point(441, 4);
            this.groupBoxDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDriver.Size = new System.Drawing.Size(360, 218);
            this.groupBoxDriver.TabIndex = 9;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Driver Information";
            // 
            // groupBoxSiteName
            // 
            this.groupBoxSiteName.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSiteName.Controls.Add(this.comboSoftware);
            this.groupBoxSiteName.Controls.Add(this.txtSiteBox);
            this.groupBoxSiteName.Controls.Add(this.txtAONumberBox);
            this.groupBoxSiteName.Controls.Add(this.label2);
            this.groupBoxSiteName.Controls.Add(this.label1);
            this.groupBoxSiteName.Location = new System.Drawing.Point(4, 4);
            this.groupBoxSiteName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSiteName.Name = "groupBoxSiteName";
            this.groupBoxSiteName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSiteName.Size = new System.Drawing.Size(428, 218);
            this.groupBoxSiteName.TabIndex = 8;
            this.groupBoxSiteName.TabStop = false;
            this.groupBoxSiteName.Text = "Site Information";
            // 
            // comboSoftware
            // 
            this.comboSoftware.FormattingEnabled = true;
            this.comboSoftware.Items.AddRange(new object[] {
            "IFIX",
            "OPC Trend"});
            this.comboSoftware.Location = new System.Drawing.Point(81, 161);
            this.comboSoftware.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSoftware.Name = "comboSoftware";
            this.comboSoftware.Size = new System.Drawing.Size(243, 24);
            this.comboSoftware.TabIndex = 2;
            this.comboSoftware.Text = "Select the data logging software...";
            this.comboSoftware.SelectionChangeCommitted += new System.EventHandler(this.comboSoftware_SelectionChangeCommitted);
            // 
            // txtSiteBox
            // 
            this.txtSiteBox.Location = new System.Drawing.Point(81, 108);
            this.txtSiteBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSiteBox.Name = "txtSiteBox";
            this.txtSiteBox.Size = new System.Drawing.Size(243, 22);
            this.txtSiteBox.TabIndex = 1;
            // 
            // txtAONumberBox
            // 
            this.txtAONumberBox.Location = new System.Drawing.Point(81, 52);
            this.txtAONumberBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAONumberBox.Name = "txtAONumberBox";
            this.txtAONumberBox.Size = new System.Drawing.Size(243, 22);
            this.txtAONumberBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site Name (ie NorthLake)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AO Number (ie 500357)";
            // 
            // groupBoxOPC
            // 
            this.groupBoxOPC.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxOPC.Controls.Add(this.labelPLCNameOPC);
            this.groupBoxOPC.Controls.Add(this.labelCHNameOPC);
            this.groupBoxOPC.Controls.Add(this.txtPLCBoxOPC);
            this.groupBoxOPC.Controls.Add(this.txtChannelBoxOPC);
            this.groupBoxOPC.Controls.Add(this.buttonOPCFile);
            this.groupBoxOPC.Location = new System.Drawing.Point(440, 229);
            this.groupBoxOPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOPC.Name = "groupBoxOPC";
            this.groupBoxOPC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOPC.Size = new System.Drawing.Size(363, 279);
            this.groupBoxOPC.TabIndex = 7;
            this.groupBoxOPC.TabStop = false;
            this.groupBoxOPC.Text = "OPC Trend Information";
            // 
            // labelPLCNameOPC
            // 
            this.labelPLCNameOPC.AutoSize = true;
            this.labelPLCNameOPC.Location = new System.Drawing.Point(68, 126);
            this.labelPLCNameOPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPLCNameOPC.Name = "labelPLCNameOPC";
            this.labelPLCNameOPC.Size = new System.Drawing.Size(117, 17);
            this.labelPLCNameOPC.TabIndex = 9;
            this.labelPLCNameOPC.Text = "Driver PLC Name";
            // 
            // labelCHNameOPC
            // 
            this.labelCHNameOPC.AutoSize = true;
            this.labelCHNameOPC.Location = new System.Drawing.Point(68, 50);
            this.labelCHNameOPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCHNameOPC.Name = "labelCHNameOPC";
            this.labelCHNameOPC.Size = new System.Drawing.Size(143, 17);
            this.labelCHNameOPC.TabIndex = 8;
            this.labelCHNameOPC.Text = "Driver Channel Name";
            // 
            // txtPLCBoxOPC
            // 
            this.txtPLCBoxOPC.Location = new System.Drawing.Point(72, 145);
            this.txtPLCBoxOPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPLCBoxOPC.Name = "txtPLCBoxOPC";
            this.txtPLCBoxOPC.Size = new System.Drawing.Size(227, 22);
            this.txtPLCBoxOPC.TabIndex = 7;
            // 
            // txtChannelBoxOPC
            // 
            this.txtChannelBoxOPC.Location = new System.Drawing.Point(72, 70);
            this.txtChannelBoxOPC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChannelBoxOPC.Name = "txtChannelBoxOPC";
            this.txtChannelBoxOPC.Size = new System.Drawing.Size(227, 22);
            this.txtChannelBoxOPC.TabIndex = 6;
            // 
            // buttonOPCFile
            // 
            this.buttonOPCFile.Location = new System.Drawing.Point(72, 219);
            this.buttonOPCFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOPCFile.Name = "buttonOPCFile";
            this.buttonOPCFile.Size = new System.Drawing.Size(228, 38);
            this.buttonOPCFile.TabIndex = 5;
            this.buttonOPCFile.Text = "Save OPC Database File...";
            this.buttonOPCFile.UseVisualStyleBackColor = true;
            this.buttonOPCFile.Click += new System.EventHandler(this.buttonOPCFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.siteInfoBox);
            this.tabPage2.Controls.Add(this.typeSoftwareBox);
            this.tabPage2.Controls.Add(this.membraneAreaBox);
            this.tabPage2.Controls.Add(this.tagDetailsBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(809, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database Setup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboSiteAssignedBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(368, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Site Assignment";
            // 
            // comboSiteAssignedBox
            // 
            this.comboSiteAssignedBox.FormattingEnabled = true;
            this.comboSiteAssignedBox.Items.AddRange(new object[] {
            "Dave",
            "Edison",
            "Saima",
            "Sandeep"});
            this.comboSiteAssignedBox.Location = new System.Drawing.Point(65, 34);
            this.comboSiteAssignedBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboSiteAssignedBox.Name = "comboSiteAssignedBox";
            this.comboSiteAssignedBox.Size = new System.Drawing.Size(211, 24);
            this.comboSiteAssignedBox.TabIndex = 3;
            this.comboSiteAssignedBox.Text = "Site Assigned To...";
            // 
            // typeSoftwareBox
            // 
            this.typeSoftwareBox.Controls.Add(this.comboSoftwareBox);
            this.typeSoftwareBox.Location = new System.Drawing.Point(8, 7);
            this.typeSoftwareBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeSoftwareBox.Name = "typeSoftwareBox";
            this.typeSoftwareBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeSoftwareBox.Size = new System.Drawing.Size(368, 90);
            this.typeSoftwareBox.TabIndex = 0;
            this.typeSoftwareBox.TabStop = false;
            this.typeSoftwareBox.Text = "Type of Software";
            // 
            // membraneAreaBox
            // 
            this.membraneAreaBox.BackColor = System.Drawing.Color.Transparent;
            this.membraneAreaBox.Controls.Add(this.label6);
            this.membraneAreaBox.Controls.Add(this.radioSquareMetres);
            this.membraneAreaBox.Controls.Add(this.NoCassPerTrain);
            this.membraneAreaBox.Controls.Add(this.label7);
            this.membraneAreaBox.Controls.Add(this.radioSquareFeet);
            this.membraneAreaBox.Controls.Add(this.NoModulesPerCass);
            this.membraneAreaBox.Controls.Add(this.NoAreaPerModule);
            this.membraneAreaBox.Controls.Add(this.label8);
            this.membraneAreaBox.Location = new System.Drawing.Point(384, 194);
            this.membraneAreaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.membraneAreaBox.Name = "membraneAreaBox";
            this.membraneAreaBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.membraneAreaBox.Size = new System.Drawing.Size(419, 308);
            this.membraneAreaBox.TabIndex = 10;
            this.membraneAreaBox.TabStop = false;
            this.membraneAreaBox.Text = "Membrane Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cassettes Per Train";
            // 
            // radioSquareMetres
            // 
            this.radioSquareMetres.AutoSize = true;
            this.radioSquareMetres.Location = new System.Drawing.Point(300, 257);
            this.radioSquareMetres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSquareMetres.Name = "radioSquareMetres";
            this.radioSquareMetres.Size = new System.Drawing.Size(119, 21);
            this.radioSquareMetres.TabIndex = 15;
            this.radioSquareMetres.TabStop = true;
            this.radioSquareMetres.Text = "Square Metres";
            this.radioSquareMetres.UseVisualStyleBackColor = true;
            // 
            // NoCassPerTrain
            // 
            this.NoCassPerTrain.Location = new System.Drawing.Point(84, 73);
            this.NoCassPerTrain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoCassPerTrain.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NoCassPerTrain.Name = "NoCassPerTrain";
            this.NoCassPerTrain.Size = new System.Drawing.Size(211, 22);
            this.NoCassPerTrain.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Modules Per Cassette";
            // 
            // radioSquareFeet
            // 
            this.radioSquareFeet.AutoSize = true;
            this.radioSquareFeet.Location = new System.Drawing.Point(300, 215);
            this.radioSquareFeet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSquareFeet.Name = "radioSquareFeet";
            this.radioSquareFeet.Size = new System.Drawing.Size(104, 21);
            this.radioSquareFeet.TabIndex = 14;
            this.radioSquareFeet.TabStop = true;
            this.radioSquareFeet.Text = "Square Feet";
            this.radioSquareFeet.UseVisualStyleBackColor = true;
            // 
            // NoModulesPerCass
            // 
            this.NoModulesPerCass.Location = new System.Drawing.Point(84, 151);
            this.NoModulesPerCass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoModulesPerCass.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NoModulesPerCass.Name = "NoModulesPerCass";
            this.NoModulesPerCass.Size = new System.Drawing.Size(211, 22);
            this.NoModulesPerCass.TabIndex = 12;
            // 
            // NoAreaPerModule
            // 
            this.NoAreaPerModule.DecimalPlaces = 4;
            this.NoAreaPerModule.Location = new System.Drawing.Point(84, 235);
            this.NoAreaPerModule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoAreaPerModule.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NoAreaPerModule.Name = "NoAreaPerModule";
            this.NoAreaPerModule.Size = new System.Drawing.Size(211, 22);
            this.NoAreaPerModule.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Area Per Module";
            // 
            // tagDetailsBox
            // 
            this.tagDetailsBox.BackColor = System.Drawing.SystemColors.Control;
            this.tagDetailsBox.Controls.Add(this.comboTemperatureBox);
            this.tagDetailsBox.Controls.Add(this.comboflowrateUnitsBox);
            this.tagDetailsBox.Location = new System.Drawing.Point(384, 0);
            this.tagDetailsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagDetailsBox.Name = "tagDetailsBox";
            this.tagDetailsBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tagDetailsBox.Size = new System.Drawing.Size(419, 187);
            this.tagDetailsBox.TabIndex = 7;
            this.tagDetailsBox.TabStop = false;
            this.tagDetailsBox.Text = "Train Information";
            // 
            // comboTemperatureBox
            // 
            this.comboTemperatureBox.FormattingEnabled = true;
            this.comboTemperatureBox.Items.AddRange(new object[] {
            "Degree C",
            "Degree F",
            "No Temperature"});
            this.comboTemperatureBox.Location = new System.Drawing.Point(84, 119);
            this.comboTemperatureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTemperatureBox.Name = "comboTemperatureBox";
            this.comboTemperatureBox.Size = new System.Drawing.Size(211, 24);
            this.comboTemperatureBox.TabIndex = 9;
            this.comboTemperatureBox.Text = "Unit of Temperature...";
            // 
            // comboflowrateUnitsBox
            // 
            this.comboflowrateUnitsBox.FormattingEnabled = true;
            this.comboflowrateUnitsBox.Items.AddRange(new object[] {
            "L/s",
            "m3/h",
            "gpm",
            "No FlowRates"});
            this.comboflowrateUnitsBox.Location = new System.Drawing.Point(84, 50);
            this.comboflowrateUnitsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboflowrateUnitsBox.Name = "comboflowrateUnitsBox";
            this.comboflowrateUnitsBox.Size = new System.Drawing.Size(211, 24);
            this.comboflowrateUnitsBox.TabIndex = 8;
            this.comboflowrateUnitsBox.Text = "Unit of FlowRates...";
            this.comboflowrateUnitsBox.SelectionChangeCommitted += new System.EventHandler(this.comboflowrateUnitsBox_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 583);
            this.Controls.Add(this.tabConTrolSetup);
            this.Controls.Add(this.fileMenu);
            this.MainMenuStrip = this.fileMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ZenoTrac Automation Tool";
            this.fileMenu.ResumeLayout(false);
            this.fileMenu.PerformLayout();
            this.siteInfoBox.ResumeLayout(false);
            this.siteInfoBox.PerformLayout();
            this.groupBoxIFIX.ResumeLayout(false);
            this.groupBoxIFIX.PerformLayout();
            this.tabConTrolSetup.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxDriver.ResumeLayout(false);
            this.groupBoxSiteName.ResumeLayout(false);
            this.groupBoxSiteName.PerformLayout();
            this.groupBoxOPC.ResumeLayout(false);
            this.groupBoxOPC.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.typeSoftwareBox.ResumeLayout(false);
            this.membraneAreaBox.ResumeLayout(false);
            this.membraneAreaBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoCassPerTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoModulesPerCass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoAreaPerModule)).EndInit();
            this.tagDetailsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openExcelFile;
        private System.Windows.Forms.MenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExcelFileStripMenuItem;
        private System.Windows.Forms.TextBox txtChannelBox;
        private System.Windows.Forms.Label labelChannelName;
        private System.Windows.Forms.TextBox txtPLCBox;
        private System.Windows.Forms.Label labelPLCName;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.GroupBox siteInfoBox;
        private System.Windows.Forms.GroupBox groupBoxIFIX;
        private System.Windows.Forms.ComboBox comboDriverBox;
        private System.Windows.Forms.TextBox txtDatabasebox;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.TextBox txtSiteNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAObox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonIGS;
        private System.Windows.Forms.Button buttonIfixDatabase;
        private System.Windows.Forms.Button buttonIfixScript;
        private System.Windows.Forms.TabControl tabConTrolSetup;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox tagDetailsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NoCassPerTrain;
        private System.Windows.Forms.NumericUpDown NoModulesPerCass;
        private System.Windows.Forms.NumericUpDown NoAreaPerModule;
        private System.Windows.Forms.RadioButton radioSquareMetres;
        private System.Windows.Forms.RadioButton radioSquareFeet;
        private System.Windows.Forms.GroupBox membraneAreaBox;
        private System.Windows.Forms.ComboBox comboflowrateUnitsBox;
        private System.Windows.Forms.ComboBox comboTemperatureBox;
        private System.Windows.Forms.Button buttonSqlScript;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboSoftwareBox;
        private System.Windows.Forms.GroupBox typeSoftwareBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboSiteAssignedBox;
        private System.Windows.Forms.GroupBox groupBoxOPC;
        private System.Windows.Forms.Button buttonOPCFile;
        private System.Windows.Forms.GroupBox groupBoxSiteName;
        private System.Windows.Forms.ComboBox comboSoftware;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.TextBox txtSiteBox;
        private System.Windows.Forms.TextBox txtAONumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPLCBoxOPC;
        private System.Windows.Forms.TextBox txtChannelBoxOPC;
        private System.Windows.Forms.Label labelPLCNameOPC;
        private System.Windows.Forms.Label labelCHNameOPC;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

