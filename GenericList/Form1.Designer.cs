
namespace GenericList
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
            this.btnORNEK1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnORNEK4 = new System.Windows.Forms.Button();
            this.btnSORU1 = new System.Windows.Forms.Button();
            this.btnSORU2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnORNEK1
            // 
            this.btnORNEK1.Location = new System.Drawing.Point(12, 12);
            this.btnORNEK1.Name = "btnORNEK1";
            this.btnORNEK1.Size = new System.Drawing.Size(112, 36);
            this.btnORNEK1.TabIndex = 0;
            this.btnORNEK1.Text = "ÖRNEK-1";
            this.btnORNEK1.UseVisualStyleBackColor = true;
            this.btnORNEK1.Click += new System.EventHandler(this.btnORNEK1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Location = new System.Drawing.Point(13, 63);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(111, 36);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "ÖRNEK-2";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Location = new System.Drawing.Point(13, 114);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(111, 36);
            this.btnOrnek3.TabIndex = 2;
            this.btnOrnek3.Text = "ÖRNEK-3";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnORNEK4
            // 
            this.btnORNEK4.Location = new System.Drawing.Point(13, 166);
            this.btnORNEK4.Name = "btnORNEK4";
            this.btnORNEK4.Size = new System.Drawing.Size(111, 36);
            this.btnORNEK4.TabIndex = 3;
            this.btnORNEK4.Text = "ÖRNEK-4";
            this.btnORNEK4.UseVisualStyleBackColor = true;
            this.btnORNEK4.Click += new System.EventHandler(this.btnORNEK4_Click);
            // 
            // btnSORU1
            // 
            this.btnSORU1.Location = new System.Drawing.Point(162, 12);
            this.btnSORU1.Name = "btnSORU1";
            this.btnSORU1.Size = new System.Drawing.Size(112, 36);
            this.btnSORU1.TabIndex = 4;
            this.btnSORU1.Text = "SORU-1";
            this.btnSORU1.UseVisualStyleBackColor = true;
            this.btnSORU1.Click += new System.EventHandler(this.btnSORU1_Click);
            // 
            // btnSORU2
            // 
            this.btnSORU2.Location = new System.Drawing.Point(280, 234);
            this.btnSORU2.Name = "btnSORU2";
            this.btnSORU2.Size = new System.Drawing.Size(112, 36);
            this.btnSORU2.TabIndex = 5;
            this.btnSORU2.Text = "SORU-2";
            this.btnSORU2.UseVisualStyleBackColor = true;
            this.btnSORU2.Click += new System.EventHandler(this.btnSORU2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Değer gir:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 95);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSORU2);
            this.Controls.Add(this.btnSORU1);
            this.Controls.Add(this.btnORNEK4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnORNEK1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnORNEK1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnORNEK4;
        private System.Windows.Forms.Button btnSORU1;
        private System.Windows.Forms.Button btnSORU2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

