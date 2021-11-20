namespace AgIO
{
    partial class FormUDP
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
            this.groupBoxDriveServer = new System.Windows.Forms.GroupBox();
            this.labelModuleSendInfo = new System.Windows.Forms.Label();
            this.tboxHostName = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelThisComputer = new System.Windows.Forms.Label();
            this.tboxThisIP = new System.Windows.Forms.TextBox();
            this.nudThisPort = new System.Windows.Forms.NumericUpDown();
            this.labelHostPort = new System.Windows.Forms.Label();
            this.labelHostIP = new System.Windows.Forms.Label();
            this.labelServerPortActual = new System.Windows.Forms.Label();
            this.labelRestartWarning = new System.Windows.Forms.Label();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.labelModulePortActual = new System.Windows.Forms.Label();
            this.labelModulePort = new System.Windows.Forms.Label();
            this.labelModIp = new System.Windows.Forms.Label();
            this.labelModPort = new System.Windows.Forms.Label();
            this.nudAutoSteerPort = new System.Windows.Forms.NumericUpDown();
            this.tboxAutoSteerIP = new System.Windows.Forms.TextBox();
            this.groupBoxModule = new System.Windows.Forms.GroupBox();
            this.labelModuleUseInfo = new System.Windows.Forms.Label();
            this.cboxIsUDPOn = new System.Windows.Forms.CheckBox();
            this.groupBoxNetworking = new System.Windows.Forms.GroupBox();
            this.groupBoxDriveServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThisPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSteerPort)).BeginInit();
            this.groupBoxModule.SuspendLayout();
            this.groupBoxNetworking.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDriveServer
            // 
            this.groupBoxDriveServer.Controls.Add(this.labelModuleSendInfo);
            this.groupBoxDriveServer.Controls.Add(this.tboxHostName);
            this.groupBoxDriveServer.Controls.Add(this.labelHost);
            this.groupBoxDriveServer.Controls.Add(this.labelThisComputer);
            this.groupBoxDriveServer.Controls.Add(this.tboxThisIP);
            this.groupBoxDriveServer.Controls.Add(this.nudThisPort);
            this.groupBoxDriveServer.Controls.Add(this.labelHostPort);
            this.groupBoxDriveServer.Controls.Add(this.labelHostIP);
            this.groupBoxDriveServer.Controls.Add(this.labelServerPortActual);
            this.groupBoxDriveServer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDriveServer.Location = new System.Drawing.Point(12, 62);
            this.groupBoxDriveServer.Name = "groupBoxDriveServer";
            this.groupBoxDriveServer.Size = new System.Drawing.Size(300, 232);
            this.groupBoxDriveServer.TabIndex = 72;
            this.groupBoxDriveServer.TabStop = false;
            this.groupBoxDriveServer.Text = gStr.gsDriveServer;
            // 
            // labelModuleSendInfo
            // 
            this.labelModuleSendInfo.AutoSize = true;
            this.labelModuleSendInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModuleSendInfo.Location = new System.Drawing.Point(14, 204);
            this.labelModuleSendInfo.Name = "labelModuleSendInfo";
            this.labelModuleSendInfo.Size = new System.Drawing.Size(219, 23);
            this.labelModuleSendInfo.TabIndex = 95;
            this.labelModuleSendInfo.Text = gStr.gsModuleSendInfo;
            // 
            // tboxHostName
            // 
            this.tboxHostName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHostName.Location = new System.Drawing.Point(57, 79);
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
            this.labelHost.Location = new System.Drawing.Point(2, 81);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(47, 23);
            this.labelHost.TabIndex = 85;
            this.labelHost.Text = gStr.gsHost;
            // 
            // labelThisComputer
            // 
            this.labelThisComputer.AutoSize = true;
            this.labelThisComputer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThisComputer.Location = new System.Drawing.Point(7, 38);
            this.labelThisComputer.Name = "labelThisComputer";
            this.labelThisComputer.Size = new System.Drawing.Size(132, 23);
            this.labelThisComputer.TabIndex = 84;
            this.labelThisComputer.Text =gStr.gsThisComputer;
            // 
            // tboxThisIP
            // 
            this.tboxThisIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxThisIP.Location = new System.Drawing.Point(54, 120);
            this.tboxThisIP.Name = "tboxThisIP";
            this.tboxThisIP.ReadOnly = true;
            this.tboxThisIP.Size = new System.Drawing.Size(157, 30);
            this.tboxThisIP.TabIndex = 73;
            this.tboxThisIP.Text = "192.168.1.255";
            // 
            // nudThisPort
            // 
            this.nudThisPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThisPort.Location = new System.Drawing.Point(54, 162);
            this.nudThisPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudThisPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudThisPort.Name = "nudThisPort";
            this.nudThisPort.Size = new System.Drawing.Size(96, 30);
            this.nudThisPort.TabIndex = 74;
            this.nudThisPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // labelHostPort
            // 
            this.labelHostPort.AutoSize = true;
            this.labelHostPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostPort.Location = new System.Drawing.Point(7, 165);
            this.labelHostPort.Name = "labelHostPort";
            this.labelHostPort.Size = new System.Drawing.Size(43, 23);
            this.labelHostPort.TabIndex = 75;
            this.labelHostPort.Text = "Port";
            // 
            // labelHostIP
            // 
            this.labelHostIP.AutoSize = true;
            this.labelHostIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHostIP.Location = new System.Drawing.Point(22, 124);
            this.labelHostIP.Name = "labelHostIP";
            this.labelHostIP.Size = new System.Drawing.Size(27, 23);
            this.labelHostIP.TabIndex = 76;
            this.labelHostIP.Text = "IP";
            // 
            // labelServerPortActual
            // 
            this.labelServerPortActual.AutoSize = true;
            this.labelServerPortActual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServerPortActual.Location = new System.Drawing.Point(163, 170);
            this.labelServerPortActual.Name = "labelServerPortActual";
            this.labelServerPortActual.Size = new System.Drawing.Size(45, 19);
            this.labelServerPortActual.TabIndex = 78;
            this.labelServerPortActual.Text = "9999";
            // 
            // labelRestartWarning
            // 
            this.labelRestartWarning.AutoSize = true;
            this.labelRestartWarning.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRestartWarning.Location = new System.Drawing.Point(5, 8);
            this.labelRestartWarning.Name = "labelRestartWarning";
            this.labelRestartWarning.Size = new System.Drawing.Size(463, 23);
            this.labelRestartWarning.TabIndex = 70;
            this.labelRestartWarning.Text = gStr.gsRestartWarning + "\r\n";
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
            this.btnSerialCancel.Location = new System.Drawing.Point(363, 332);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(88, 76);
            this.btnSerialCancel.TabIndex = 71;
            this.btnSerialCancel.UseVisualStyleBackColor = true;
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.FlatAppearance.BorderSize = 0;
            this.btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::AgIO.Properties.Resources.OK64;
            this.btnSerialOK.Location = new System.Drawing.Point(476, 330);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(102, 76);
            this.btnSerialOK.TabIndex = 70;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // labelModulePortActual
            // 
            this.labelModulePortActual.AutoSize = true;
            this.labelModulePortActual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModulePortActual.Location = new System.Drawing.Point(179, 150);
            this.labelModulePortActual.Name = "labelModulePortActual";
            this.labelModulePortActual.Size = new System.Drawing.Size(45, 19);
            this.labelModulePortActual.TabIndex = 84;
            this.labelModulePortActual.Text = "8888";
            // 
            // labelModulePort
            // 
            this.labelModulePort.AutoSize = true;
            this.labelModulePort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModulePort.Location = new System.Drawing.Point(8, 38);
            this.labelModulePort.Name = "labelModulePort";
            this.labelModulePort.Size = new System.Drawing.Size(110, 23);
            this.labelModulePort.TabIndex = 83;
            this.labelModulePort.Text =gStr.gsModulePort;
            // 
            // labelModIp
            // 
            this.labelModIp.AutoSize = true;
            this.labelModIp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModIp.Location = new System.Drawing.Point(30, 99);
            this.labelModIp.Name = "labelModIp";
            this.labelModIp.Size = new System.Drawing.Size(27, 23);
            this.labelModIp.TabIndex = 82;
            this.labelModIp.Text = "IP";
            // 
            // labelModPort
            // 
            this.labelModPort.AutoSize = true;
            this.labelModPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModPort.Location = new System.Drawing.Point(15, 148);
            this.labelModPort.Name = "labelModPort";
            this.labelModPort.Size = new System.Drawing.Size(43, 23);
            this.labelModPort.TabIndex = 81;
            this.labelModPort.Text = "Port";
            // 
            // nudAutoSteerPort
            // 
            this.nudAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAutoSteerPort.Location = new System.Drawing.Point(70, 143);
            this.nudAutoSteerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAutoSteerPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudAutoSteerPort.Name = "nudAutoSteerPort";
            this.nudAutoSteerPort.Size = new System.Drawing.Size(96, 30);
            this.nudAutoSteerPort.TabIndex = 80;
            this.nudAutoSteerPort.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            // 
            // tboxAutoSteerIP
            // 
            this.tboxAutoSteerIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAutoSteerIP.Location = new System.Drawing.Point(70, 95);
            this.tboxAutoSteerIP.Name = "tboxAutoSteerIP";
            this.tboxAutoSteerIP.Size = new System.Drawing.Size(167, 30);
            this.tboxAutoSteerIP.TabIndex = 79;
            this.tboxAutoSteerIP.Text = "192.168.1.255";
            this.tboxAutoSteerIP.Click += new System.EventHandler(this.tboxAutoSteerIP_Click);
            this.tboxAutoSteerIP.Validating += new System.ComponentModel.CancelEventHandler(this.tboxAutoSteerIP_Validating);
            // 
            // groupBoxModule
            // 
            this.groupBoxModule.Controls.Add(this.labelModuleUseInfo);
            this.groupBoxModule.Controls.Add(this.tboxAutoSteerIP);
            this.groupBoxModule.Controls.Add(this.nudAutoSteerPort);
            this.groupBoxModule.Controls.Add(this.labelModPort);
            this.groupBoxModule.Controls.Add(this.labelModIp);
            this.groupBoxModule.Controls.Add(this.labelModulePort);
            this.groupBoxModule.Controls.Add(this.labelModulePortActual);
            this.groupBoxModule.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModule.Location = new System.Drawing.Point(318, 62);
            this.groupBoxModule.Name = "groupBoxModule";
            this.groupBoxModule.Size = new System.Drawing.Size(257, 232);
            this.groupBoxModule.TabIndex = 91;
            this.groupBoxModule.TabStop = false;
            this.groupBoxModule.Text =gStr.gsModuleAddress;
            // 
            // labelModuleUseInfo
            // 
            this.labelModuleUseInfo.AutoSize = true;
            this.labelModuleUseInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModuleUseInfo.Location = new System.Drawing.Point(30, 203);
            this.labelModuleUseInfo.Name = "labelModuleUseInfo";
            this.labelModuleUseInfo.Size = new System.Drawing.Size(192, 23);
            this.labelModuleUseInfo.TabIndex = 94;
            this.labelModuleUseInfo.Text =gStr.gsModuleUseInfo;
            // 
            // cboxIsUDPOn
            // 
            this.cboxIsUDPOn.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboxIsUDPOn.AutoSize = true;
            this.cboxIsUDPOn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxIsUDPOn.Checked = true;
            this.cboxIsUDPOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxIsUDPOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.cboxIsUDPOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxIsUDPOn.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxIsUDPOn.Location = new System.Drawing.Point(107, 37);
            this.cboxIsUDPOn.Name = "cboxIsUDPOn";
            this.cboxIsUDPOn.Size = new System.Drawing.Size(126, 45);
            this.cboxIsUDPOn.TabIndex = 92;
            this.cboxIsUDPOn.Text = gStr.gsUDPOn;
            this.cboxIsUDPOn.UseVisualStyleBackColor = true;
            // 
            // groupBoxNetworking
            // 
            this.groupBoxNetworking.Controls.Add(this.cboxIsUDPOn);
            this.groupBoxNetworking.Location = new System.Drawing.Point(18, 306);
            this.groupBoxNetworking.Name = "groupBoxNetworking";
            this.groupBoxNetworking.Size = new System.Drawing.Size(257, 100);
            this.groupBoxNetworking.TabIndex = 93;
            this.groupBoxNetworking.TabStop = false;
            this.groupBoxNetworking.Text = gStr.gsNetworking;
            // 
            // FormUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 417);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxNetworking);
            this.Controls.Add(this.groupBoxModule);
            this.Controls.Add(this.labelRestartWarning);
            this.Controls.Add(this.groupBoxDriveServer);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.btnSerialOK);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUDP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = gStr.gsUDPEthernetConfig;
            this.Load += new System.EventHandler(this.FormUDp_Load);
            this.groupBoxDriveServer.ResumeLayout(false);
            this.groupBoxDriveServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThisPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSteerPort)).EndInit();
            this.groupBoxModule.ResumeLayout(false);
            this.groupBoxModule.PerformLayout();
            this.groupBoxNetworking.ResumeLayout(false);
            this.groupBoxNetworking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDriveServer;
        private System.Windows.Forms.Label labelRestartWarning;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Label labelModulePortActual;
        private System.Windows.Forms.Label labelModulePort;
        private System.Windows.Forms.Label labelModIp;
        private System.Windows.Forms.Label labelModPort;
        private System.Windows.Forms.NumericUpDown nudAutoSteerPort;
        private System.Windows.Forms.TextBox tboxAutoSteerIP;
        private System.Windows.Forms.GroupBox groupBoxModule;
        private System.Windows.Forms.TextBox tboxThisIP;
        private System.Windows.Forms.NumericUpDown nudThisPort;
        private System.Windows.Forms.Label labelHostPort;
        private System.Windows.Forms.Label labelHostIP;
        private System.Windows.Forms.Label labelServerPortActual;
        private System.Windows.Forms.Label labelThisComputer;
        private System.Windows.Forms.TextBox tboxHostName;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.CheckBox cboxIsUDPOn;
        private System.Windows.Forms.GroupBox groupBoxNetworking;
        private System.Windows.Forms.Label labelModuleSendInfo;
        private System.Windows.Forms.Label labelModuleUseInfo;
    }
}