
namespace nesne_projesi
{
    partial class Credit
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
            this.creditNumber = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.cvc = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditNumber
            // 
            this.creditNumber.Location = new System.Drawing.Point(12, 36);
            this.creditNumber.Name = "creditNumber";
            this.creditNumber.Size = new System.Drawing.Size(211, 20);
            this.creditNumber.TabIndex = 0;
            this.creditNumber.Text = "Kart Numarası";
            this.creditNumber.Click += new System.EventHandler(this.creditNumber_Click);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(12, 100);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(100, 20);
            this.exp.TabIndex = 1;
            this.exp.Text = "Son Kullanım Tarihi";
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // cvc
            // 
            this.cvc.Location = new System.Drawing.Point(160, 99);
            this.cvc.Name = "cvc";
            this.cvc.Size = new System.Drawing.Size(63, 20);
            this.cvc.TabIndex = 2;
            this.cvc.Text = "CvC ";
            this.cvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cvc.Click += new System.EventHandler(this.cvc_Click);
            // 
            // pay
            // 
            this.pay.BackColor = System.Drawing.Color.Plum;
            this.pay.Location = new System.Drawing.Point(148, 143);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(75, 44);
            this.pay.TabIndex = 3;
            this.pay.Text = "Öde";
            this.pay.UseVisualStyleBackColor = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 199);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.cvc);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.creditNumber);
            this.Name = "Credit";
            this.Text = "Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditNumber;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox cvc;
        private System.Windows.Forms.Button pay;
    }
}