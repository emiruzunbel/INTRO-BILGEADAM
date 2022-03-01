using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            while (i<100)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }



        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 100;
            do
            {
                listBox1.Items.Add(i);
                i++;

            } while (i<100);
        }

        private void btnWhile2_Click(object sender, EventArgs e)
        {
            //ÖRNEK 2= Girilen bir sayının faktöriyelini alalım

            int Faktoriyel = 1;

            int i = 0;
            while (i>0)
            {
                Faktoriyel = Faktoriyel * i;
                i--;
            }
            MessageBox.Show(Faktoriyel.ToString());




        }

        private void btnDoWhile2_Click(object sender, EventArgs e)
        {
            int Faktoriyel = 1;
            int i = 0;
            do
            {
                Faktoriyel = Faktoriyel * i;
                i--;
            } while (i>0);
            MessageBox.Show(Faktoriyel.ToString());
        }
    }
}
