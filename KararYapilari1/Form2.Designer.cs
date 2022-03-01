
namespace KararYapilari1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNNotKontrolü = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnTekCiftKontrol = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnPasswordKontrol = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BTNNotKontrolü
            // 
            this.BTNNotKontrolü.Location = new System.Drawing.Point(28, 82);
            this.BTNNotKontrolü.Name = "BTNNotKontrolü";
            this.BTNNotKontrolü.Size = new System.Drawing.Size(147, 23);
            this.BTNNotKontrolü.TabIndex = 1;
            this.BTNNotKontrolü.Text = "NOT KONTROL";
            this.BTNNotKontrolü.UseVisualStyleBackColor = true;
            this.BTNNotKontrolü.Click += new System.EventHandler(this.BTNNotKontrolü_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 84);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Dışarıdan not bilgisi alınız.Eğer girilen not 0\'dan küçük ise küçük not giriş yap" +
    "amazsınız. 100\'den büyük ise 100\'den büyük not girişi yapılamaz mesajını gösteri" +
    "niz\r\n";
            // 
            // btnTekCiftKontrol
            // 
            this.btnTekCiftKontrol.Location = new System.Drawing.Point(28, 209);
            this.btnTekCiftKontrol.Name = "btnTekCiftKontrol";
            this.btnTekCiftKontrol.Size = new System.Drawing.Size(147, 23);
            this.btnTekCiftKontrol.TabIndex = 4;
            this.btnTekCiftKontrol.Text = "TEK CİFT KONTROL";
            this.btnTekCiftKontrol.UseVisualStyleBackColor = true;
            this.btnTekCiftKontrol.Click += new System.EventHandler(this.btnTekCiftKontrol_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(181, 163);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 69);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Dışarıdan almış olduğunuz sayının tek mi çift mi olduğunu gösteriniz\r\n";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(181, 287);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 84);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Dışarıdan girilen kelimenin uzunluğu 8 karaktere eşit ya da büyükse kayıt onaylan" +
    "dı\r\ndeğil ise daha uzun bir password giriniz şeklinde bir mesaj verdiriniz\r\n";
            // 
            // btnPasswordKontrol
            // 
            this.btnPasswordKontrol.Location = new System.Drawing.Point(28, 333);
            this.btnPasswordKontrol.Name = "btnPasswordKontrol";
            this.btnPasswordKontrol.Size = new System.Drawing.Size(147, 23);
            this.btnPasswordKontrol.TabIndex = 7;
            this.btnPasswordKontrol.Text = "Kontrol";
            this.btnPasswordKontrol.UseVisualStyleBackColor = true;
            this.btnPasswordKontrol.Click += new System.EventHandler(this.btnPasswordKontrol_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(28, 287);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(147, 20);
            this.textBox6.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnPasswordKontrol);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnTekCiftKontrol);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BTNNotKontrolü);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTNNotKontrolü;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnTekCiftKontrol;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnPasswordKontrol;
        private System.Windows.Forms.TextBox textBox6;
    }
}