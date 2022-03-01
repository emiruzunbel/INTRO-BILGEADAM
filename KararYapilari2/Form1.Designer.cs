
namespace KararYapilari2
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
            this.btnNotKontrol = new System.Windows.Forms.Button();
            this.grpNotKontrol = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSor = new System.Windows.Forms.Button();
            this.grpSor = new System.Windows.Forms.GroupBox();
            this.btnSatıs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpNotKontrol.SuspendLayout();
            this.grpSor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotKontrol
            // 
            this.btnNotKontrol.Location = new System.Drawing.Point(182, 87);
            this.btnNotKontrol.Name = "btnNotKontrol";
            this.btnNotKontrol.Size = new System.Drawing.Size(139, 44);
            this.btnNotKontrol.TabIndex = 0;
            this.btnNotKontrol.Text = "Kontrol";
            this.btnNotKontrol.UseVisualStyleBackColor = true;
            this.btnNotKontrol.Click += new System.EventHandler(this.btnNotKontrol_Click);
            // 
            // grpNotKontrol
            // 
            this.grpNotKontrol.Controls.Add(this.label1);
            this.grpNotKontrol.Controls.Add(this.btnNotKontrol);
            this.grpNotKontrol.Controls.Add(this.textBox1);
            this.grpNotKontrol.Location = new System.Drawing.Point(12, 12);
            this.grpNotKontrol.Name = "grpNotKontrol";
            this.grpNotKontrol.Size = new System.Drawing.Size(358, 145);
            this.grpNotKontrol.TabIndex = 1;
            this.grpNotKontrol.TabStop = false;
            this.grpNotKontrol.Text = "groupBox1";
            this.grpNotKontrol.Enter += new System.EventHandler(this.grpNotKontrol_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Not Giriniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btnSor
            // 
            this.btnSor.Location = new System.Drawing.Point(186, 54);
            this.btnSor.Name = "btnSor";
            this.btnSor.Size = new System.Drawing.Size(139, 44);
            this.btnSor.TabIndex = 4;
            this.btnSor.Text = "Sor";
            this.btnSor.UseVisualStyleBackColor = true;
            this.btnSor.Click += new System.EventHandler(this.btnSor_Click);
            // 
            // grpSor
            // 
            this.grpSor.Controls.Add(this.textBox2);
            this.grpSor.Controls.Add(this.btnSor);
            this.grpSor.Controls.Add(this.label2);
            this.grpSor.Location = new System.Drawing.Point(12, 175);
            this.grpSor.Name = "grpSor";
            this.grpSor.Size = new System.Drawing.Size(358, 100);
            this.grpSor.TabIndex = 5;
            this.grpSor.TabStop = false;
            this.grpSor.Text = "groupBox1";
            // 
            // btnSatıs
            // 
            this.btnSatıs.Location = new System.Drawing.Point(186, 128);
            this.btnSatıs.Name = "btnSatıs";
            this.btnSatıs.Size = new System.Drawing.Size(139, 50);
            this.btnSatıs.TabIndex = 6;
            this.btnSatıs.Text = "Satış İşlemleri";
            this.btnSatıs.UseVisualStyleBackColor = true;
            this.btnSatıs.Click += new System.EventHandler(this.btnSatıs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSatıs);
            this.panel1.Location = new System.Drawing.Point(12, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 191);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kitap Adet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpSor);
            this.Controls.Add(this.grpNotKontrol);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpNotKontrol.ResumeLayout(false);
            this.grpNotKontrol.PerformLayout();
            this.grpSor.ResumeLayout(false);
            this.grpSor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotKontrol;
        private System.Windows.Forms.GroupBox grpNotKontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSor;
        private System.Windows.Forms.GroupBox grpSor;
        private System.Windows.Forms.Button btnSatıs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

