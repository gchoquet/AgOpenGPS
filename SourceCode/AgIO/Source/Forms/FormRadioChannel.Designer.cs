﻿
namespace AgIO
{
    partial class FormRadioChannel
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
            this.labelName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.labelLat = new System.Windows.Forms.Label();
            this.tbLat = new System.Windows.Forms.TextBox();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.tbLon = new System.Windows.Forms.TextBox();
            this.labelLon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = gStr.gsName;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(98, 48);
            this.tbName.MinimumSize = new System.Drawing.Size(244, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(244, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Click += new System.EventHandler(this.tbox_Click);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(7, 87);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(57, 13);
            this.labelFrequency.TabIndex = 8;
            this.labelFrequency.Text =gStr.gsFrequency;
            // 
            // tbFrequency
            // 
            this.tbFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrequency.Location = new System.Drawing.Point(98, 84);
            this.tbFrequency.MinimumSize = new System.Drawing.Size(244, 20);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(244, 20);
            this.tbFrequency.TabIndex = 2;
            this.tbFrequency.Click += new System.EventHandler(this.tbox_Click);
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(7, 125);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(45, 13);
            this.labelLat.TabIndex = 9;
            this.labelLat.Text = gStr.gsLongitude;
            // 
            // tbLat
            // 
            this.tbLat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLat.Location = new System.Drawing.Point(98, 122);
            this.tbLat.MinimumSize = new System.Drawing.Size(244, 20);
            this.tbLat.Name = "tbLat";
            this.tbLat.Size = new System.Drawing.Size(244, 20);
            this.tbLat.TabIndex = 3;
            this.tbLat.Click += new System.EventHandler(this.tbox_Click);
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
            this.btnSerialCancel.Location = new System.Drawing.Point(168, 195);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(88, 76);
            this.btnSerialCancel.TabIndex = 5;
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
            this.btnSerialOK.Location = new System.Drawing.Point(262, 195);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(102, 76);
            this.btnSerialOK.TabIndex = 4;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = true;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // tbId
            // 
            this.tbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbId.Location = new System.Drawing.Point(98, 12);
            this.tbId.MinimumSize = new System.Drawing.Size(244, 20);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(244, 20);
            this.tbId.TabIndex = 0;
            this.tbId.Click += new System.EventHandler(this.tbox_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(7, 15);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "Id";
            // 
            // tbLon
            // 
            this.tbLon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLon.Location = new System.Drawing.Point(98, 158);
            this.tbLon.MinimumSize = new System.Drawing.Size(244, 20);
            this.tbLon.Name = "tbLon";
            this.tbLon.Size = new System.Drawing.Size(244, 20);
            this.tbLon.TabIndex = 10;
            // 
            // labelLon
            // 
            this.labelLon.AutoSize = true;
            this.labelLon.Location = new System.Drawing.Point(7, 161);
            this.labelLon.Name = "labelLon";
            this.labelLon.Size = new System.Drawing.Size(54, 13);
            this.labelLon.TabIndex = 11;
            this.labelLon.Text = gStr.gsLongitude;
            // 
            // FormRadioChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 282);
            this.ControlBox = false;
            this.Controls.Add(this.tbLon);
            this.Controls.Add(this.labelLon);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.tbLat);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.labelName);
            this.MinimumSize = new System.Drawing.Size(16, 240);
            this.Name = "FormRadioChannel";
            this.ShowIcon = false;
            this.Text =gStr.gsRadioChannel;
            this.Load += new System.EventHandler(this.FormRadioChannel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.TextBox tbLat;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox tbLon;
        private System.Windows.Forms.Label labelLon;
    }
}