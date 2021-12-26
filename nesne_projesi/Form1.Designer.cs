
namespace nesne_projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.BtnKayitOl = new System.Windows.Forms.Button();
            this.TxtSifreGiris = new System.Windows.Forms.TextBox();
            this.TxtMailGiris = new System.Windows.Forms.TextBox();
            this.LblSifre = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.BtnGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGirisYap.BackgroundImage")));
            this.BtnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGirisYap.Location = new System.Drawing.Point(329, 590);
            this.BtnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(180, 64);
            this.BtnGirisYap.TabIndex = 12;
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click_1);
            // 
            // BtnKayitOl
            // 
            this.BtnKayitOl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(209)))), ((int)(((byte)(207)))));
            this.BtnKayitOl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnKayitOl.BackgroundImage")));
            this.BtnKayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKayitOl.Location = new System.Drawing.Point(116, 590);
            this.BtnKayitOl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnKayitOl.Name = "BtnKayitOl";
            this.BtnKayitOl.Size = new System.Drawing.Size(180, 64);
            this.BtnKayitOl.TabIndex = 11;
            this.BtnKayitOl.UseVisualStyleBackColor = false;
            this.BtnKayitOl.Click += new System.EventHandler(this.BtnKayitOl_Click);
            // 
            // TxtSifreGiris
            // 
            this.TxtSifreGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtSifreGiris.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifreGiris.Location = new System.Drawing.Point(227, 528);
            this.TxtSifreGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSifreGiris.Name = "TxtSifreGiris";
            this.TxtSifreGiris.Size = new System.Drawing.Size(271, 39);
            this.TxtSifreGiris.TabIndex = 10;
            // 
            // TxtMailGiris
            // 
            this.TxtMailGiris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtMailGiris.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMailGiris.Location = new System.Drawing.Point(227, 471);
            this.TxtMailGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMailGiris.Name = "TxtMailGiris";
            this.TxtMailGiris.Size = new System.Drawing.Size(271, 39);
            this.TxtMailGiris.TabIndex = 9;
            // 
            // LblSifre
            // 
            this.LblSifre.AutoSize = true;
            this.LblSifre.BackColor = System.Drawing.Color.Transparent;
            this.LblSifre.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblSifre.Location = new System.Drawing.Point(105, 513);
            this.LblSifre.Name = "LblSifre";
            this.LblSifre.Size = new System.Drawing.Size(102, 57);
            this.LblSifre.TabIndex = 8;
            this.LblSifre.Text = "Şifre";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.BackColor = System.Drawing.Color.Transparent;
            this.LblMail.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMail.Location = new System.Drawing.Point(113, 455);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(94, 57);
            this.LblMail.TabIndex = 7;
            this.LblMail.Text = "Mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 805);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.BtnKayitOl);
            this.Controls.Add(this.TxtSifreGiris);
            this.Controls.Add(this.TxtMailGiris);
            this.Controls.Add(this.LblSifre);
            this.Controls.Add(this.LblMail);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "baby krafty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Button BtnKayitOl;
        private System.Windows.Forms.TextBox TxtSifreGiris;
        private System.Windows.Forms.TextBox TxtMailGiris;
        private System.Windows.Forms.Label LblSifre;
        private System.Windows.Forms.Label LblMail;
    }
}

