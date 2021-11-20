namespace AgIO
{
    partial class FormNtrip
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
            this.tboxCasterIP = new System.Windows.Forms.TextBox();
            this.nudCasterPort = new System.Windows.Forms.NumericUpDown();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIP2 = new System.Windows.Forms.Label();
            this.labelBroadcaster = new System.Windows.Forms.Label();
            this.tboxHostName = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.tboxThisIP = new System.Windows.Forms.TextBox();
            this.nudSendToUDPPort = new System.Windows.Forms.NumericUpDown();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelUDPPort = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelMount = new System.Windows.Forms.Label();
            this.tboxMount = new System.Windows.Forms.TextBox();
            this.nudGGAInterval = new System.Windows.Forms.NumericUpDown();
            this.labelGGAInterval = new System.Windows.Forms.Label();
            this.tboxEnterURL = new System.Windows.Forms.TextBox();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.labelMFLat = new System.Windows.Forms.Label();
            this.labelMFLon = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.tboxCurrentLat = new System.Windows.Forms.TextBox();
            this.tboxCurrentLon = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentGPS = new System.Windows.Forms.Label();
            this.labelCFLat = new System.Windows.Forms.Label();
            this.labelCFLon = new System.Windows.Forms.Label();
            this.labelManualFix = new System.Windows.Forms.Label();
            this.labelSet0ForSerial = new System.Windows.Forms.Label();
            this.btnGetSourceTable = new System.Windows.Forms.Button();
            this.btnSetManualPosition = new System.Windows.Forms.Button();
            this.cboxGGAManual = new System.Windows.Forms.ComboBox();
            this.label0Off = new System.Windows.Forms.Label();
            this.checkBoxusetcp = new System.Windows.Forms.CheckBox();
            this.btnPassUsername = new System.Windows.Forms.Button();
            this.btnPassPassword = new System.Windows.Forms.Button();
            this.cboxHTTP = new System.Windows.Forms.ComboBox();
            this.labelHTTP = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboxIsNTRIPOn = new System.Windows.Forms.CheckBox();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCasterPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendToUDPPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGGAInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxCasterIP
            // 
            this.tboxCasterIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCasterIP.Location = new System.Drawing.Point(46, 281);
            this.tboxCasterIP.Name = "tboxCasterIP";
            this.tboxCasterIP.ReadOnly = true;
            this.tboxCasterIP.Size = new System.Drawing.Size(157, 33);
            this.tboxCasterIP.TabIndex = 79;
            this.tboxCasterIP.Text = "192.168.188.255";
            this.tboxCasterIP.Validating += new System.ComponentModel.CancelEventHandler(this.tboxCasterIP_Validating);
            // 
            // nudCasterPort
            // 
            this.nudCasterPort.BackColor = System.Drawing.Color.AliceBlue;
            this.nudCasterPort.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCasterPort.Location = new System.Drawing.Point(497, 135);
            this.nudCasterPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudCasterPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCasterPort.Name = "nudCasterPort";
            this.nudCasterPort.Size = new System.Drawing.Size(119, 40);
            this.nudCasterPort.TabIndex = 80;
            this.nudCasterPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCasterPort.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            this.nudCasterPort.Enter += new System.EventHandler(this.NudCasterPort_Enter);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(437, 144);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(57, 25);
            this.labelPort.TabIndex = 81;
            this.labelPort.Text = "Port:";
            // 
            // labelIP2
            // 
            this.labelIP2.AutoSize = true;
            this.labelIP2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP2.Location = new System.Drawing.Point(4, 284);
            this.labelIP2.Name = "labelIP2";
            this.labelIP2.Size = new System.Drawing.Size(39, 25);
            this.labelIP2.TabIndex = 82;
            this.labelIP2.Text = "IP:";
            // 
            // labelBroadcaster
            // 
            this.labelBroadcaster.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBroadcaster.Location = new System.Drawing.Point(5, 113);
            this.labelBroadcaster.Name = "labelBroadcaster";
            this.labelBroadcaster.Size = new System.Drawing.Size(334, 56);
            this.labelBroadcaster.TabIndex = 83;
            this.labelBroadcaster.Text = gStr.gsEnterBroadcasterURLorIP;
            this.labelBroadcaster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxHostName
            // 
            this.tboxHostName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHostName.Location = new System.Drawing.Point(53, 14);
            this.tboxHostName.Name = "tboxHostName";
            this.tboxHostName.ReadOnly = true;
            this.tboxHostName.Size = new System.Drawing.Size(221, 30);
            this.tboxHostName.TabIndex = 86;
            this.tboxHostName.Text = "HostName";
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHost.Location = new System.Drawing.Point(0, 17);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(47, 23);
            this.labelHost.TabIndex = 85;
            this.labelHost.Text = gStr.gsHost;
            // 
            // tboxThisIP
            // 
            this.tboxThisIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxThisIP.Location = new System.Drawing.Point(53, 49);
            this.tboxThisIP.Name = "tboxThisIP";
            this.tboxThisIP.ReadOnly = true;
            this.tboxThisIP.Size = new System.Drawing.Size(221, 30);
            this.tboxThisIP.TabIndex = 73;
            this.tboxThisIP.Text = "192.168.1.255";
            // 
            // nudSendToUDPPort
            // 
            this.nudSendToUDPPort.BackColor = System.Drawing.Color.AliceBlue;
            this.nudSendToUDPPort.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSendToUDPPort.Location = new System.Drawing.Point(450, 104);
            this.nudSendToUDPPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudSendToUDPPort.Name = "nudSendToUDPPort";
            this.nudSendToUDPPort.Size = new System.Drawing.Size(121, 40);
            this.nudSendToUDPPort.TabIndex = 74;
            this.nudSendToUDPPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSendToUDPPort.Value = new decimal(new int[] {
            36666,
            0,
            0,
            0});
            this.nudSendToUDPPort.Enter += new System.EventHandler(this.NudSendToUDPPort_Enter);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.Location = new System.Drawing.Point(20, 48);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(27, 23);
            this.labelIP.TabIndex = 76;
            this.labelIP.Text = "IP";
            // 
            // labelUDPPort
            // 
            this.labelUDPPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUDPPort.Location = new System.Drawing.Point(420, 62);
            this.labelUDPPort.Name = "labelUDPPort";
            this.labelUDPPort.Size = new System.Drawing.Size(180, 31);
            this.labelUDPPort.TabIndex = 99;
            this.labelUDPPort.Text = "To UDP Port";
            this.labelUDPPort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxUserName
            // 
            this.tboxUserName.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUserName.Location = new System.Drawing.Point(400, 263);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.PasswordChar = '*';
            this.tboxUserName.Size = new System.Drawing.Size(252, 33);
            this.tboxUserName.TabIndex = 100;
            this.tboxUserName.Click += new System.EventHandler(this.tboxUserName_Click);
            // 
            // tboxUserPassword
            // 
            this.tboxUserPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxUserPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUserPassword.Location = new System.Drawing.Point(400, 334);
            this.tboxUserPassword.Name = "tboxUserPassword";
            this.tboxUserPassword.PasswordChar = '*';
            this.tboxUserPassword.Size = new System.Drawing.Size(252, 33);
            this.tboxUserPassword.TabIndex = 101;
            this.tboxUserPassword.Click += new System.EventHandler(this.tboxUserPassword_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(404, 235);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(106, 25);
            this.labelUsername.TabIndex = 102;
            this.labelUsername.Text = gStr.gsUsername;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(404, 306);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 25);
            this.labelPassword.TabIndex = 103;
            this.labelPassword.Text = gStr.gsPassword;
            // 
            // labelMount
            // 
            this.labelMount.AutoSize = true;
            this.labelMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMount.Location = new System.Drawing.Point(386, 54);
            this.labelMount.Name = "labelMount";
            this.labelMount.Size = new System.Drawing.Size(70, 25);
            this.labelMount.TabIndex = 105;
            this.labelMount.Text = gStr.gsMount;
            // 
            // tboxMount
            // 
            this.tboxMount.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMount.Location = new System.Drawing.Point(372, 85);
            this.tboxMount.Name = "tboxMount";
            this.tboxMount.Size = new System.Drawing.Size(341, 33);
            this.tboxMount.TabIndex = 104;
            this.tboxMount.Click += new System.EventHandler(this.tboxMount_Click);
            // 
            // nudGGAInterval
            // 
            this.nudGGAInterval.BackColor = System.Drawing.Color.AliceBlue;
            this.nudGGAInterval.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGGAInterval.Location = new System.Drawing.Point(444, 248);
            this.nudGGAInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudGGAInterval.Name = "nudGGAInterval";
            this.nudGGAInterval.Size = new System.Drawing.Size(113, 40);
            this.nudGGAInterval.TabIndex = 106;
            this.nudGGAInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGGAInterval.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudGGAInterval.Enter += new System.EventHandler(this.NudGGAInterval_Enter);
            // 
            // labelGGAInterval
            // 
            this.labelGGAInterval.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGGAInterval.Location = new System.Drawing.Point(410, 208);
            this.labelGGAInterval.Name = "labelGGAInterval";
            this.labelGGAInterval.Size = new System.Drawing.Size(196, 33);
            this.labelGGAInterval.TabIndex = 107;
            this.labelGGAInterval.Text = "GGA Interval (secs)";
            this.labelGGAInterval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tboxEnterURL
            // 
            this.tboxEnterURL.BackColor = System.Drawing.Color.AliceBlue;
            this.tboxEnterURL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEnterURL.Location = new System.Drawing.Point(10, 172);
            this.tboxEnterURL.Name = "tboxEnterURL";
            this.tboxEnterURL.Size = new System.Drawing.Size(341, 33);
            this.tboxEnterURL.TabIndex = 108;
            this.tboxEnterURL.Text = "RTK2Go.com";
            this.tboxEnterURL.Click += new System.EventHandler(this.tboxEnterURL_Click);
            // 
            // btnGetIP
            // 
            this.btnGetIP.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGetIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetIP.Location = new System.Drawing.Point(10, 215);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(157, 40);
            this.btnGetIP.TabIndex = 109;
            this.btnGetIP.Text = global::AgIO.gStr.gsConfirmIP;
            this.btnGetIP.UseVisualStyleBackColor = false;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // labelMFLat
            // 
            this.labelMFLat.AutoSize = true;
            this.labelMFLat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMFLat.Location = new System.Drawing.Point(11, 44);
            this.labelMFLat.Name = "labelMFLat";
            this.labelMFLat.Size = new System.Drawing.Size(42, 23);
            this.labelMFLat.TabIndex = 115;
            this.labelMFLat.Text = "Lat:";
            // 
            // labelMFLon
            // 
            this.labelMFLon.AutoSize = true;
            this.labelMFLon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMFLon.Location = new System.Drawing.Point(6, 99);
            this.labelMFLon.Name = "labelMFLon";
            this.labelMFLon.Size = new System.Drawing.Size(47, 23);
            this.labelMFLon.TabIndex = 116;
            this.labelMFLon.Text = "Lon:";
            // 
            // nudLatitude
            // 
            this.nudLatitude.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLatitude.DecimalPlaces = 7;
            this.nudLatitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLatitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLatitude.Location = new System.Drawing.Point(64, 44);
            this.nudLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitude.Name = "nudLatitude";
            this.nudLatitude.Size = new System.Drawing.Size(224, 33);
            this.nudLatitude.TabIndex = 118;
            this.nudLatitude.Value = new decimal(new int[] {
            881234567,
            0,
            0,
            -2147024896});
            this.nudLatitude.Enter += new System.EventHandler(this.NudLatitude_Enter);
            // 
            // nudLongitude
            // 
            this.nudLongitude.BackColor = System.Drawing.Color.AliceBlue;
            this.nudLongitude.DecimalPlaces = 7;
            this.nudLongitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLongitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLongitude.Location = new System.Drawing.Point(64, 99);
            this.nudLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitude.Name = "nudLongitude";
            this.nudLongitude.Size = new System.Drawing.Size(224, 33);
            this.nudLongitude.TabIndex = 117;
            this.nudLongitude.Value = new decimal(new int[] {
            1781234567,
            0,
            0,
            -2147024896});
            this.nudLongitude.Enter += new System.EventHandler(this.NudLongitude_Enter);
            // 
            // tboxCurrentLat
            // 
            this.tboxCurrentLat.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCurrentLat.Location = new System.Drawing.Point(64, 244);
            this.tboxCurrentLat.Name = "tboxCurrentLat";
            this.tboxCurrentLat.ReadOnly = true;
            this.tboxCurrentLat.Size = new System.Drawing.Size(224, 33);
            this.tboxCurrentLat.TabIndex = 119;
            this.tboxCurrentLat.Text = "53.2398652";
            // 
            // tboxCurrentLon
            // 
            this.tboxCurrentLon.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCurrentLon.Location = new System.Drawing.Point(63, 290);
            this.tboxCurrentLon.Name = "tboxCurrentLon";
            this.tboxCurrentLon.ReadOnly = true;
            this.tboxCurrentLon.Size = new System.Drawing.Size(225, 33);
            this.tboxCurrentLon.TabIndex = 120;
            this.tboxCurrentLon.Text = "-111.1234567";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCurrentGPS
            // 
            this.labelCurrentGPS.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentGPS.Location = new System.Drawing.Point(20, 205);
            this.labelCurrentGPS.Name = "labelCurrentGPS";
            this.labelCurrentGPS.Size = new System.Drawing.Size(319, 32);
            this.labelCurrentGPS.TabIndex = 122;
            this.labelCurrentGPS.Text = gStr.gsCurrentGPSfix +":";
            this.labelCurrentGPS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelCFLat
            // 
            this.labelCFLat.AutoSize = true;
            this.labelCFLat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFLat.Location = new System.Drawing.Point(16, 248);
            this.labelCFLat.Name = "labelCFLat";
            this.labelCFLat.Size = new System.Drawing.Size(42, 23);
            this.labelCFLat.TabIndex = 123;
            this.labelCFLat.Text = "Lat:";
            // 
            // labelCFLon
            // 
            this.labelCFLon.AutoSize = true;
            this.labelCFLon.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCFLon.Location = new System.Drawing.Point(11, 294);
            this.labelCFLon.Name = "labelCFLon";
            this.labelCFLon.Size = new System.Drawing.Size(47, 23);
            this.labelCFLon.TabIndex = 124;
            this.labelCFLon.Text = "Lon:";
            // 
            // labelManualFix
            // 
            this.labelManualFix.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManualFix.Location = new System.Drawing.Point(33, 8);
            this.labelManualFix.Name = "labelManualFix";
            this.labelManualFix.Size = new System.Drawing.Size(269, 30);
            this.labelManualFix.TabIndex = 125;
            this.labelManualFix.Text =gStr.gsManualfix + ":";
            this.labelManualFix.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelSet0ForSerial
            // 
            this.labelSet0ForSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSet0ForSerial.Location = new System.Drawing.Point(421, 147);
            this.labelSet0ForSerial.Name = "labelSet0ForSerial";
            this.labelSet0ForSerial.Size = new System.Drawing.Size(191, 36);
            this.labelSet0ForSerial.TabIndex = 126;
            this.labelSet0ForSerial.Text = gStr.gsSet0Serial;
            this.labelSet0ForSerial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGetSourceTable
            // 
            this.btnGetSourceTable.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGetSourceTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSourceTable.Location = new System.Drawing.Point(434, 7);
            this.btnGetSourceTable.Name = "btnGetSourceTable";
            this.btnGetSourceTable.Size = new System.Drawing.Size(235, 37);
            this.btnGetSourceTable.TabIndex = 127;
            this.btnGetSourceTable.Text = global::AgIO.gStr.gsGetSourceTable;
            this.btnGetSourceTable.UseVisualStyleBackColor = false;
            this.btnGetSourceTable.Click += new System.EventHandler(this.btnGetSourceTable_Click);
            // 
            // btnSetManualPosition
            // 
            this.btnSetManualPosition.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetManualPosition.Location = new System.Drawing.Point(63, 339);
            this.btnSetManualPosition.Name = "btnSetManualPosition";
            this.btnSetManualPosition.Size = new System.Drawing.Size(225, 37);
            this.btnSetManualPosition.TabIndex = 121;
            this.btnSetManualPosition.Text = global::AgIO.gStr.gsSendtoManualFix;
            this.btnSetManualPosition.UseVisualStyleBackColor = true;
            this.btnSetManualPosition.Click += new System.EventHandler(this.btnSetManualPosition_Click);
            // 
            // cboxGGAManual
            // 
            this.cboxGGAManual.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxGGAManual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGGAManual.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGGAManual.FormattingEnabled = true;
            this.cboxGGAManual.Items.AddRange(new object[] {
            global::AgIO.gStr.gsUseManualFix,
            global::AgIO.gStr.gsUseGPSFix});
            this.cboxGGAManual.Location = new System.Drawing.Point(64, 152);
            this.cboxGGAManual.Name = "cboxGGAManual";
            this.cboxGGAManual.Size = new System.Drawing.Size(192, 33);
            this.cboxGGAManual.TabIndex = 128;
            // 
            // label0Off
            // 
            this.label0Off.AutoSize = true;
            this.label0Off.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0Off.Location = new System.Drawing.Point(563, 256);
            this.label0Off.Name = "label0Off";
            this.label0Off.Size = new System.Drawing.Size(81, 25);
            this.label0Off.TabIndex = 131;
            this.label0Off.Text = gStr.gs0Off;
            // 
            // checkBoxusetcp
            // 
            this.checkBoxusetcp.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxusetcp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.checkBoxusetcp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxusetcp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxusetcp.Location = new System.Drawing.Point(46, 333);
            this.checkBoxusetcp.Name = "checkBoxusetcp";
            this.checkBoxusetcp.Size = new System.Drawing.Size(129, 41);
            this.checkBoxusetcp.TabIndex = 132;
            this.checkBoxusetcp.Text = gStr.gsOnlyTCPPort;
            this.checkBoxusetcp.UseVisualStyleBackColor = true;
            // 
            // btnPassUsername
            // 
            this.btnPassUsername.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassUsername.Location = new System.Drawing.Point(658, 260);
            this.btnPassUsername.Name = "btnPassUsername";
            this.btnPassUsername.Size = new System.Drawing.Size(63, 40);
            this.btnPassUsername.TabIndex = 133;
            this.btnPassUsername.Text = "(o)";
            this.btnPassUsername.UseVisualStyleBackColor = true;
            this.btnPassUsername.Click += new System.EventHandler(this.btnPassUsername_Click);
            // 
            // btnPassPassword
            // 
            this.btnPassPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassPassword.Location = new System.Drawing.Point(658, 331);
            this.btnPassPassword.Name = "btnPassPassword";
            this.btnPassPassword.Size = new System.Drawing.Size(63, 40);
            this.btnPassPassword.TabIndex = 134;
            this.btnPassPassword.Text = "(o)";
            this.btnPassPassword.UseVisualStyleBackColor = true;
            this.btnPassPassword.Click += new System.EventHandler(this.btnPassPassword_Click);
            // 
            // cboxHTTP
            // 
            this.cboxHTTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxHTTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHTTP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxHTTP.FormattingEnabled = true;
            this.cboxHTTP.Items.AddRange(new object[] {
            "1.0",
            "1.1"});
            this.cboxHTTP.Location = new System.Drawing.Point(232, 284);
            this.cboxHTTP.Name = "cboxHTTP";
            this.cboxHTTP.Size = new System.Drawing.Size(80, 33);
            this.cboxHTTP.TabIndex = 135;
            // 
            // labelHTTP
            // 
            this.labelHTTP.AutoSize = true;
            this.labelHTTP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHTTP.Location = new System.Drawing.Point(241, 258);
            this.labelHTTP.Name = "labelHTTP";
            this.labelHTTP.Size = new System.Drawing.Size(62, 23);
            this.labelHTTP.TabIndex = 136;
            this.labelHTTP.Text = "HTTP:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 445);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 137;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.tboxUserPassword);
            this.tabPage1.Controls.Add(this.btnGetSourceTable);
            this.tabPage1.Controls.Add(this.labelHTTP);
            this.tabPage1.Controls.Add(this.labelMount);
            this.tabPage1.Controls.Add(this.tboxUserName);
            this.tabPage1.Controls.Add(this.tboxMount);
            this.tabPage1.Controls.Add(this.cboxHTTP);
            this.tabPage1.Controls.Add(this.labelUsername);
            this.tabPage1.Controls.Add(this.checkBoxusetcp);
            this.tabPage1.Controls.Add(this.btnPassPassword);
            this.tabPage1.Controls.Add(this.labelPassword);
            this.tabPage1.Controls.Add(this.btnPassUsername);
            this.tabPage1.Controls.Add(this.btnGetIP);
            this.tabPage1.Controls.Add(this.tboxCasterIP);
            this.tabPage1.Controls.Add(this.tboxEnterURL);
            this.tabPage1.Controls.Add(this.nudCasterPort);
            this.tabPage1.Controls.Add(this.labelPort);
            this.tabPage1.Controls.Add(this.labelBroadcaster);
            this.tabPage1.Controls.Add(this.labelIP2);
            this.tabPage1.Controls.Add(this.labelIP);
            this.tabPage1.Controls.Add(this.tboxThisIP);
            this.tabPage1.Controls.Add(this.labelHost);
            this.tabPage1.Controls.Add(this.tboxHostName);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(733, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::AgIO.gStr.gsSource;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.labelUDPPort);
            this.tabPage2.Controls.Add(this.nudSendToUDPPort);
            this.tabPage2.Controls.Add(this.label0Off);
            this.tabPage2.Controls.Add(this.labelSet0ForSerial);
            this.tabPage2.Controls.Add(this.labelCurrentGPS);
            this.tabPage2.Controls.Add(this.labelGGAInterval);
            this.tabPage2.Controls.Add(this.labelMFLat);
            this.tabPage2.Controls.Add(this.nudGGAInterval);
            this.tabPage2.Controls.Add(this.cboxGGAManual);
            this.tabPage2.Controls.Add(this.labelMFLon);
            this.tabPage2.Controls.Add(this.nudLongitude);
            this.tabPage2.Controls.Add(this.labelManualFix);
            this.tabPage2.Controls.Add(this.nudLatitude);
            this.tabPage2.Controls.Add(this.labelCFLon);
            this.tabPage2.Controls.Add(this.tboxCurrentLat);
            this.tabPage2.Controls.Add(this.labelCFLat);
            this.tabPage2.Controls.Add(this.tboxCurrentLon);
            this.tabPage2.Controls.Add(this.btnSetManualPosition);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(733, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::AgIO.gStr.gsPosition;
            // 
            // cboxIsNTRIPOn
            // 
            this.cboxIsNTRIPOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsNTRIPOn.BackColor = System.Drawing.Color.Salmon;
            this.cboxIsNTRIPOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxIsNTRIPOn.Checked = true;
            this.cboxIsNTRIPOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsNTRIPOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cboxIsNTRIPOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsNTRIPOn.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsNTRIPOn.Location = new System.Drawing.Point(232, 463);
            this.cboxIsNTRIPOn.Name = "cboxIsNTRIPOn";
            this.cboxIsNTRIPOn.Size = new System.Drawing.Size(150, 50);
            this.cboxIsNTRIPOn.TabIndex = 92;
            this.cboxIsNTRIPOn.Text = "NTRIP";
            this.cboxIsNTRIPOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxIsNTRIPOn.UseVisualStyleBackColor = false;
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.FlatAppearance.BorderSize = 0;
            this.btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.Image = global::AgIO.Properties.Resources.Cancel64;
            this.btnSerialCancel.Location = new System.Drawing.Point(460, 455);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(105, 64);
            this.btnSerialCancel.TabIndex = 95;
            this.btnSerialCancel.UseVisualStyleBackColor = true;
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSerialOK.FlatAppearance.BorderSize = 0;
            this.btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::AgIO.Properties.Resources.OK64;
            this.btnSerialOK.Location = new System.Drawing.Point(641, 455);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(105, 64);
            this.btnSerialOK.TabIndex = 94;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // FormNtrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(758, 522);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cboxIsNTRIPOn);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.btnSerialOK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNtrip";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NTRIP Client Settings";
            this.Load += new System.EventHandler(this.FormNtrip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCasterPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSendToUDPPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGGAInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox cboxIsNTRIPOn;
        private System.Windows.Forms.TextBox tboxCasterIP;
        private System.Windows.Forms.NumericUpDown nudCasterPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelIP2;
        private System.Windows.Forms.Label labelBroadcaster;
        private System.Windows.Forms.TextBox tboxHostName;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox tboxThisIP;
        private System.Windows.Forms.NumericUpDown nudSendToUDPPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Label labelUDPPort;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxUserPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelMount;
        private System.Windows.Forms.NumericUpDown nudGGAInterval;
        private System.Windows.Forms.Label labelGGAInterval;
        private System.Windows.Forms.TextBox tboxEnterURL;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.Label labelMFLat;
        private System.Windows.Forms.Label labelMFLon;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.TextBox tboxCurrentLat;
        private System.Windows.Forms.TextBox tboxCurrentLon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCurrentGPS;
        private System.Windows.Forms.Label labelCFLat;
        private System.Windows.Forms.Label labelCFLon;
        private System.Windows.Forms.Label labelManualFix;
        private System.Windows.Forms.Label labelSet0ForSerial;
        private System.Windows.Forms.Button btnGetSourceTable;
        private System.Windows.Forms.Button btnSetManualPosition;
        private System.Windows.Forms.ComboBox cboxGGAManual;
        private System.Windows.Forms.Label label0Off;
        private System.Windows.Forms.CheckBox checkBoxusetcp;
        public System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.Button btnPassUsername;
        private System.Windows.Forms.Button btnPassPassword;
        private System.Windows.Forms.ComboBox cboxHTTP;
        private System.Windows.Forms.Label labelHTTP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}