namespace Brayn
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.ka_Bilgi = new System.Windows.Forms.Label();
            this.ka_TBOX = new System.Windows.Forms.TextBox();
            this.pass_TBOX = new System.Windows.Forms.TextBox();
            this.pass_bilgi = new System.Windows.Forms.Label();
            this.login_BTN = new System.Windows.Forms.Button();
            this.hata_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ka_Bilgi
            // 
            this.ka_Bilgi.AutoSize = true;
            this.ka_Bilgi.BackColor = System.Drawing.Color.Transparent;
            this.ka_Bilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.ka_Bilgi.Location = new System.Drawing.Point(78, 212);
            this.ka_Bilgi.Name = "ka_Bilgi";
            this.ka_Bilgi.Size = new System.Drawing.Size(79, 16);
            this.ka_Bilgi.TabIndex = 0;
            this.ka_Bilgi.Text = "Kullanıcı Adi";
            // 
            // ka_TBOX
            // 
            this.ka_TBOX.Location = new System.Drawing.Point(81, 231);
            this.ka_TBOX.Name = "ka_TBOX";
            this.ka_TBOX.Size = new System.Drawing.Size(221, 22);
            this.ka_TBOX.TabIndex = 1;
            // 
            // pass_TBOX
            // 
            this.pass_TBOX.Location = new System.Drawing.Point(81, 290);
            this.pass_TBOX.Name = "pass_TBOX";
            this.pass_TBOX.Size = new System.Drawing.Size(221, 22);
            this.pass_TBOX.TabIndex = 2;
            // 
            // pass_bilgi
            // 
            this.pass_bilgi.AutoSize = true;
            this.pass_bilgi.BackColor = System.Drawing.Color.Transparent;
            this.pass_bilgi.ForeColor = System.Drawing.SystemColors.Control;
            this.pass_bilgi.Location = new System.Drawing.Point(78, 271);
            this.pass_bilgi.Name = "pass_bilgi";
            this.pass_bilgi.Size = new System.Drawing.Size(34, 16);
            this.pass_bilgi.TabIndex = 3;
            this.pass_bilgi.Text = "Şifre";
            // 
            // login_BTN
            // 
            this.login_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_BTN.Location = new System.Drawing.Point(211, 350);
            this.login_BTN.Name = "login_BTN";
            this.login_BTN.Size = new System.Drawing.Size(90, 38);
            this.login_BTN.TabIndex = 4;
            this.login_BTN.Text = "Giriş";
            this.login_BTN.UseVisualStyleBackColor = true;
            this.login_BTN.Click += new System.EventHandler(this.login_BTN_Click);
            // 
            // hata_msg
            // 
            this.hata_msg.BackColor = System.Drawing.Color.Transparent;
            this.hata_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hata_msg.Location = new System.Drawing.Point(12, 407);
            this.hata_msg.Name = "hata_msg";
            this.hata_msg.Size = new System.Drawing.Size(358, 52);
            this.hata_msg.TabIndex = 5;
            this.hata_msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brayn.Properties.Resources.girişBackraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 468);
            this.Controls.Add(this.hata_msg);
            this.Controls.Add(this.login_BTN);
            this.Controls.Add(this.pass_bilgi);
            this.Controls.Add(this.pass_TBOX);
            this.Controls.Add(this.ka_TBOX);
            this.Controls.Add(this.ka_Bilgi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brayn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ka_Bilgi;
        private System.Windows.Forms.TextBox ka_TBOX;
        private System.Windows.Forms.TextBox pass_TBOX;
        private System.Windows.Forms.Label pass_bilgi;
        private System.Windows.Forms.Button login_BTN;
        private System.Windows.Forms.Label hata_msg;
    }
}

