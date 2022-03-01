
namespace ParametreliMetot
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSaydır = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSon3 = new System.Windows.Forms.Button();
            this.btnAyristirici = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 316);
            this.listBox1.TabIndex = 0;
            // 
            // btnSaydır
            // 
            this.btnSaydır.Location = new System.Drawing.Point(195, 54);
            this.btnSaydır.Name = "btnSaydır";
            this.btnSaydır.Size = new System.Drawing.Size(75, 23);
            this.btnSaydır.TabIndex = 1;
            this.btnSaydır.Text = "Saydır";
            this.btnSaydır.UseVisualStyleBackColor = true;
            this.btnSaydır.Click += new System.EventHandler(this.btnSaydır_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 373);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "White",
            "Black",
            "Red",
            "Yellow",
            "Purple"});
            this.comboBox1.Location = new System.Drawing.Point(367, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(367, 63);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(75, 23);
            this.btnOrnek3.TabIndex = 5;
            this.btnOrnek3.Text = "ARKAPLAN";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btnSon3
            // 
            this.btnSon3.Location = new System.Drawing.Point(182, 215);
            this.btnSon3.Name = "btnSon3";
            this.btnSon3.Size = new System.Drawing.Size(75, 23);
            this.btnSon3.TabIndex = 7;
            this.btnSon3.Text = "SON 3 HARF";
            this.btnSon3.UseVisualStyleBackColor = true;
            this.btnSon3.Click += new System.EventHandler(this.btnSon3_Click);
            // 
            // btnAyristirici
            // 
            this.btnAyristirici.Location = new System.Drawing.Point(367, 215);
            this.btnAyristirici.Name = "btnAyristirici";
            this.btnAyristirici.Size = new System.Drawing.Size(75, 23);
            this.btnAyristirici.TabIndex = 8;
            this.btnAyristirici.Text = "Ayrıştırıcı";
            this.btnAyristirici.UseVisualStyleBackColor = true;
            this.btnAyristirici.Click += new System.EventHandler(this.btnAyristirici_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(367, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnAyristirici);
            this.Controls.Add(this.btnSon3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaydır);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSaydır;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSon3;
        private System.Windows.Forms.Button btnAyristirici;
        private System.Windows.Forms.TextBox textBox3;
    }
}

