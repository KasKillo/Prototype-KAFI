namespace PrototypeFixer
{
    partial class Prototype1Kafi
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
            this.SelectDirectoryBTN = new System.Windows.Forms.Button();
            this.LowFpsFixButton = new System.Windows.Forms.Button();
            this.GameDirectoryLabel = new System.Windows.Forms.Label();
            this.DownloadFixesBTN = new System.Windows.Forms.Button();
            this.BackgroundImage = new System.Windows.Forms.PictureBox();
            this.CrashFixBTN = new System.Windows.Forms.Button();
            this.creatorLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectDirectoryBTN
            // 
            this.SelectDirectoryBTN.Location = new System.Drawing.Point(12, 452);
            this.SelectDirectoryBTN.Name = "SelectDirectoryBTN";
            this.SelectDirectoryBTN.Size = new System.Drawing.Size(102, 40);
            this.SelectDirectoryBTN.TabIndex = 0;
            this.SelectDirectoryBTN.Text = "Select Directory";
            this.SelectDirectoryBTN.UseVisualStyleBackColor = true;
            this.SelectDirectoryBTN.Click += new System.EventHandler(this.GDButton_Click);
            // 
            // LowFpsFixButton
            // 
            this.LowFpsFixButton.Location = new System.Drawing.Point(12, 406);
            this.LowFpsFixButton.Name = "LowFpsFixButton";
            this.LowFpsFixButton.Size = new System.Drawing.Size(102, 40);
            this.LowFpsFixButton.TabIndex = 1;
            this.LowFpsFixButton.Text = "Low Fps Fix";
            this.LowFpsFixButton.UseVisualStyleBackColor = true;
            this.LowFpsFixButton.Click += new System.EventHandler(this.LowFpsFixButton_Click);
            // 
            // GameDirectoryLabel
            // 
            this.GameDirectoryLabel.AutoSize = true;
            this.GameDirectoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameDirectoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameDirectoryLabel.ForeColor = System.Drawing.Color.Red;
            this.GameDirectoryLabel.Location = new System.Drawing.Point(7, 9);
            this.GameDirectoryLabel.Name = "GameDirectoryLabel";
            this.GameDirectoryLabel.Size = new System.Drawing.Size(288, 29);
            this.GameDirectoryLabel.TabIndex = 2;
            this.GameDirectoryLabel.Text = "Game Directory Not Set";
            // 
            // DownloadFixesBTN
            // 
            this.DownloadFixesBTN.Location = new System.Drawing.Point(120, 452);
            this.DownloadFixesBTN.Name = "DownloadFixesBTN";
            this.DownloadFixesBTN.Size = new System.Drawing.Size(102, 40);
            this.DownloadFixesBTN.TabIndex = 3;
            this.DownloadFixesBTN.Text = "Download Fixes";
            this.DownloadFixesBTN.UseVisualStyleBackColor = true;
            this.DownloadFixesBTN.Click += new System.EventHandler(this.DownloadFixesBTN_Click);
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage.Image = global::PrototypeFixer.Properties.Resources.alex_mercer_4k_hd_prototype_2560x1440_2290782404;
            this.BackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(821, 501);
            this.BackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundImage.TabIndex = 5;
            this.BackgroundImage.TabStop = false;
            this.BackgroundImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CrashFixBTN
            // 
            this.CrashFixBTN.Location = new System.Drawing.Point(120, 406);
            this.CrashFixBTN.Name = "CrashFixBTN";
            this.CrashFixBTN.Size = new System.Drawing.Size(102, 40);
            this.CrashFixBTN.TabIndex = 6;
            this.CrashFixBTN.Text = "Crash + Fov Fix";
            this.CrashFixBTN.UseVisualStyleBackColor = true;
            this.CrashFixBTN.Click += new System.EventHandler(this.CrashFixBTN_Click);
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.creatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorLabel.LinkColor = System.Drawing.Color.Black;
            this.creatorLabel.Location = new System.Drawing.Point(585, 9);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(222, 31);
            this.creatorLabel.TabIndex = 7;
            this.creatorLabel.TabStop = true;
            this.creatorLabel.Text = "Made by KasKillo";
            this.creatorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creatorLabel_LinkClicked);
            // 
            // Prototype1Kafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 498);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.CrashFixBTN);
            this.Controls.Add(this.DownloadFixesBTN);
            this.Controls.Add(this.GameDirectoryLabel);
            this.Controls.Add(this.LowFpsFixButton);
            this.Controls.Add(this.SelectDirectoryBTN);
            this.Controls.Add(this.BackgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Prototype1Kafi";
            this.Text = "Prototype 1 KAFI";
            this.Load += new System.EventHandler(this.Prototype1Kafi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectDirectoryBTN;
        private System.Windows.Forms.Button LowFpsFixButton;
        private System.Windows.Forms.Label GameDirectoryLabel;
        private System.Windows.Forms.Button DownloadFixesBTN;
        private System.Windows.Forms.PictureBox BackgroundImage;
        private System.Windows.Forms.Button CrashFixBTN;
        private System.Windows.Forms.LinkLabel creatorLabel;
    }
}

