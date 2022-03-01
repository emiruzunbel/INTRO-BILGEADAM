using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaeTimeClassMetolari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //Günün tarihini ve şuanki saati almak için 
            label1.Text=DateTime.Now.ToString();

            //Uzun formatta günün tarihini almak için :
            label1.Text = DateTime.Now.ToLongDateString();

            //Kısa formatta günün tarihini almak için :
            label1.Text = DateTime.Now.ToShortDateString();

            //Uzun formatta şuanın saatini almak için
            label1.Text = DateTime.Now.ToLongTimeString();

            //Kısa formatta şuanın saatini almak için
            label1.Text = DateTime.Now.ToShortTimeString();



            //Tarih Formatla :
            label1.Text=DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;

            //Artık Yil :
            bool sonuc = DateTime.IsLeapYear(2010);
            MessageBox.Show(sonuc == true ? "Şubat 29 çeker" : "Şubat 28 çeker");

            //Haftanın günü : 
            label1.Text=DateTime.Now.DayOfWeek.ToString();

            //Yılın kaçıncı günü :
            label1.Text = DateTime.Now.DayOfYear.ToString();
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //İki zaman arasındaki farkı alıp size teslim eden nesnemizdir.

            //Aşağıda bunu yapabilmek adına bir tarih tanımlıyalım.
            DateTime yeniZaman = new DateTime(1995,04,18,00,01,00);

            DateTime suan;
            suan = DateTime.Now;

            TimeSpan zamanfarki = suan - yeniZaman;

            int toplagun = zamanfarki.Days;
            int test = Convert.ToInt32(zamanfarki.TotalDays);
            label2.Text = test.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
