using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongulerLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAsalBul_Click(object sender, EventArgs e)
        {
            //ÖRNEK : İki sayi arasındaki asal sayıları bul


            if (textBox1.Text !="")
            {
                textBox2.Text = "";

                for (int İ = 2; İ < Convert.ToInt32(textBox1.Text); İ++)
                {
                    bool asalmi = true;
                    for (int j = 0; j <=İ/2; j++)
                    {
                        if (İ%j==0)
                        {
                            asalmi = false;
                        }
                    }
                    if (asalmi==true)
                    {
                        textBox2.Text += İ + Environment.NewLine;

                    }

                }
            }
            









        }
    }
}
