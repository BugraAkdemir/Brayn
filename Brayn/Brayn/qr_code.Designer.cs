namespace Brayn
{
    partial class qr_code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qr_code));
            this.label1 = new System.Windows.Forms.Label();
            this.linkText = new System.Windows.Forms.TextBox();
            this.olusturBTN = new System.Windows.Forms.Button();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.sunucLBL = new System.Windows.Forms.Label();
            this.anasayfaBtN = new System.Windows.Forms.Button();
            this.cıkısBTn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link Gir";
            // 
            // linkText
            // 
            this.linkText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(115)))));
            this.linkText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkText.ForeColor = System.Drawing.Color.White;
            this.linkText.Location = new System.Drawing.Point(36, 94);
            this.linkText.Name = "linkText";
            this.linkText.Size = new System.Drawing.Size(271, 22);
            this.linkText.TabIndex = 1;
            // 
            // olusturBTN
            // 
            this.olusturBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(115)))));
            this.olusturBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.olusturBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.olusturBTN.ForeColor = System.Drawing.Color.White;
            this.olusturBTN.Location = new System.Drawing.Point(101, 131);
            this.olusturBTN.Name = "olusturBTN";
            this.olusturBTN.Size = new System.Drawing.Size(112, 46);
            this.olusturBTN.TabIndex = 2;
            this.olusturBTN.Text = "Oluştur";
            this.olusturBTN.UseVisualStyleBackColor = false;
            this.olusturBTN.Click += new System.EventHandler(this.olusturBTN_Click);
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(36, 238);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(271, 281);
            this.qrBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrBox.TabIndex = 3;
            this.qrBox.TabStop = false;
            // 
            // sunucLBL
            // 
            this.sunucLBL.BackColor = System.Drawing.Color.Transparent;
            this.sunucLBL.ForeColor = System.Drawing.Color.Transparent;
            this.sunucLBL.Location = new System.Drawing.Point(33, 212);
            this.sunucLBL.Name = "sunucLBL";
            this.sunucLBL.Size = new System.Drawing.Size(159, 23);
            this.sunucLBL.TabIndex = 4;
            this.sunucLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // anasayfaBtN
            // 
            this.anasayfaBtN.Location = new System.Drawing.Point(12, 12);
            this.anasayfaBtN.Name = "anasayfaBtN";
            this.anasayfaBtN.Size = new System.Drawing.Size(93, 29);
            this.anasayfaBtN.TabIndex = 5;
            this.anasayfaBtN.Text = "Ana Sayfa";
            this.anasayfaBtN.UseVisualStyleBackColor = true;
            this.anasayfaBtN.Click += new System.EventHandler(this.anasayfaBtN_Click);
            // 
            // cıkısBTn
            // 
            this.cıkısBTn.Location = new System.Drawing.Point(111, 12);
            this.cıkısBTn.Name = "cıkısBTn";
            this.cıkısBTn.Size = new System.Drawing.Size(93, 29);
            this.cıkısBTn.TabIndex = 6;
            this.cıkısBTn.Text = "Çıkış";
            this.cıkısBTn.UseVisualStyleBackColor = true;
            this.cıkısBTn.Click += new System.EventHandler(this.cıkısBTn_Click);
            // 
            // qr_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brayn.Properties.Resources.Adsız_tasarım;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 559);
            this.Controls.Add(this.cıkısBTn);
            this.Controls.Add(this.anasayfaBtN);
            this.Controls.Add(this.sunucLBL);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.olusturBTN);
            this.Controls.Add(this.linkText);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "qr_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brayn - QR Oluşturucu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.qr_code_FormClosed);
            this.Load += new System.EventHandler(this.qr_code_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linkText;
        private System.Windows.Forms.Button olusturBTN;
        private System.Windows.Forms.PictureBox qrBox;
        private System.Windows.Forms.Label sunucLBL;
        private System.Windows.Forms.Button anasayfaBtN;
        private System.Windows.Forms.Button cıkısBTn;
    }
}