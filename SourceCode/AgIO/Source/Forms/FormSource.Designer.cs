﻿namespace AgIO
{
    partial class FormSource
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
            this.lvLines = new System.Windows.Forms.ListView();
            this.chDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNetwork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tboxMount = new System.Windows.Forms.TextBox();
            this.lblCurrentAutoSteerPort = new System.Windows.Forms.Label();
            this.btnSite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUseMount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLines
            // 
            this.lvLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLines.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDistance,
            this.chName,
            this.chLat,
            this.chLon,
            this.chFormat,
            this.chNetwork});
            this.lvLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLines.FullRowSelect = true;
            this.lvLines.GridLines = true;
            this.lvLines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLines.HideSelection = false;
            this.lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvLines.LabelWrap = false;
            this.lvLines.Location = new System.Drawing.Point(3, 3);
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Size = new System.Drawing.Size(1005, 525);
            this.lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvLines.TabIndex = 97;
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Details;
            this.lvLines.SelectedIndexChanged += new System.EventHandler(this.lvLines_SelectedIndexChanged);
            // 
            // chDistance
            // 
            this.chDistance.Text = gStr.gsDistance;
            this.chDistance.Width = 150;
            // 
            // chName
            // 
            this.chName.Text = gStr.gsMountPoint;
            this.chName.Width = 250;
            // 
            // chLat
            // 
            this.chLat.Text = "Lat";
            this.chLat.Width = 100;
            // 
            // chLon
            // 
            this.chLon.Text = "Lon";
            this.chLon.Width = 100;
            // 
            // chFormat
            // 
            this.chFormat.Text =gStr.gsFormat;
            this.chFormat.Width = 150;
            // 
            // chNetwork
            // 
            this.chNetwork.Text =gStr.gsNetwork;
            this.chNetwork.Width = 220;
            // 
            // tboxMount
            // 
            this.tboxMount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxMount.BackColor = System.Drawing.SystemColors.Window;
            this.tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMount.Location = new System.Drawing.Point(131, 554);
            this.tboxMount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxMount.Name = "tboxMount";
            this.tboxMount.ReadOnly = true;
            this.tboxMount.Size = new System.Drawing.Size(244, 33);
            this.tboxMount.TabIndex = 98;
            // 
            // lblCurrentAutoSteerPort
            // 
            this.lblCurrentAutoSteerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentAutoSteerPort.AutoSize = true;
            this.lblCurrentAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAutoSteerPort.Location = new System.Drawing.Point(67, 561);
            this.lblCurrentAutoSteerPort.Name = "lblCurrentAutoSteerPort";
            this.lblCurrentAutoSteerPort.Size = new System.Drawing.Size(59, 18);
            this.lblCurrentAutoSteerPort.TabIndex = 99;
            this.lblCurrentAutoSteerPort.Text = "Mount:";
            this.lblCurrentAutoSteerPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSite
            // 
            this.btnSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSite.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSite.Location = new System.Drawing.Point(646, 538);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(157, 64);
            this.btnSite.TabIndex = 100;
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = global::AgIO.Properties.Resources.Cancel64;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(851, 538);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 64);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // btnUseMount
            // 
            this.btnUseMount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseMount.BackgroundImage = global::AgIO.Properties.Resources.OK64;
            this.btnUseMount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUseMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUseMount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseMount.Location = new System.Drawing.Point(390, 538);
            this.btnUseMount.Name = "btnUseMount";
            this.btnUseMount.Size = new System.Drawing.Size(157, 64);
            this.btnUseMount.TabIndex = 100;
            this.btnUseMount.UseVisualStyleBackColor = true;
            this.btnUseMount.Click += new System.EventHandler(this.btnUseMount_Click);
            // 
            // FormSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUseMount);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.lblCurrentAutoSteerPort);
            this.Controls.Add(this.tboxMount);
            this.Controls.Add(this.lvLines);
            this.Name = "FormSource";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text =gStr.gsSourceData;
            this.Load += new System.EventHandler(this.FormSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLat;
        private System.Windows.Forms.ColumnHeader chLon;
        private System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Label lblCurrentAutoSteerPort;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.ColumnHeader chFormat;
        private System.Windows.Forms.ColumnHeader chNetwork;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUseMount;
    }
}