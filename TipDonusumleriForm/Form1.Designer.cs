
namespace TipDonusumleriForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.txt_Topla = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txt_ikinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToplamaİslemi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(39, 109);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(139, 91);
            this.btn_topla.TabIndex = 1;
            this.btn_topla.Text = "Tikla";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Visible = false;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // txt_Topla
            // 
            this.txt_Topla.Location = new System.Drawing.Point(312, 52);
            this.txt_Topla.Name = "txt_Topla";
            this.txt_Topla.Size = new System.Drawing.Size(180, 22);
            this.txt_Topla.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(717, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // txt_ikinciSayi
            // 
            this.txt_ikinciSayi.Location = new System.Drawing.Point(103, 60);
            this.txt_ikinciSayi.Name = "txt_ikinciSayi";
            this.txt_ikinciSayi.Size = new System.Drawing.Size(192, 22);
            this.txt_ikinciSayi.TabIndex = 4;
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(103, 22);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(192, 22);
            this.txtBirinciSayi.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToplamaİslemi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBirinciSayi);
            this.panel1.Controls.Add(this.txt_ikinciSayi);
            this.panel1.Location = new System.Drawing.Point(12, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 269);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "SayiBir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sayiİki";
            // 
            // btnToplamaİslemi
            // 
            this.btnToplamaİslemi.Location = new System.Drawing.Point(225, 100);
            this.btnToplamaİslemi.Name = "btnToplamaİslemi";
            this.btnToplamaİslemi.Size = new System.Drawing.Size(88, 36);
            this.btnToplamaİslemi.TabIndex = 8;
            this.btnToplamaİslemi.Text = "Topla";
            this.btnToplamaİslemi.UseVisualStyleBackColor = true;
            this.btnToplamaİslemi.Click += new System.EventHandler(this.btnToplamaİslemi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txt_Topla);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.TextBox txt_Topla;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txt_ikinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToplamaİslemi;
    }
}

