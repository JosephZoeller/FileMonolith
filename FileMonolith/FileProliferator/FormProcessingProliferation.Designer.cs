﻿namespace FileProliferator
{
    partial class FormProcessingProliferation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcessingProliferation));
            this.pictureSpiral = new System.Windows.Forms.PictureBox();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.labelProliferate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpiral)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSpiral
            // 
            this.pictureSpiral.Image = ((System.Drawing.Image)(resources.GetObject("pictureSpiral.Image")));
            this.pictureSpiral.Location = new System.Drawing.Point(12, 8);
            this.pictureSpiral.Name = "pictureSpiral";
            this.pictureSpiral.Size = new System.Drawing.Size(36, 35);
            this.pictureSpiral.TabIndex = 5;
            this.pictureSpiral.TabStop = false;
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.Location = new System.Drawing.Point(12, 46);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(306, 43);
            this.labelCurrentFile.TabIndex = 4;
            this.labelCurrentFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProliferate
            // 
            this.labelProliferate.Location = new System.Drawing.Point(12, 8);
            this.labelProliferate.Name = "labelProliferate";
            this.labelProliferate.Size = new System.Drawing.Size(306, 23);
            this.labelProliferate.TabIndex = 3;
            this.labelProliferate.Text = "Building, please wait...";
            this.labelProliferate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProcessingProliferation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 94);
            this.ControlBox = false;
            this.Controls.Add(this.pictureSpiral);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.labelProliferate);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProcessingProliferation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Processing...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpiral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSpiral;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.Label labelProliferate;
    }
}