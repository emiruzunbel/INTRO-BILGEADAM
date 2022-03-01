using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLabOrnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //ÖRNEK-1:Yanyana xxxxx

            
            for (int i = 0; i < 5; i++)
            {
                lblMetinAlanı.Text +="X";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMetinAlanı.Text = string.Empty;
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Alt alta X


            for (int i = 0; i < 5; i++)
            {
                lblMetinAlanı.Text += "X\n";
            }

        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //ÖRNEK-3 : 10 TANE alt alta 10 tane X


            for (int i = 0; i <=10; i++)
            {
                lblMetinAlanı.Text = "xxxxxxxxxx\n";
            }






            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        lblMetinAlanı.Text += " X ";
            //    }
            //    lblMetinAlanı.Text += "\n";
            //}
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //ÖRNEK 4 : 

            for (int i = 0; i < 10; i++)
            {
                for (int J = 0; J < i; J++)
                {
                    lblMetinAlanı.Text += " X ";
                }
                lblMetinAlanı.Text += "\n";
            }





        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    
                    listBox1.Items.Add($"{i}X{j}={i*j}");
                }
                listBox1.Items.Add("---------------------------------");
            }
        }
    }
}
