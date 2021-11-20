namespace AgIO
{
    partial class FormGPSData
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelQuality = new System.Windows.Forms.Label();
            this.labelNumSats = new System.Windows.Forms.Label();
            this.lblFixQuality = new System.Windows.Forms.Label();
            this.lblSatsTracked = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.labelAltitude = new System.Windows.Forms.Label();
            this.labelHDOP = new System.Windows.Forms.Label();
            this.lblHDOP = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.lblGPSHeading = new System.Windows.Forms.Label();
            this.labelVTG = new System.Windows.Forms.Label();
            this.labelAVR = new System.Windows.Forms.Label();
            this.labelGCA = new System.Windows.Forms.Label();
            this.labelOGI = new System.Windows.Forms.Label();
            this.labelVTGs = new System.Windows.Forms.Label();
            this.labelHDT = new System.Windows.Forms.Label();
            this.labelHPD = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.labelLon = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.tboxVTG = new System.Windows.Forms.TextBox();
            this.tboxGGA = new System.Windows.Forms.TextBox();
            this.tboxHDT = new System.Windows.Forms.TextBox();
            this.tboxAVR = new System.Windows.Forms.TextBox();
            this.tboxPAOGI = new System.Windows.Forms.TextBox();
            this.tboxHPD = new System.Windows.Forms.TextBox();
            this.lblDualHeading = new System.Windows.Forms.Label();
            this.labelDual = new System.Windows.Forms.Label();
            this.labelRMC = new System.Windows.Forms.Label();
            this.tboxRMC = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuality.ForeColor = System.Drawing.Color.Black;
            this.labelQuality.Location = new System.Drawing.Point(5, 71);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(52, 18);
            this.labelQuality.TabIndex = 8;
            this.labelQuality.Text = gStr.gsQuality;
            // 
            // labelNumSats
            // 
            this.labelNumSats.AutoSize = true;
            this.labelNumSats.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumSats.ForeColor = System.Drawing.Color.Black;
            this.labelNumSats.Location = new System.Drawing.Point(178, 28);
            this.labelNumSats.Name = "labelNumSats";
            this.labelNumSats.Size = new System.Drawing.Size(52, 18);
            this.labelNumSats.TabIndex = 9;
            this.labelNumSats.Text = "# Sats";
            // 
            // lblFixQuality
            // 
            this.lblFixQuality.AutoSize = true;
            this.lblFixQuality.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixQuality.Location = new System.Drawing.Point(58, 72);
            this.lblFixQuality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFixQuality.Name = "lblFixQuality";
            this.lblFixQuality.Size = new System.Drawing.Size(66, 18);
            this.lblFixQuality.TabIndex = 2;
            this.lblFixQuality.Text = "FixQual";
            this.lblFixQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSatsTracked
            // 
            this.lblSatsTracked.AutoSize = true;
            this.lblSatsTracked.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatsTracked.Location = new System.Drawing.Point(231, 29);
            this.lblSatsTracked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSatsTracked.Name = "lblSatsTracked";
            this.lblSatsTracked.Size = new System.Drawing.Size(41, 18);
            this.lblSatsTracked.TabIndex = 4;
            this.lblSatsTracked.Text = "Sats";
            this.lblSatsTracked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.Location = new System.Drawing.Point(231, 51);
            this.lblAltitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(67, 18);
            this.lblAltitude.TabIndex = 14;
            this.lblAltitude.Text = gStr.gsAltitude;
            this.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAltitude
            // 
            this.labelAltitude.AutoSize = true;
            this.labelAltitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltitude.ForeColor = System.Drawing.Color.Black;
            this.labelAltitude.Location = new System.Drawing.Point(175, 50);
            this.labelAltitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAltitude.Name = "labelAltitude";
            this.labelAltitude.Size = new System.Drawing.Size(55, 18);
            this.labelAltitude.TabIndex = 16;
            this.labelAltitude.Text = gStr.gsAltitude;
            // 
            // labelHDOP
            // 
            this.labelHDOP.AutoSize = true;
            this.labelHDOP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHDOP.ForeColor = System.Drawing.Color.Black;
            this.labelHDOP.Location = new System.Drawing.Point(183, 6);
            this.labelHDOP.Name = "labelHDOP";
            this.labelHDOP.Size = new System.Drawing.Size(47, 18);
            this.labelHDOP.TabIndex = 18;
            this.labelHDOP.Text = "HDOP";
            // 
            // lblHDOP
            // 
            this.lblHDOP.AutoSize = true;
            this.lblHDOP.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDOP.Location = new System.Drawing.Point(231, 7);
            this.lblHDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHDOP.Name = "lblHDOP";
            this.lblHDOP.Size = new System.Drawing.Size(52, 18);
            this.lblHDOP.TabIndex = 17;
            this.lblHDOP.Text = "HDOP";
            this.lblHDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.Color.Black;
            this.labelSpeed.Location = new System.Drawing.Point(5, 49);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(48, 18);
            this.labelSpeed.TabIndex = 116;
            this.labelSpeed.Text = gStr.gsSpeed;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(52, 49);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(54, 18);
            this.lblSpeed.TabIndex = 115;
            this.lblSpeed.Text = gStr.gsSpeed;
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRoll.Location = new System.Drawing.Point(407, 56);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(49, 18);
            this.lblRoll.TabIndex = 463;
            this.lblRoll.Text = "-11.2";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.BackColor = System.Drawing.Color.Transparent;
            this.labelRoll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.ForeColor = System.Drawing.Color.Black;
            this.labelRoll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRoll.Location = new System.Drawing.Point(380, 56);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(29, 18);
            this.labelRoll.TabIndex = 460;
            this.labelRoll.Text = gStr.gsRoll;
            // 
            // lblGPSHeading
            // 
            this.lblGPSHeading.AutoSize = true;
            this.lblGPSHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblGPSHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPSHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblGPSHeading.Location = new System.Drawing.Point(406, 7);
            this.lblGPSHeading.Name = "lblGPSHeading";
            this.lblGPSHeading.Size = new System.Drawing.Size(54, 19);
            this.lblGPSHeading.TabIndex = 462;
            this.lblGPSHeading.Text = "359.3";
            this.lblGPSHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVTG
            // 
            this.labelVTG.AutoSize = true;
            this.labelVTG.BackColor = System.Drawing.Color.Transparent;
            this.labelVTG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVTG.ForeColor = System.Drawing.Color.Black;
            this.labelVTG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVTG.Location = new System.Drawing.Point(366, 7);
            this.labelVTG.Name = "labelVTG";
            this.labelVTG.Size = new System.Drawing.Size(40, 19);
            this.labelVTG.TabIndex = 458;
            this.labelVTG.Text = "VTG";
            // 
            // labelAVR
            // 
            this.labelAVR.AutoSize = true;
            this.labelAVR.BackColor = System.Drawing.Color.Transparent;
            this.labelAVR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAVR.Location = new System.Drawing.Point(6, 266);
            this.labelAVR.Name = "labelAVR";
            this.labelAVR.Size = new System.Drawing.Size(27, 13);
            this.labelAVR.TabIndex = 496;
            this.labelAVR.Text = "AVR";
            // 
            // labelGCA
            // 
            this.labelGCA.AutoSize = true;
            this.labelGCA.BackColor = System.Drawing.Color.Transparent;
            this.labelGCA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGCA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGCA.Location = new System.Drawing.Point(5, 111);
            this.labelGCA.Name = "labelGCA";
            this.labelGCA.Size = new System.Drawing.Size(28, 13);
            this.labelGCA.TabIndex = 501;
            this.labelGCA.Text = "GGA";
            // 
            // labelOGI
            // 
            this.labelOGI.AutoSize = true;
            this.labelOGI.BackColor = System.Drawing.Color.Transparent;
            this.labelOGI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOGI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOGI.Location = new System.Drawing.Point(7, 204);
            this.labelOGI.Name = "labelOGI";
            this.labelOGI.Size = new System.Drawing.Size(26, 13);
            this.labelOGI.TabIndex = 502;
            this.labelOGI.Text = "OGI";
            // 
            // labelVTGs
            // 
            this.labelVTGs.AutoSize = true;
            this.labelVTGs.BackColor = System.Drawing.Color.Transparent;
            this.labelVTGs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVTGs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelVTGs.Location = new System.Drawing.Point(7, 142);
            this.labelVTGs.Name = "labelVTGs";
            this.labelVTGs.Size = new System.Drawing.Size(26, 13);
            this.labelVTGs.TabIndex = 503;
            this.labelVTGs.Text = "VTG";
            // 
            // labelHDT
            // 
            this.labelHDT.AutoSize = true;
            this.labelHDT.BackColor = System.Drawing.Color.Transparent;
            this.labelHDT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHDT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHDT.Location = new System.Drawing.Point(6, 235);
            this.labelHDT.Name = "labelHDT";
            this.labelHDT.Size = new System.Drawing.Size(27, 13);
            this.labelHDT.TabIndex = 505;
            this.labelHDT.Text = "HDT";
            // 
            // labelHPD
            // 
            this.labelHPD.AutoSize = true;
            this.labelHPD.BackColor = System.Drawing.Color.Transparent;
            this.labelHPD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelHPD.Location = new System.Drawing.Point(6, 296);
            this.labelHPD.Name = "labelHPD";
            this.labelHPD.Size = new System.Drawing.Size(27, 13);
            this.labelHPD.TabIndex = 509;
            this.labelHPD.Text = "HPD";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.Location = new System.Drawing.Point(36, 28);
            this.lblLongitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(82, 18);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = gStr.gsLongitude;
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLon.ForeColor = System.Drawing.Color.Black;
            this.labelLon.Location = new System.Drawing.Point(6, 28);
            this.labelLon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(31, 18);
            this.labelLon.TabIndex = 15;
            this.labelLon.Text = "Lon";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLat.ForeColor = System.Drawing.Color.Black;
            this.labelLat.Location = new System.Drawing.Point(9, 7);
            this.labelLat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(28, 18);
            this.labelLat.TabIndex = 5;
            this.labelLat.Text = "Lat";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.Location = new System.Drawing.Point(36, 7);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(70, 18);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text =gStr.gsLatitude;
            // 
            // tboxVTG
            // 
            this.tboxVTG.BackColor = System.Drawing.SystemColors.Window;
            this.tboxVTG.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxVTG.Location = new System.Drawing.Point(35, 138);
            this.tboxVTG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxVTG.Name = "tboxVTG";
            this.tboxVTG.ReadOnly = true;
            this.tboxVTG.Size = new System.Drawing.Size(291, 21);
            this.tboxVTG.TabIndex = 497;
            this.tboxVTG.Text = "$GPVTG,0,T,034.4,M,1,N,1.852,K";
            // 
            // tboxGGA
            // 
            this.tboxGGA.BackColor = System.Drawing.SystemColors.Window;
            this.tboxGGA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGGA.Location = new System.Drawing.Point(35, 107);
            this.tboxGGA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxGGA.Name = "tboxGGA";
            this.tboxGGA.ReadOnly = true;
            this.tboxGGA.Size = new System.Drawing.Size(449, 21);
            this.tboxGGA.TabIndex = 498;
            this.tboxGGA.Text = "$GPGGA,055129.00,5326.1729618,N,111,09.6028200,W,4,12,0.9,300,M,46.9,M,,,";
            // 
            // tboxHDT
            // 
            this.tboxHDT.BackColor = System.Drawing.SystemColors.Window;
            this.tboxHDT.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHDT.Location = new System.Drawing.Point(35, 231);
            this.tboxHDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxHDT.Name = "tboxHDT";
            this.tboxHDT.ReadOnly = true;
            this.tboxHDT.Size = new System.Drawing.Size(291, 21);
            this.tboxHDT.TabIndex = 499;
            this.tboxHDT.Text = "$GNHDT,123.456,T * 00";
            // 
            // tboxAVR
            // 
            this.tboxAVR.BackColor = System.Drawing.SystemColors.Window;
            this.tboxAVR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAVR.Location = new System.Drawing.Point(35, 262);
            this.tboxAVR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxAVR.Name = "tboxAVR";
            this.tboxAVR.ReadOnly = true;
            this.tboxAVR.Size = new System.Drawing.Size(449, 21);
            this.tboxAVR.TabIndex = 500;
            this.tboxAVR.Text = "$PTNL,AVR,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // tboxPAOGI
            // 
            this.tboxPAOGI.BackColor = System.Drawing.SystemColors.Window;
            this.tboxPAOGI.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPAOGI.Location = new System.Drawing.Point(35, 200);
            this.tboxPAOGI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxPAOGI.Name = "tboxPAOGI";
            this.tboxPAOGI.ReadOnly = true;
            this.tboxPAOGI.Size = new System.Drawing.Size(449, 21);
            this.tboxPAOGI.TabIndex = 504;
            this.tboxPAOGI.Text = "$PAOGI,055129.00,5326.1729618,N,111,09.6028200,W,4,12,0.9,300,M,46.9,M,,,";
            // 
            // tboxHPD
            // 
            this.tboxHPD.BackColor = System.Drawing.SystemColors.Window;
            this.tboxHPD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHPD.Location = new System.Drawing.Point(35, 293);
            this.tboxHPD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxHPD.Name = "tboxHPD";
            this.tboxHPD.ReadOnly = true;
            this.tboxHPD.Size = new System.Drawing.Size(449, 21);
            this.tboxHPD.TabIndex = 510;
            this.tboxHPD.Text = "$PTNL,AVR,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // lblDualHeading
            // 
            this.lblDualHeading.AutoSize = true;
            this.lblDualHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblDualHeading.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDualHeading.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDualHeading.Location = new System.Drawing.Point(406, 30);
            this.lblDualHeading.Name = "lblDualHeading";
            this.lblDualHeading.Size = new System.Drawing.Size(54, 19);
            this.lblDualHeading.TabIndex = 514;
            this.lblDualHeading.Text = "359.3";
            this.lblDualHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDual
            // 
            this.labelDual.AutoSize = true;
            this.labelDual.BackColor = System.Drawing.Color.Transparent;
            this.labelDual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDual.ForeColor = System.Drawing.Color.Black;
            this.labelDual.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDual.Location = new System.Drawing.Point(366, 30);
            this.labelDual.Name = "labelDual";
            this.labelDual.Size = new System.Drawing.Size(41, 19);
            this.labelDual.TabIndex = 513;
            this.labelDual.Text = gStr.gsDual;
            // 
            // labelRMC
            // 
            this.labelRMC.AutoSize = true;
            this.labelRMC.BackColor = System.Drawing.Color.Transparent;
            this.labelRMC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRMC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelRMC.Location = new System.Drawing.Point(4, 173);
            this.labelRMC.Name = "labelRMC";
            this.labelRMC.Size = new System.Drawing.Size(29, 13);
            this.labelRMC.TabIndex = 511;
            this.labelRMC.Text = "RMC";
            // 
            // tboxRMC
            // 
            this.tboxRMC.BackColor = System.Drawing.SystemColors.Window;
            this.tboxRMC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRMC.Location = new System.Drawing.Point(35, 169);
            this.tboxRMC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxRMC.Name = "tboxRMC";
            this.tboxRMC.ReadOnly = true;
            this.tboxRMC.Size = new System.Drawing.Size(449, 21);
            this.tboxRMC.TabIndex = 512;
            this.tboxRMC.Text = "$PTNL,AVR,145331.50,+35.9990,Yaw,-7.8209,Tilt,-0.4305,Roll,444.232,3,1.2,17 * 03";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(231, 73);
            this.lblAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 18);
            this.lblAge.TabIndex = 515;
            this.lblAge.Text =gStr.gsAge;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.ForeColor = System.Drawing.Color.Black;
            this.labelAge.Location = new System.Drawing.Point(197, 72);
            this.labelAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 18);
            this.labelAge.TabIndex = 516;
            this.labelAge.Text = gStr.gsAge;
            // 
            // FormGPSData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(505, 327);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.lblDualHeading);
            this.Controls.Add(this.labelDual);
            this.Controls.Add(this.tboxRMC);
            this.Controls.Add(this.labelRMC);
            this.Controls.Add(this.tboxHPD);
            this.Controls.Add(this.labelHPD);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.tboxPAOGI);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.tboxAVR);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.tboxHDT);
            this.Controls.Add(this.tboxGGA);
            this.Controls.Add(this.tboxVTG);
            this.Controls.Add(this.labelHDT);
            this.Controls.Add(this.labelVTGs);
            this.Controls.Add(this.labelOGI);
            this.Controls.Add(this.labelGCA);
            this.Controls.Add(this.labelAVR);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.labelRoll);
            this.Controls.Add(this.lblGPSHeading);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.labelHDOP);
            this.Controls.Add(this.lblHDOP);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.labelQuality);
            this.Controls.Add(this.lblSatsTracked);
            this.Controls.Add(this.lblFixQuality);
            this.Controls.Add(this.labelNumSats);
            this.Controls.Add(this.labelVTG);
            this.Controls.Add(this.labelAltitude);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGPSData";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = gStr.gsSystemData;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGPSData_FormClosing);
            this.Load += new System.EventHandler(this.FormGPSData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.Label labelNumSats;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblSatsTracked;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label labelAltitude;
        private System.Windows.Forms.Label labelHDOP;
        private System.Windows.Forms.Label lblHDOP;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label lblGPSHeading;
        private System.Windows.Forms.Label labelVTG;
        private System.Windows.Forms.Label labelAVR;
        private System.Windows.Forms.Label labelGCA;
        private System.Windows.Forms.Label labelOGI;
        private System.Windows.Forms.Label labelVTGs;
        private System.Windows.Forms.Label labelHDT;
        private System.Windows.Forms.Label labelHPD;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label labelLon;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.TextBox tboxVTG;
        private System.Windows.Forms.TextBox tboxGGA;
        private System.Windows.Forms.TextBox tboxHDT;
        private System.Windows.Forms.TextBox tboxAVR;
        private System.Windows.Forms.TextBox tboxPAOGI;
        private System.Windows.Forms.TextBox tboxHPD;
        private System.Windows.Forms.Label lblDualHeading;
        private System.Windows.Forms.Label labelDual;
        private System.Windows.Forms.Label labelRMC;
        private System.Windows.Forms.TextBox tboxRMC;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label labelAge;
    }
}