namespace AgIO
{
    partial class FormCommSetGPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommSetGPS));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxGPS = new System.Windows.Forms.GroupBox();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.lblCurrentPort = new System.Windows.Forms.Label();
            this.lblCurrentBaud = new System.Windows.Forms.Label();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.groupBoxGPS2 = new System.Windows.Forms.GroupBox();
            this.cboxPort2 = new System.Windows.Forms.ComboBox();
            this.cboxBaud2 = new System.Windows.Forms.ComboBox();
            this.lblCurrentPort2 = new System.Windows.Forms.Label();
            this.lblCurrentBaud2 = new System.Windows.Forms.Label();
            this.btnCloseSerial2 = new System.Windows.Forms.Button();
            this.textBoxRcv2 = new System.Windows.Forms.TextBox();
            this.btnOpenSerial2 = new System.Windows.Forms.Button();
            this.groupBoxSteer = new System.Windows.Forms.GroupBox();
            this.cboxModule1Port = new System.Windows.Forms.ComboBox();
            this.lblCurrentModule1Port = new System.Windows.Forms.Label();
            this.btnOpenSerialModule1 = new System.Windows.Forms.Button();
            this.btnCloseSerialModule1 = new System.Windows.Forms.Button();
            this.groupBoxMachine = new System.Windows.Forms.GroupBox();
            this.cboxModule2Port = new System.Windows.Forms.ComboBox();
            this.lblCurrentModule2Port = new System.Windows.Forms.Label();
            this.btnOpenSerialModule2 = new System.Windows.Forms.Button();
            this.btnCloseSerialModule2 = new System.Windows.Forms.Button();
            this.groupBoxModule3 = new System.Windows.Forms.GroupBox();
            this.lblCurrentModule3Port = new System.Windows.Forms.Label();
            this.cboxModule3Port = new System.Windows.Forms.ComboBox();
            this.btnOpenSerialModule3 = new System.Windows.Forms.Button();
            this.btnCloseSerialModule3 = new System.Windows.Forms.Button();
            this.groupBoxIMU = new System.Windows.Forms.GroupBox();
            this.lblCurrentIMU = new System.Windows.Forms.Label();
            this.cboxIMU = new System.Windows.Forms.ComboBox();
            this.btnCloseIMU = new System.Windows.Forms.Button();
            this.btnOpenIMU = new System.Windows.Forms.Button();
            this.pictureBoxGPS = new System.Windows.Forms.PictureBox();
            this.pictureBoxMachine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSteer = new System.Windows.Forms.PictureBox();
            this.pictureBoxIMU = new System.Windows.Forms.PictureBox();
            this.btnRescanPorts = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.labelGPS = new System.Windows.Forms.Label();
            this.labelGPS2 = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelSteer = new System.Windows.Forms.Label();
            this.labelIMU = new System.Windows.Forms.Label();
            this.lblIMU = new System.Windows.Forms.Label();
            this.lblSteer = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.lblFromGPS = new System.Windows.Forms.Label();
            this.lblFromMU = new System.Windows.Forms.Label();
            this.lblFromModule1 = new System.Windows.Forms.Label();
            this.lblFromModule2 = new System.Windows.Forms.Label();
            this.groupBoxGPS.SuspendLayout();
            this.groupBoxGPS2.SuspendLayout();
            this.groupBoxSteer.SuspendLayout();
            this.groupBoxMachine.SuspendLayout();
            this.groupBoxModule3.SuspendLayout();
            this.groupBoxIMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMU)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBoxGPS
            // 
            this.groupBoxGPS.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxGPS.Controls.Add(this.cboxPort);
            this.groupBoxGPS.Controls.Add(this.cboxBaud);
            this.groupBoxGPS.Controls.Add(this.lblCurrentPort);
            this.groupBoxGPS.Controls.Add(this.lblCurrentBaud);
            this.groupBoxGPS.Controls.Add(this.btnCloseSerial);
            this.groupBoxGPS.Controls.Add(this.textBoxRcv);
            this.groupBoxGPS.Controls.Add(this.btnOpenSerial);
            this.groupBoxGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxGPS.Location = new System.Drawing.Point(173, 7);
            this.groupBoxGPS.Name = "groupBoxGPS";
            this.groupBoxGPS.Size = new System.Drawing.Size(678, 161);
            this.groupBoxGPS.TabIndex = 64;
            this.groupBoxGPS.TabStop = false;
            this.groupBoxGPS.Text = gStr.gsGPS;

            // 
            // cboxPort
            // 
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPort.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Location = new System.Drawing.Point(10, 49);
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.Size = new System.Drawing.Size(124, 37);
            this.cboxPort.TabIndex = 50;
            this.cboxPort.SelectedIndexChanged += new System.EventHandler(this.cboxPort_SelectedIndexChanged_1);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaud.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cboxBaud.Location = new System.Drawing.Point(161, 49);
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.Size = new System.Drawing.Size(127, 37);
            this.cboxBaud.TabIndex = 49;
            this.cboxBaud.SelectedIndexChanged += new System.EventHandler(this.cboxBaud_SelectedIndexChanged_1);
            // 
            // lblCurrentPort
            // 
            this.lblCurrentPort.AutoSize = true;
            this.lblCurrentPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPort.Location = new System.Drawing.Point(101, 28);
            this.lblCurrentPort.Name = "lblCurrentPort";
            this.lblCurrentPort.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentPort.TabIndex = 47;
            this.lblCurrentPort.Text = "Port";
            // 
            // lblCurrentBaud
            // 
            this.lblCurrentBaud.AutoSize = true;
            this.lblCurrentBaud.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBaud.Location = new System.Drawing.Point(243, 28);
            this.lblCurrentBaud.Name = "lblCurrentBaud";
            this.lblCurrentBaud.Size = new System.Drawing.Size(45, 18);
            this.lblCurrentBaud.TabIndex = 46;
            this.lblCurrentBaud.Text = "Baud";
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSerial.FlatAppearance.BorderSize = 0;
            this.btnCloseSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSerial.Image")));
            this.btnCloseSerial.Location = new System.Drawing.Point(459, 28);
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.Size = new System.Drawing.Size(101, 58);
            this.btnCloseSerial.TabIndex = 44;
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // textBoxRcv
            // 
            this.textBoxRcv.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcv.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcv.Location = new System.Drawing.Point(7, 94);
            this.textBoxRcv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRcv.Multiline = true;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            this.textBoxRcv.Size = new System.Drawing.Size(661, 53);
            this.textBoxRcv.TabIndex = 40;
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerial.FlatAppearance.BorderSize = 0;
            this.btnOpenSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerial.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSerial.Image")));
            this.btnOpenSerial.Location = new System.Drawing.Point(329, 28);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(101, 58);
            this.btnOpenSerial.TabIndex = 45;
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // groupBoxGPS2
            // 
            this.groupBoxGPS2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxGPS2.Controls.Add(this.cboxPort2);
            this.groupBoxGPS2.Controls.Add(this.cboxBaud2);
            this.groupBoxGPS2.Controls.Add(this.lblCurrentPort2);
            this.groupBoxGPS2.Controls.Add(this.lblCurrentBaud2);
            this.groupBoxGPS2.Controls.Add(this.btnCloseSerial2);
            this.groupBoxGPS2.Controls.Add(this.textBoxRcv2);
            this.groupBoxGPS2.Controls.Add(this.btnOpenSerial2);
            this.groupBoxGPS2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxGPS2.Location = new System.Drawing.Point(1118, 46);
            this.groupBoxGPS2.Name = "groupBoxGPS2";
            this.groupBoxGPS2.Size = new System.Drawing.Size(401, 120);
            this.groupBoxGPS2.TabIndex = 65;
            this.groupBoxGPS2.TabStop = false;
            this.groupBoxGPS2.Text = "GPS Port 2";
            // 
            // cboxPort2
            // 
            this.cboxPort2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxPort2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPort2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxPort2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort2.FormattingEnabled = true;
            this.cboxPort2.Location = new System.Drawing.Point(10, 37);
            this.cboxPort2.Name = "cboxPort2";
            this.cboxPort2.Size = new System.Drawing.Size(169, 37);
            this.cboxPort2.TabIndex = 50;
            this.cboxPort2.SelectedIndexChanged += new System.EventHandler(this.cboxPort2_SelectedIndexChanged);
            // 
            // cboxBaud2
            // 
            this.cboxBaud2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxBaud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBaud2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxBaud2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud2.FormattingEnabled = true;
            this.cboxBaud2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboxBaud2.Location = new System.Drawing.Point(198, 37);
            this.cboxBaud2.Name = "cboxBaud2";
            this.cboxBaud2.Size = new System.Drawing.Size(127, 37);
            this.cboxBaud2.TabIndex = 49;
            this.cboxBaud2.SelectedIndexChanged += new System.EventHandler(this.cboxBaud2_SelectedIndexChanged);
            // 
            // lblCurrentPort2
            // 
            this.lblCurrentPort2.AutoSize = true;
            this.lblCurrentPort2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPort2.Location = new System.Drawing.Point(139, 16);
            this.lblCurrentPort2.Name = "lblCurrentPort2";
            this.lblCurrentPort2.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentPort2.TabIndex = 47;
            this.lblCurrentPort2.Text = "Port";
            // 
            // lblCurrentBaud2
            // 
            this.lblCurrentBaud2.AutoSize = true;
            this.lblCurrentBaud2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBaud2.Location = new System.Drawing.Point(280, 16);
            this.lblCurrentBaud2.Name = "lblCurrentBaud2";
            this.lblCurrentBaud2.Size = new System.Drawing.Size(45, 18);
            this.lblCurrentBaud2.TabIndex = 46;
            this.lblCurrentBaud2.Text = "Baud";
            // 
            // btnCloseSerial2
            // 
            this.btnCloseSerial2.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSerial2.FlatAppearance.BorderSize = 0;
            this.btnCloseSerial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerial2.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSerial2.Image")));
            this.btnCloseSerial2.Location = new System.Drawing.Point(313, 37);
            this.btnCloseSerial2.Name = "btnCloseSerial2";
            this.btnCloseSerial2.Size = new System.Drawing.Size(101, 58);
            this.btnCloseSerial2.TabIndex = 44;
            this.btnCloseSerial2.UseVisualStyleBackColor = false;
            this.btnCloseSerial2.Click += new System.EventHandler(this.btnCloseSerial2_Click);
            // 
            // textBoxRcv2
            // 
            this.textBoxRcv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRcv2.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRcv2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.textBoxRcv2.Location = new System.Drawing.Point(-355, 81);
            this.textBoxRcv2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRcv2.Multiline = true;
            this.textBoxRcv2.Name = "textBoxRcv2";
            this.textBoxRcv2.ReadOnly = true;
            this.textBoxRcv2.Size = new System.Drawing.Size(176, 31);
            this.textBoxRcv2.TabIndex = 40;
            // 
            // btnOpenSerial2
            // 
            this.btnOpenSerial2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerial2.FlatAppearance.BorderSize = 0;
            this.btnOpenSerial2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerial2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerial2.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSerial2.Image")));
            this.btnOpenSerial2.Location = new System.Drawing.Point(224, 54);
            this.btnOpenSerial2.Name = "btnOpenSerial2";
            this.btnOpenSerial2.Size = new System.Drawing.Size(101, 58);
            this.btnOpenSerial2.TabIndex = 45;
            this.btnOpenSerial2.UseVisualStyleBackColor = false;
            this.btnOpenSerial2.Click += new System.EventHandler(this.btnOpenSerial2_Click);
            // 
            // groupBoxSteer
            // 
            this.groupBoxSteer.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSteer.Controls.Add(this.cboxModule1Port);
            this.groupBoxSteer.Controls.Add(this.lblCurrentModule1Port);
            this.groupBoxSteer.Controls.Add(this.btnOpenSerialModule1);
            this.groupBoxSteer.Controls.Add(this.btnCloseSerialModule1);
            this.groupBoxSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxSteer.Location = new System.Drawing.Point(173, 355);
            this.groupBoxSteer.Name = "groupBoxSteer";
            this.groupBoxSteer.Size = new System.Drawing.Size(405, 117);
            this.groupBoxSteer.TabIndex = 66;
            this.groupBoxSteer.TabStop = false;
            this.groupBoxSteer.Text = gStr.gsSteering;
            // 
            // cboxModule1Port
            // 
            this.cboxModule1Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule1Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule1Port.FormattingEnabled = true;
            this.cboxModule1Port.Location = new System.Drawing.Point(10, 57);
            this.cboxModule1Port.Name = "cboxModule1Port";
            this.cboxModule1Port.Size = new System.Drawing.Size(124, 37);
            this.cboxModule1Port.TabIndex = 64;
            this.cboxModule1Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule1_SelectedIndexChanged);
            // 
            // lblCurrentModule1Port
            // 
            this.lblCurrentModule1Port.AutoSize = true;
            this.lblCurrentModule1Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule1Port.Location = new System.Drawing.Point(22, 36);
            this.lblCurrentModule1Port.Name = "lblCurrentModule1Port";
            this.lblCurrentModule1Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule1Port.TabIndex = 69;
            this.lblCurrentModule1Port.Text = "Port";
            // 
            // btnOpenSerialModule1
            // 
            this.btnOpenSerialModule1.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerialModule1.FlatAppearance.BorderSize = 0;
            this.btnOpenSerialModule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerialModule1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule1.Image = global::AgIO.Properties.Resources.USB_Connect;
            this.btnOpenSerialModule1.Location = new System.Drawing.Point(161, 29);
            this.btnOpenSerialModule1.Name = "btnOpenSerialModule1";
            this.btnOpenSerialModule1.Size = new System.Drawing.Size(101, 58);
            this.btnOpenSerialModule1.TabIndex = 53;
            this.btnOpenSerialModule1.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule1.Click += new System.EventHandler(this.btnOpenSerialModule1_Click);
            // 
            // btnCloseSerialModule1
            // 
            this.btnCloseSerialModule1.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSerialModule1.FlatAppearance.BorderSize = 0;
            this.btnCloseSerialModule1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSerialModule1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule1.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSerialModule1.Image")));
            this.btnCloseSerialModule1.Location = new System.Drawing.Point(268, 29);
            this.btnCloseSerialModule1.Name = "btnCloseSerialModule1";
            this.btnCloseSerialModule1.Size = new System.Drawing.Size(101, 58);
            this.btnCloseSerialModule1.TabIndex = 52;
            this.btnCloseSerialModule1.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule1.Click += new System.EventHandler(this.btnCloseSerialModule1_Click);
            // 
            // groupBoxMachine
            // 
            this.groupBoxMachine.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMachine.Controls.Add(this.cboxModule2Port);
            this.groupBoxMachine.Controls.Add(this.lblCurrentModule2Port);
            this.groupBoxMachine.Controls.Add(this.btnOpenSerialModule2);
            this.groupBoxMachine.Controls.Add(this.btnCloseSerialModule2);
            this.groupBoxMachine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxMachine.Location = new System.Drawing.Point(173, 518);
            this.groupBoxMachine.Name = "groupBoxMachine";
            this.groupBoxMachine.Size = new System.Drawing.Size(405, 117);
            this.groupBoxMachine.TabIndex = 67;
            this.groupBoxMachine.TabStop = false;
            this.groupBoxMachine.Text = gStr.gsMachine;
            // 
            // cboxModule2Port
            // 
            this.cboxModule2Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule2Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule2Port.FormattingEnabled = true;
            this.cboxModule2Port.Location = new System.Drawing.Point(10, 62);
            this.cboxModule2Port.Name = "cboxModule2Port";
            this.cboxModule2Port.Size = new System.Drawing.Size(124, 37);
            this.cboxModule2Port.TabIndex = 64;
            this.cboxModule2Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule2Port_SelectedIndexChanged);
            // 
            // lblCurrentModule2Port
            // 
            this.lblCurrentModule2Port.AutoSize = true;
            this.lblCurrentModule2Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule2Port.Location = new System.Drawing.Point(22, 41);
            this.lblCurrentModule2Port.Name = "lblCurrentModule2Port";
            this.lblCurrentModule2Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule2Port.TabIndex = 70;
            this.lblCurrentModule2Port.Text = "Port";
            // 
            // btnOpenSerialModule2
            // 
            this.btnOpenSerialModule2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerialModule2.FlatAppearance.BorderSize = 0;
            this.btnOpenSerialModule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerialModule2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule2.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSerialModule2.Image")));
            this.btnOpenSerialModule2.Location = new System.Drawing.Point(161, 31);
            this.btnOpenSerialModule2.Name = "btnOpenSerialModule2";
            this.btnOpenSerialModule2.Size = new System.Drawing.Size(101, 58);
            this.btnOpenSerialModule2.TabIndex = 53;
            this.btnOpenSerialModule2.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule2.Click += new System.EventHandler(this.btnOpenSerialModule2_Click);
            // 
            // btnCloseSerialModule2
            // 
            this.btnCloseSerialModule2.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSerialModule2.FlatAppearance.BorderSize = 0;
            this.btnCloseSerialModule2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSerialModule2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule2.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSerialModule2.Image")));
            this.btnCloseSerialModule2.Location = new System.Drawing.Point(268, 31);
            this.btnCloseSerialModule2.Name = "btnCloseSerialModule2";
            this.btnCloseSerialModule2.Size = new System.Drawing.Size(101, 58);
            this.btnCloseSerialModule2.TabIndex = 52;
            this.btnCloseSerialModule2.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule2.Click += new System.EventHandler(this.btnCloseSerialModule2_Click);
            // 
            // groupBoxModule3
            // 
            this.groupBoxModule3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxModule3.Controls.Add(this.lblCurrentModule3Port);
            this.groupBoxModule3.Controls.Add(this.cboxModule3Port);
            this.groupBoxModule3.Controls.Add(this.btnOpenSerialModule3);
            this.groupBoxModule3.Controls.Add(this.btnCloseSerialModule3);
            this.groupBoxModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxModule3.Location = new System.Drawing.Point(1164, 222);
            this.groupBoxModule3.Name = "groupBoxModule3";
            this.groupBoxModule3.Size = new System.Drawing.Size(368, 90);
            this.groupBoxModule3.TabIndex = 68;
            this.groupBoxModule3.TabStop = false;
            this.groupBoxModule3.Text = "Module 3";
            // 
            // lblCurrentModule3Port
            // 
            this.lblCurrentModule3Port.AutoSize = true;
            this.lblCurrentModule3Port.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentModule3Port.Location = new System.Drawing.Point(115, 19);
            this.lblCurrentModule3Port.Name = "lblCurrentModule3Port";
            this.lblCurrentModule3Port.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentModule3Port.TabIndex = 71;
            this.lblCurrentModule3Port.Text = "Port";
            // 
            // cboxModule3Port
            // 
            this.cboxModule3Port.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxModule3Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxModule3Port.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxModule3Port.FormattingEnabled = true;
            this.cboxModule3Port.Location = new System.Drawing.Point(10, 42);
            this.cboxModule3Port.Name = "cboxModule3Port";
            this.cboxModule3Port.Size = new System.Drawing.Size(124, 37);
            this.cboxModule3Port.TabIndex = 64;
            this.cboxModule3Port.SelectedIndexChanged += new System.EventHandler(this.cboxModule3Port_SelectedIndexChanged);
            // 
            // btnOpenSerialModule3
            // 
            this.btnOpenSerialModule3.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerialModule3.FlatAppearance.BorderSize = 0;
            this.btnOpenSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSerialModule3.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenSerialModule3.Image")));
            this.btnOpenSerialModule3.Location = new System.Drawing.Point(161, 21);
            this.btnOpenSerialModule3.Name = "btnOpenSerialModule3";
            this.btnOpenSerialModule3.Size = new System.Drawing.Size(101, 58);
            this.btnOpenSerialModule3.TabIndex = 53;
            this.btnOpenSerialModule3.UseVisualStyleBackColor = false;
            this.btnOpenSerialModule3.Click += new System.EventHandler(this.btnOpenSerialModule3_Click);
            // 
            // btnCloseSerialModule3
            // 
            this.btnCloseSerialModule3.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSerialModule3.FlatAppearance.BorderSize = 0;
            this.btnCloseSerialModule3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSerialModule3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSerialModule3.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseSerialModule3.Image")));
            this.btnCloseSerialModule3.Location = new System.Drawing.Point(268, 19);
            this.btnCloseSerialModule3.Name = "btnCloseSerialModule3";
            this.btnCloseSerialModule3.Size = new System.Drawing.Size(101, 58);
            this.btnCloseSerialModule3.TabIndex = 52;
            this.btnCloseSerialModule3.UseVisualStyleBackColor = false;
            this.btnCloseSerialModule3.Click += new System.EventHandler(this.btnCloseSerialModule3_Click);
            // 
            // groupBoxIMU
            // 
            this.groupBoxIMU.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxIMU.Controls.Add(this.lblCurrentIMU);
            this.groupBoxIMU.Controls.Add(this.cboxIMU);
            this.groupBoxIMU.Controls.Add(this.btnCloseIMU);
            this.groupBoxIMU.Controls.Add(this.btnOpenIMU);
            this.groupBoxIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxIMU.Location = new System.Drawing.Point(173, 192);
            this.groupBoxIMU.Name = "groupBoxIMU";
            this.groupBoxIMU.Size = new System.Drawing.Size(405, 117);
            this.groupBoxIMU.TabIndex = 68;
            this.groupBoxIMU.TabStop = false;
            this.groupBoxIMU.Text = gStr.gsIMU;
            // 
            // lblCurrentIMU
            // 
            this.lblCurrentIMU.AutoSize = true;
            this.lblCurrentIMU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIMU.Location = new System.Drawing.Point(22, 37);
            this.lblCurrentIMU.Name = "lblCurrentIMU";
            this.lblCurrentIMU.Size = new System.Drawing.Size(40, 18);
            this.lblCurrentIMU.TabIndex = 51;
            this.lblCurrentIMU.Text = "Port";
            // 
            // cboxIMU
            // 
            this.cboxIMU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cboxIMU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxIMU.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.cboxIMU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxIMU.FormattingEnabled = true;
            this.cboxIMU.Location = new System.Drawing.Point(10, 58);
            this.cboxIMU.Name = "cboxIMU";
            this.cboxIMU.Size = new System.Drawing.Size(124, 37);
            this.cboxIMU.TabIndex = 50;
            this.cboxIMU.SelectedIndexChanged += new System.EventHandler(this.cboxIMU_SelectedIndexChanged);
            // 
            // btnCloseIMU
            // 
            this.btnCloseIMU.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseIMU.FlatAppearance.BorderSize = 0;
            this.btnCloseIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseIMU.Image = global::AgIO.Properties.Resources.USB_Disconnect;
            this.btnCloseIMU.Location = new System.Drawing.Point(262, 34);
            this.btnCloseIMU.Name = "btnCloseIMU";
            this.btnCloseIMU.Size = new System.Drawing.Size(101, 58);
            this.btnCloseIMU.TabIndex = 44;
            this.btnCloseIMU.UseVisualStyleBackColor = false;
            this.btnCloseIMU.Click += new System.EventHandler(this.btnCloseIMU_Click);
            // 
            // btnOpenIMU
            // 
            this.btnOpenIMU.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenIMU.FlatAppearance.BorderSize = 0;
            this.btnOpenIMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenIMU.Image = global::AgIO.Properties.Resources.USB_Connect;
            this.btnOpenIMU.Location = new System.Drawing.Point(161, 34);
            this.btnOpenIMU.Name = "btnOpenIMU";
            this.btnOpenIMU.Size = new System.Drawing.Size(101, 58);
            this.btnOpenIMU.TabIndex = 45;
            this.btnOpenIMU.UseVisualStyleBackColor = false;
            this.btnOpenIMU.Click += new System.EventHandler(this.btnOpenIMU_Click);
            // 
            // pictureBoxGPS
            // 
            this.pictureBoxGPS.BackgroundImage = global::AgIO.Properties.Resources.satellite;
            this.pictureBoxGPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGPS.Location = new System.Drawing.Point(36, 28);
            this.pictureBoxGPS.Name = "pictureBoxGPS";
            this.pictureBoxGPS.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxGPS.TabIndex = 72;
            this.pictureBoxGPS.TabStop = false;
            // 
            // pictureBoxMachine
            // 
            this.pictureBoxMachine.BackgroundImage = global::AgIO.Properties.Resources.Com_Module2;
            this.pictureBoxMachine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMachine.Location = new System.Drawing.Point(27, 515);
            this.pictureBoxMachine.Name = "pictureBoxMachine";
            this.pictureBoxMachine.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxMachine.TabIndex = 71;
            this.pictureBoxMachine.TabStop = false;
            // 
            // pictureBoxSteer
            // 
            this.pictureBoxSteer.BackgroundImage = global::AgIO.Properties.Resources.Com_AutosteerModule;
            this.pictureBoxSteer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSteer.Location = new System.Drawing.Point(27, 352);
            this.pictureBoxSteer.Name = "pictureBoxSteer";
            this.pictureBoxSteer.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxSteer.TabIndex = 70;
            this.pictureBoxSteer.TabStop = false;
            // 
            // pictureBoxIMU
            // 
            this.pictureBoxIMU.BackgroundImage = global::AgIO.Properties.Resources.Com_IMUModule;
            this.pictureBoxIMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxIMU.Location = new System.Drawing.Point(27, 189);
            this.pictureBoxIMU.Name = "pictureBoxIMU";
            this.pictureBoxIMU.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxIMU.TabIndex = 69;
            this.pictureBoxIMU.TabStop = false;
            // 
            // btnRescanPorts
            // 
            this.btnRescanPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRescanPorts.BackColor = System.Drawing.Color.Transparent;
            this.btnRescanPorts.FlatAppearance.BorderSize = 0;
            this.btnRescanPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRescanPorts.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescanPorts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRescanPorts.Image = global::AgIO.Properties.Resources.ScanPorts;
            this.btnRescanPorts.Location = new System.Drawing.Point(601, 589);
            this.btnRescanPorts.Name = "btnRescanPorts";
            this.btnRescanPorts.Size = new System.Drawing.Size(89, 63);
            this.btnRescanPorts.TabIndex = 58;
            this.btnRescanPorts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRescanPorts.UseVisualStyleBackColor = false;
            this.btnRescanPorts.Click += new System.EventHandler(this.btnRescanPorts_Click);
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackColor = System.Drawing.Color.Transparent;
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.FlatAppearance.BorderSize = 0;
            this.btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::AgIO.Properties.Resources.OK64;
            this.btnSerialOK.Location = new System.Drawing.Point(762, 588);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(91, 63);
            this.btnSerialOK.TabIndex = 59;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = false;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // labelGPS
            // 
            this.labelGPS.AutoSize = true;
            this.labelGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelGPS.Location = new System.Drawing.Point(625, 232);
            this.labelGPS.Name = "labelGPS";
            this.labelGPS.Size = new System.Drawing.Size(55, 23);
            this.labelGPS.TabIndex = 73;
            this.labelGPS.Text = "GPS:";
            // 
            // labelGPS2
            // 
            this.labelGPS2.AutoSize = true;
            this.labelGPS2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPS2.Location = new System.Drawing.Point(413, 322);
            this.labelGPS2.Name = "labelGPS2";
            this.labelGPS2.Size = new System.Drawing.Size(39, 18);
            this.labelGPS2.TabIndex = 74;
            this.labelGPS2.Text = "GPS";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMachine.Location = new System.Drawing.Point(584, 349);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(96, 23);
            this.labelMachine.TabIndex = 76;
            this.labelMachine.Text = "Machine:";
            // 
            // labelSteer
            // 
            this.labelSteer.AutoSize = true;
            this.labelSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSteer.Location = new System.Drawing.Point(613, 315);
            this.labelSteer.Name = "labelSteer";
            this.labelSteer.Size = new System.Drawing.Size(67, 23);
            this.labelSteer.TabIndex = 77;
            this.labelSteer.Text = "Steer:";
            // 
            // labelIMU
            // 
            this.labelIMU.AutoSize = true;
            this.labelIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIMU.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelIMU.Location = new System.Drawing.Point(623, 276);
            this.labelIMU.Name = "labelIMU";
            this.labelIMU.Size = new System.Drawing.Size(57, 23);
            this.labelIMU.TabIndex = 78;
            this.labelIMU.Text = "IMU:";
            // 
            // lblIMU
            // 
            this.lblIMU.AutoSize = true;
            this.lblIMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMU.Location = new System.Drawing.Point(679, 276);
            this.lblIMU.Name = "lblIMU";
            this.lblIMU.Size = new System.Drawing.Size(50, 23);
            this.lblIMU.TabIndex = 83;
            this.lblIMU.Text = "IMU";
            // 
            // lblSteer
            // 
            this.lblSteer.AutoSize = true;
            this.lblSteer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteer.Location = new System.Drawing.Point(679, 315);
            this.lblSteer.Name = "lblSteer";
            this.lblSteer.Size = new System.Drawing.Size(60, 23);
            this.lblSteer.TabIndex = 82;
            this.lblSteer.Text = "Steer";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(679, 349);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(60, 23);
            this.lblMachine.TabIndex = 81;
            this.lblMachine.Text = "Mach";
            // 
            // lblGPS
            // 
            this.lblGPS.AutoSize = true;
            this.lblGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPS.Location = new System.Drawing.Point(679, 232);
            this.lblGPS.Name = "lblGPS";
            this.lblGPS.Size = new System.Drawing.Size(48, 23);
            this.lblGPS.TabIndex = 79;
            this.lblGPS.Text = "GPS";
            // 
            // lblFromGPS
            // 
            this.lblFromGPS.BackColor = System.Drawing.Color.Transparent;
            this.lblFromGPS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromGPS.ForeColor = System.Drawing.Color.Black;
            this.lblFromGPS.Location = new System.Drawing.Point(758, 230);
            this.lblFromGPS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromGPS.Name = "lblFromGPS";
            this.lblFromGPS.Size = new System.Drawing.Size(64, 27);
            this.lblFromGPS.TabIndex = 172;
            this.lblFromGPS.Text = "---";
            this.lblFromGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromMU
            // 
            this.lblFromMU.BackColor = System.Drawing.Color.Transparent;
            this.lblFromMU.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromMU.ForeColor = System.Drawing.Color.Black;
            this.lblFromMU.Location = new System.Drawing.Point(758, 273);
            this.lblFromMU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromMU.Name = "lblFromMU";
            this.lblFromMU.Size = new System.Drawing.Size(64, 27);
            this.lblFromMU.TabIndex = 175;
            this.lblFromMU.Text = "---";
            this.lblFromMU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromModule1
            // 
            this.lblFromModule1.BackColor = System.Drawing.Color.Transparent;
            this.lblFromModule1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromModule1.ForeColor = System.Drawing.Color.Black;
            this.lblFromModule1.Location = new System.Drawing.Point(758, 313);
            this.lblFromModule1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromModule1.Name = "lblFromModule1";
            this.lblFromModule1.Size = new System.Drawing.Size(64, 27);
            this.lblFromModule1.TabIndex = 173;
            this.lblFromModule1.Text = "---";
            this.lblFromModule1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromModule2
            // 
            this.lblFromModule2.BackColor = System.Drawing.Color.Transparent;
            this.lblFromModule2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromModule2.ForeColor = System.Drawing.Color.Black;
            this.lblFromModule2.Location = new System.Drawing.Point(758, 347);
            this.lblFromModule2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromModule2.Name = "lblFromModule2";
            this.lblFromModule2.Size = new System.Drawing.Size(64, 27);
            this.lblFromModule2.TabIndex = 174;
            this.lblFromModule2.Text = "---";
            this.lblFromModule2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCommSetGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(865, 663);
            this.ControlBox = false;
            this.Controls.Add(this.lblFromGPS);
            this.Controls.Add(this.lblFromMU);
            this.Controls.Add(this.lblFromModule1);
            this.Controls.Add(this.lblFromModule2);
            this.Controls.Add(this.lblIMU);
            this.Controls.Add(this.lblSteer);
            this.Controls.Add(this.lblMachine);
            this.Controls.Add(this.lblGPS);
            this.Controls.Add(this.labelIMU);
            this.Controls.Add(this.labelSteer);
            this.Controls.Add(this.labelMachine);
            this.Controls.Add(this.labelGPS2);
            this.Controls.Add(this.labelGPS);
            this.Controls.Add(this.pictureBoxGPS);
            this.Controls.Add(this.pictureBoxMachine);
            this.Controls.Add(this.pictureBoxSteer);
            this.Controls.Add(this.pictureBoxIMU);
            this.Controls.Add(this.groupBoxIMU);
            this.Controls.Add(this.groupBoxMachine);
            this.Controls.Add(this.groupBoxModule3);
            this.Controls.Add(this.groupBoxSteer);
            this.Controls.Add(this.groupBoxGPS2);
            this.Controls.Add(this.btnRescanPorts);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.groupBoxGPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCommSetGPS";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = gStr.gsConnectGPS;
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBoxGPS.ResumeLayout(false);
            this.groupBoxGPS.PerformLayout();
            this.groupBoxGPS2.ResumeLayout(false);
            this.groupBoxGPS2.PerformLayout();
            this.groupBoxSteer.ResumeLayout(false);
            this.groupBoxSteer.PerformLayout();
            this.groupBoxMachine.ResumeLayout(false);
            this.groupBoxMachine.PerformLayout();
            this.groupBoxModule3.ResumeLayout(false);
            this.groupBoxModule3.PerformLayout();
            this.groupBoxIMU.ResumeLayout(false);
            this.groupBoxIMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSteer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescanPorts;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBoxGPS;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.GroupBox groupBoxGPS2;
        private System.Windows.Forms.ComboBox cboxPort2;
        private System.Windows.Forms.ComboBox cboxBaud2;
        private System.Windows.Forms.Label lblCurrentPort2;
        private System.Windows.Forms.Label lblCurrentBaud2;
        private System.Windows.Forms.Button btnCloseSerial2;
        private System.Windows.Forms.TextBox textBoxRcv2;
        private System.Windows.Forms.Button btnOpenSerial2;
        private System.Windows.Forms.GroupBox groupBoxSteer;
        private System.Windows.Forms.ComboBox cboxModule1Port;
        private System.Windows.Forms.Button btnOpenSerialModule1;
        private System.Windows.Forms.Button btnCloseSerialModule1;
        private System.Windows.Forms.GroupBox groupBoxMachine;
        private System.Windows.Forms.ComboBox cboxModule2Port;
        private System.Windows.Forms.Button btnOpenSerialModule2;
        private System.Windows.Forms.Button btnCloseSerialModule2;
        private System.Windows.Forms.GroupBox groupBoxModule3;
        private System.Windows.Forms.ComboBox cboxModule3Port;
        private System.Windows.Forms.Button btnOpenSerialModule3;
        private System.Windows.Forms.Button btnCloseSerialModule3;
        private System.Windows.Forms.GroupBox groupBoxIMU;
        private System.Windows.Forms.ComboBox cboxIMU;
        private System.Windows.Forms.Button btnCloseIMU;
        private System.Windows.Forms.Button btnOpenIMU;
        private System.Windows.Forms.Label lblCurrentModule1Port;
        private System.Windows.Forms.Label lblCurrentModule2Port;
        private System.Windows.Forms.Label lblCurrentModule3Port;
        private System.Windows.Forms.Label lblCurrentIMU;
        private System.Windows.Forms.PictureBox pictureBoxIMU;
        private System.Windows.Forms.PictureBox pictureBoxSteer;
        private System.Windows.Forms.PictureBox pictureBoxMachine;
        private System.Windows.Forms.PictureBox pictureBoxGPS;
        private System.Windows.Forms.Label labelGPS;
        private System.Windows.Forms.Label labelGPS2;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelSteer;
        private System.Windows.Forms.Label labelIMU;
        private System.Windows.Forms.Label lblIMU;
        private System.Windows.Forms.Label lblSteer;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.Label lblFromGPS;
        private System.Windows.Forms.Label lblFromMU;
        private System.Windows.Forms.Label lblFromModule1;
        private System.Windows.Forms.Label lblFromModule2;
    }
}