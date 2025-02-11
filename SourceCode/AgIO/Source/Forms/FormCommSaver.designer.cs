﻿namespace AgIO
{
    partial class FormCommSaver
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
            this.cboxEnv = new System.Windows.Forms.ComboBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelEnterName = new System.Windows.Forms.Label();
            this.labelSaveAs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxEnv
            // 
            this.cboxEnv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxEnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEnv.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEnv.FormattingEnabled = true;
            this.cboxEnv.Location = new System.Drawing.Point(12, 81);
            this.cboxEnv.Name = "cboxEnv";
            this.cboxEnv.Size = new System.Drawing.Size(548, 43);
            this.cboxEnv.TabIndex = 212;
            this.cboxEnv.SelectedIndexChanged += new System.EventHandler(this.cboxVeh_SelectedIndexChanged);
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLast.Location = new System.Drawing.Point(15, 9);
            this.lblLast.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(307, 23);
            this.lblLast.TabIndex = 213;
            this.lblLast.Text = gStr.gsCommunicationsConfig;
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxName
            // 
            this.tboxName.BackColor = System.Drawing.SystemColors.Control;
            this.tboxName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxName.Location = new System.Drawing.Point(19, 202);
            this.tboxName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(373, 36);
            this.tboxName.TabIndex = 214;
            this.tboxName.Click += new System.EventHandler(this.tboxName_Click);
            this.tboxName.TextChanged += new System.EventHandler(this.tboxName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnSave.Image = global::AgIO.Properties.Resources.VehFileSave;
            this.btnSave.Location = new System.Drawing.Point(433, 173);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 71);
            this.btnSave.TabIndex = 215;
            this.btnSave.UseVisualStyleBackColor = true;
            
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelEnterName
            // 
            this.labelEnterName.AutoSize = true;
            this.labelEnterName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterName.Location = new System.Drawing.Point(15, 173);
            this.labelEnterName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEnterName.Name = "labelEnterName";
            this.labelEnterName.Size = new System.Drawing.Size(178, 23);
            this.labelEnterName.TabIndex = 216;
            this.labelEnterName.Text = gStr.gsEnterNewName;
            this.labelEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSaveAs
            // 
            this.labelSaveAs.AutoSize = true;
            this.labelSaveAs.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaveAs.Location = new System.Drawing.Point(15, 55);
            this.labelSaveAs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSaveAs.Name = "labelSaveAs";
            this.labelSaveAs.Size = new System.Drawing.Size(91, 23);
            this.labelSaveAs.TabIndex = 217;
            this.labelSaveAs.Text = gStr.gsSaveAs;
            this.labelSaveAs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCommSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 250);
            this.Controls.Add(this.labelSaveAs);
            this.Controls.Add(this.labelEnterName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.cboxEnv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormCommSaver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = gStr.gsSaveComs;
            this.Load += new System.EventHandler(this.FormCommSaver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxEnv;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelEnterName;
        private System.Windows.Forms.Label labelSaveAs;
    }
}