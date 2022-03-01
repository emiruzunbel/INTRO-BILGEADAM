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
    public partial class Odev1 : Form
    {
        public Odev1()
        {
            InitializeComponent();
        }
       

    private void btnToplama_Click(object sender, EventArgs e)
        {
            int sonuc = domainUpDown1.SelectedIndex + domainUpDown2.SelectedIndex;
            label3.Text = sonuc.ToString();

        }

        private void Odev1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                domainUpDown1.Items.Add(i);
                domainUpDown2.Items.Add(i);
            }
        }
    }
}
