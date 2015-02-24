namespace eDownloader
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
            this.barProgress = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // barProgress
            // 
            this.barProgress.Location = new System.Drawing.Point(46, 110);
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(326, 23);
            this.barProgress.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(378, 84);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 49);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(46, 84);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(326, 20);
            this.txtLink.TabIndex = 2;
            this.txtLink.Text = "https://wordpress.org/latest.zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 217);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.barProgress);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barProgress;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.SaveFileDialog sfDialog;
    }
}

