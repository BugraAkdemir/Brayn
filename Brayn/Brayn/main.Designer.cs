namespace Brayn
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.hspBTN = new System.Windows.Forms.Button();
            this.QrCodeBTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.instagramLinkLabel = new System.Windows.Forms.LinkLabel();
            this.githubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hspBTN
            // 
            this.hspBTN.BackColor = System.Drawing.Color.White;
            this.hspBTN.Location = new System.Drawing.Point(779, 167);
            this.hspBTN.Name = "hspBTN";
            this.hspBTN.Size = new System.Drawing.Size(121, 37);
            this.hspBTN.TabIndex = 0;
            this.hspBTN.Text = "Hesap Makinası";
            this.hspBTN.UseVisualStyleBackColor = false;
            this.hspBTN.Click += new System.EventHandler(this.hspBTN_Click);
            // 
            // QrCodeBTN
            // 
            this.QrCodeBTN.BackColor = System.Drawing.Color.White;
            this.QrCodeBTN.Location = new System.Drawing.Point(779, 217);
            this.QrCodeBTN.Name = "QrCodeBTN";
            this.QrCodeBTN.Size = new System.Drawing.Size(121, 46);
            this.QrCodeBTN.TabIndex = 1;
            this.QrCodeBTN.Text = "QR Code \r\nOluşturucu";
            this.QrCodeBTN.UseVisualStyleBackColor = false;
            this.QrCodeBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(780, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Yakında.....";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(779, 326);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 37);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // instagramLinkLabel
            // 
            this.instagramLinkLabel.AutoSize = true;
            this.instagramLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.instagramLinkLabel.LinkColor = System.Drawing.Color.White;
            this.instagramLinkLabel.Location = new System.Drawing.Point(59, 280);
            this.instagramLinkLabel.Name = "instagramLinkLabel";
            this.instagramLinkLabel.Size = new System.Drawing.Size(66, 16);
            this.instagramLinkLabel.TabIndex = 4;
            this.instagramLinkLabel.TabStop = true;
            this.instagramLinkLabel.Text = "Instagram";
            this.instagramLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // githubLinkLabel
            // 
            this.githubLinkLabel.AutoSize = true;
            this.githubLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.githubLinkLabel.LinkColor = System.Drawing.Color.White;
            this.githubLinkLabel.Location = new System.Drawing.Point(60, 318);
            this.githubLinkLabel.Name = "githubLinkLabel";
            this.githubLinkLabel.Size = new System.Drawing.Size(51, 16);
            this.githubLinkLabel.TabIndex = 5;
            this.githubLinkLabel.TabStop = true;
            this.githubLinkLabel.Text = "Git Hub";
            this.githubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.versionLabel.Location = new System.Drawing.Point(70, 440);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 16);
            this.versionLabel.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brayn.Properties.Resources.mainBackraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 478);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.githubLinkLabel);
            this.Controls.Add(this.instagramLinkLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.QrCodeBTN);
            this.Controls.Add(this.hspBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brayn - Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hspBTN;
        private System.Windows.Forms.Button QrCodeBTN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel instagramLinkLabel;
        private System.Windows.Forms.LinkLabel githubLinkLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}