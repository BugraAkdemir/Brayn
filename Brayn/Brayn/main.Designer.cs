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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hspBTN
            // 
            this.hspBTN.BackColor = System.Drawing.Color.White;
            this.hspBTN.Location = new System.Drawing.Point(779, 220);
            this.hspBTN.Name = "hspBTN";
            this.hspBTN.Size = new System.Drawing.Size(121, 37);
            this.hspBTN.TabIndex = 0;
            this.hspBTN.Text = "Hesap Makinası";
            this.hspBTN.UseVisualStyleBackColor = false;
            this.hspBTN.Click += new System.EventHandler(this.hspBTN_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(779, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Yakinda...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(779, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 37);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(779, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 37);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Brayn.Properties.Resources.mainBackraund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 478);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.hspBTN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Brayn - Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hspBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}