
namespace Diziler_Arrays_
{
    partial class Form3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnORNEK2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnORNEK3 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnORNEK1
            // 
            this.btnORNEK1.Location = new System.Drawing.Point(22, 137);
            this.btnORNEK1.Name = "btnORNEK1";
            this.btnORNEK1.Size = new System.Drawing.Size(136, 39);
            this.btnORNEK1.TabIndex = 0;
            this.btnORNEK1.Text = "ÖRNEK1";
            this.btnORNEK1.UseVisualStyleBackColor = true;
            this.btnORNEK1.Click += new System.EventHandler(this.btnORNEK1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(136, 95);
            this.listBox1.TabIndex = 1;
            // 
            // btnORNEK2
            // 
            this.btnORNEK2.Location = new System.Drawing.Point(184, 137);
            this.btnORNEK2.Name = "btnORNEK2";
            this.btnORNEK2.Size = new System.Drawing.Size(136, 39);
            this.btnORNEK2.TabIndex = 2;
            this.btnORNEK2.Text = "ÖRNEK2";
            this.btnORNEK2.UseVisualStyleBackColor = true;
            this.btnORNEK2.Click += new System.EventHandler(this.btnORNEK2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(184, 23);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(136, 95);
            this.listBox2.TabIndex = 3;
            // 
            // btnORNEK3
            // 
            this.btnORNEK3.Location = new System.Drawing.Point(22, 201);
            this.btnORNEK3.Name = "btnORNEK3";
            this.btnORNEK3.Size = new System.Drawing.Size(136, 39);
            this.btnORNEK3.TabIndex = 4;
            this.btnORNEK3.Text = "ÖRNEK-3";
            this.btnORNEK3.UseVisualStyleBackColor = true;
            this.btnORNEK3.Click += new System.EventHandler(this.btnORNEK3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Location = new System.Drawing.Point(184, 201);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(136, 39);
            this.btnOrnek4.TabIndex = 5;
            this.btnOrnek4.Text = "ÖRNEK-4";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 347);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnORNEK3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnORNEK2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnORNEK1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnORNEK1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnORNEK2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnORNEK3;
        private System.Windows.Forms.Button btnOrnek4;
    }
}