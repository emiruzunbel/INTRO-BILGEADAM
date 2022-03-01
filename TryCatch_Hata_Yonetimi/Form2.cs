using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch_Hata_Yonetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            try
            {
                double sonuc = Math.Pow(double.Parse(textBox1.Text), Convert.ToDouble(numericUpDown1.Value));
                notifyIcon1.Visible = true;
                notifyIcon1.Text = sonuc.ToString();
                notifyIcon1.BalloonTipTitle = "Sonucumuz";
                notifyIcon1.BalloonTipText = sonuc.ToString();
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                notifyIcon1.ShowBalloonTip(10000);

                Icon ic = new Icon("C:\\Users\\BN\\Desktop\\LIFE\\icons\\s.ico");
                notifyIcon1.Icon = ic;



            }
            catch (FormatException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            




            
        }
    }
}
