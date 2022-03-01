
namespace Diziler_Arrays_
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
            this.btnSonElemanıGoster = new System.Windows.Forms.Button();
            this.btnRastgeleGetir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListboxaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSonElemanıGoster
            // 
            this.btnSonElemanıGoster.Location = new System.Drawing.Point(23, 27);
            this.btnSonElemanıGoster.Name = "btnSonElemanıGoster";
            this.btnSonElemanıGoster.Size = new System.Drawing.Size(115, 48);
            this.btnSonElemanıGoster.TabIndex = 0;
            this.btnSonElemanıGoster.Text = "Son Eleman Nedir?";
            this.btnSonElemanıGoster.UseVisualStyleBackColor = true;
            this.btnSonElemanıGoster.Click += new System.EventHandler(this.btnSonElemanıGoster_Click);
            // 
            // btnRastgeleGetir
            // 
            this.btnRastgeleGetir.Location = new System.Drawing.Point(23, 97);
            this.btnRastgeleGetir.Name = "btnRastgeleGetir";
            this.btnRastgeleGetir.Size = new System.Drawing.Size(115, 48);
            this.btnRastgeleGetir.TabIndex = 1;
            this.btnRastgeleGetir.Text = "Rastgele Getir";
            this.btnRastgeleGetir.UseVisualStyleBackColor = true;
            this.btnRastgeleGetir.Click += new System.EventHandler(this.btnRastgeleGetir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(192, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 121);
            this.listBox1.TabIndex = 2;
            // 
            // btnListboxaEkle
            // 
            this.btnListboxaEkle.Location = new System.Drawing.Point(470, 27);
            this.btnListboxaEkle.Name = "btnListboxaEkle";
            this.btnListboxaEkle.Size = new System.Drawing.Size(147, 69);
            this.btnListboxaEkle.TabIndex = 3;
            this.btnListboxaEkle.Text = "Ekle";
            this.btnListboxaEkle.UseVisualStyleBackColor = true;
            this.btnListboxaEkle.Click += new System.EventHandler(this.btnListboxaEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListboxaEkle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRastgeleGetir);
            this.Controls.Add(this.btnSonElemanıGoster);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonElemanıGoster;
        private System.Windows.Forms.Button btnRastgeleGetir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListboxaEkle;
    }
}