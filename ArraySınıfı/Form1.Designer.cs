
namespace ArraySınıfı
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCOPY = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSORT = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnORNEK1
            // 
            this.btnORNEK1.Location = new System.Drawing.Point(12, 12);
            this.btnORNEK1.Name = "btnORNEK1";
            this.btnORNEK1.Size = new System.Drawing.Size(106, 69);
            this.btnORNEK1.TabIndex = 0;
            this.btnORNEK1.Text = "CLEAR";
            this.btnORNEK1.UseVisualStyleBackColor = true;
            this.btnORNEK1.Click += new System.EventHandler(this.btnORNEK1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(272, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 251);
            this.listBox1.TabIndex = 1;
            // 
            // btnCOPY
            // 
            this.btnCOPY.Location = new System.Drawing.Point(12, 87);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(106, 69);
            this.btnCOPY.TabIndex = 2;
            this.btnCOPY.Text = "COPY";
            this.btnCOPY.UseVisualStyleBackColor = true;
            this.btnCOPY.Click += new System.EventHandler(this.btnCOPY_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(12, 162);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(106, 69);
            this.btnIndexOf.TabIndex = 3;
            this.btnIndexOf.Text = "INDEX OF";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(135, 12);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(106, 69);
            this.btnLastIndexOf.TabIndex = 5;
            this.btnLastIndexOf.Text = "LAST INDEX OF";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(135, 87);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(106, 69);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "RESIZE";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnSORT
            // 
            this.btnSORT.Location = new System.Drawing.Point(135, 162);
            this.btnSORT.Name = "btnSORT";
            this.btnSORT.Size = new System.Drawing.Size(106, 69);
            this.btnSORT.TabIndex = 7;
            this.btnSORT.Text = "SORT";
            this.btnSORT.UseVisualStyleBackColor = true;
            this.btnSORT.Click += new System.EventHandler(this.btnSORT_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(12, 237);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(106, 69);
            this.btnReverse.TabIndex = 8;
            this.btnReverse.Text = "REVERSE";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 319);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSORT);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnCOPY);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnORNEK1);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnORNEK1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCOPY;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnSORT;
        private System.Windows.Forms.Button btnReverse;
    }
}

