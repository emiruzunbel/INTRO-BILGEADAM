
namespace DoWhile
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnWhile2 = new System.Windows.Forms.Button();
            this.btnDoWhile2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(28, 34);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "WHILE";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(28, 74);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 1;
            this.btnDoWhile.Text = "DO WHILE";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(238, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 186);
            this.listBox1.TabIndex = 2;
            // 
            // btnWhile2
            // 
            this.btnWhile2.Location = new System.Drawing.Point(28, 152);
            this.btnWhile2.Name = "btnWhile2";
            this.btnWhile2.Size = new System.Drawing.Size(75, 23);
            this.btnWhile2.TabIndex = 3;
            this.btnWhile2.Text = "WHILE";
            this.btnWhile2.UseVisualStyleBackColor = true;
            this.btnWhile2.Click += new System.EventHandler(this.btnWhile2_Click);
            // 
            // btnDoWhile2
            // 
            this.btnDoWhile2.Location = new System.Drawing.Point(28, 192);
            this.btnDoWhile2.Name = "btnDoWhile2";
            this.btnDoWhile2.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile2.TabIndex = 4;
            this.btnDoWhile2.Text = "DO WHILE";
            this.btnDoWhile2.UseVisualStyleBackColor = true;
            this.btnDoWhile2.Click += new System.EventHandler(this.btnDoWhile2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoWhile2);
            this.Controls.Add(this.btnWhile2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnWhile2;
        private System.Windows.Forms.Button btnDoWhile2;
    }
}

