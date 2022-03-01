using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEVLER
{
    public partial class Odev5 : Form
    {
        public Odev5()
        {
            InitializeComponent();
        }

        private void btnOdevMetot_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i%3 != 0 )
                {
                    listBox1.Items.Add(i);
                }
            }




        }



    }
}


