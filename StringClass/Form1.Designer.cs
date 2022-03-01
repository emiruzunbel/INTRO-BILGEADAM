
namespace StringClass
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
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.txtMetinGiris = new System.Windows.Forms.TextBox();
            this.btnContains = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.txtStartsWith = new System.Windows.Forms.TextBox();
            this.txtEndWith = new System.Windows.Forms.TextBox();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.txtIndexOf = new System.Windows.Forms.TextBox();
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.txtLastIndexOf = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.btnSubString = new System.Windows.Forms.Button();
            this.txtSubstring = new System.Windows.Forms.TextBox();
            this.btnLowwerUpper = new System.Windows.Forms.Button();
            this.txtToLowerUpper = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnCharArray = new System.Windows.Forms.Button();
            this.txtCharArray = new System.Windows.Forms.TextBox();
            this.btnTrim = new System.Windows.Forms.Button();
            this.txtTrim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.Location = new System.Drawing.Point(103, 38);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(90, 23);
            this.btnCompareTo.TabIndex = 0;
            this.btnCompareTo.Text = "COMPARE TO";
            this.btnCompareTo.UseVisualStyleBackColor = true;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // txtMetinGiris
            // 
            this.txtMetinGiris.Location = new System.Drawing.Point(12, 12);
            this.txtMetinGiris.Name = "txtMetinGiris";
            this.txtMetinGiris.Size = new System.Drawing.Size(181, 20);
            this.txtMetinGiris.TabIndex = 1;
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(307, 38);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(90, 23);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "CONTAINS";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(216, 12);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(181, 20);
            this.txtContains.TabIndex = 3;
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(514, 38);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(90, 23);
            this.btnStartsWith.TabIndex = 4;
            this.btnStartsWith.Text = "STARTS WITH";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // txtStartsWith
            // 
            this.txtStartsWith.Location = new System.Drawing.Point(423, 12);
            this.txtStartsWith.Name = "txtStartsWith";
            this.txtStartsWith.Size = new System.Drawing.Size(181, 20);
            this.txtStartsWith.TabIndex = 5;
            // 
            // txtEndWith
            // 
            this.txtEndWith.Location = new System.Drawing.Point(631, 12);
            this.txtEndWith.Name = "txtEndWith";
            this.txtEndWith.Size = new System.Drawing.Size(181, 20);
            this.txtEndWith.TabIndex = 6;
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(722, 38);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(90, 23);
            this.btnEndWith.TabIndex = 7;
            this.btnEndWith.Text = "END WITH";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(103, 119);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(90, 23);
            this.btnIndexOf.TabIndex = 8;
            this.btnIndexOf.Text = "INDEX OF";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // txtIndexOf
            // 
            this.txtIndexOf.Location = new System.Drawing.Point(12, 93);
            this.txtIndexOf.Name = "txtIndexOf";
            this.txtIndexOf.Size = new System.Drawing.Size(181, 20);
            this.txtIndexOf.TabIndex = 9;
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(307, 119);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(90, 23);
            this.btnLastIndexOf.TabIndex = 10;
            this.btnLastIndexOf.Text = "LAST INDEX OF";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // txtLastIndexOf
            // 
            this.txtLastIndexOf.Location = new System.Drawing.Point(216, 92);
            this.txtLastIndexOf.Name = "txtLastIndexOf";
            this.txtLastIndexOf.Size = new System.Drawing.Size(181, 20);
            this.txtLastIndexOf.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(514, 119);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(423, 93);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(181, 20);
            this.txtRemove.TabIndex = 13;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(722, 119);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(90, 23);
            this.btnReplace.TabIndex = 14;
            this.btnReplace.Text = "REPLACE";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(631, 92);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(181, 20);
            this.txtReplace.TabIndex = 15;
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(103, 197);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(90, 23);
            this.btnSplit.TabIndex = 16;
            this.btnSplit.Text = "SPLIT";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(12, 171);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(181, 20);
            this.txtSplit.TabIndex = 17;
            // 
            // btnSubString
            // 
            this.btnSubString.Location = new System.Drawing.Point(307, 197);
            this.btnSubString.Name = "btnSubString";
            this.btnSubString.Size = new System.Drawing.Size(90, 23);
            this.btnSubString.TabIndex = 18;
            this.btnSubString.Text = "SubString";
            this.btnSubString.UseVisualStyleBackColor = true;
            this.btnSubString.Click += new System.EventHandler(this.btnSubString_Click);
            // 
            // txtSubstring
            // 
            this.txtSubstring.Location = new System.Drawing.Point(216, 170);
            this.txtSubstring.Name = "txtSubstring";
            this.txtSubstring.Size = new System.Drawing.Size(181, 20);
            this.txtSubstring.TabIndex = 19;
            // 
            // btnLowwerUpper
            // 
            this.btnLowwerUpper.Location = new System.Drawing.Point(514, 198);
            this.btnLowwerUpper.Name = "btnLowwerUpper";
            this.btnLowwerUpper.Size = new System.Drawing.Size(90, 22);
            this.btnLowwerUpper.TabIndex = 20;
            this.btnLowwerUpper.Text = "Lower/Upper";
            this.btnLowwerUpper.UseVisualStyleBackColor = true;
            this.btnLowwerUpper.Click += new System.EventHandler(this.btnLowwerUpper_Click);
            // 
            // txtToLowerUpper
            // 
            this.txtToLowerUpper.Location = new System.Drawing.Point(423, 170);
            this.txtToLowerUpper.Name = "txtToLowerUpper";
            this.txtToLowerUpper.Size = new System.Drawing.Size(181, 20);
            this.txtToLowerUpper.TabIndex = 21;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(722, 198);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 22);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(631, 170);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(181, 20);
            this.txtInsert.TabIndex = 23;
            // 
            // btnCharArray
            // 
            this.btnCharArray.Location = new System.Drawing.Point(103, 275);
            this.btnCharArray.Name = "btnCharArray";
            this.btnCharArray.Size = new System.Drawing.Size(90, 22);
            this.btnCharArray.TabIndex = 24;
            this.btnCharArray.Text = "CHAR ARRAY";
            this.btnCharArray.UseVisualStyleBackColor = true;
            this.btnCharArray.Click += new System.EventHandler(this.btnCharArray_Click);
            // 
            // txtCharArray
            // 
            this.txtCharArray.Location = new System.Drawing.Point(13, 249);
            this.txtCharArray.Name = "txtCharArray";
            this.txtCharArray.Size = new System.Drawing.Size(180, 20);
            this.txtCharArray.TabIndex = 25;
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(307, 275);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(90, 23);
            this.btnTrim.TabIndex = 26;
            this.btnTrim.Text = "TRIM";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // txtTrim
            // 
            this.txtTrim.Location = new System.Drawing.Point(216, 249);
            this.txtTrim.Name = "txtTrim";
            this.txtTrim.Size = new System.Drawing.Size(181, 20);
            this.txtTrim.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.txtTrim);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.txtCharArray);
            this.Controls.Add(this.btnCharArray);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtToLowerUpper);
            this.Controls.Add(this.btnLowwerUpper);
            this.Controls.Add(this.txtSubstring);
            this.Controls.Add(this.btnSubString);
            this.Controls.Add(this.txtSplit);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtLastIndexOf);
            this.Controls.Add(this.btnLastIndexOf);
            this.Controls.Add(this.txtIndexOf);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.txtEndWith);
            this.Controls.Add(this.txtStartsWith);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.txtContains);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.txtMetinGiris);
            this.Controls.Add(this.btnCompareTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompareTo;
        private System.Windows.Forms.TextBox txtMetinGiris;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.TextBox txtStartsWith;
        private System.Windows.Forms.TextBox txtEndWith;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.TextBox txtIndexOf;
        private System.Windows.Forms.Button btnLastIndexOf;
        private System.Windows.Forms.TextBox txtLastIndexOf;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.Button btnSubString;
        private System.Windows.Forms.TextBox txtSubstring;
        private System.Windows.Forms.Button btnLowwerUpper;
        private System.Windows.Forms.TextBox txtToLowerUpper;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnCharArray;
        private System.Windows.Forms.TextBox txtCharArray;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.TextBox txtTrim;
    }
}

