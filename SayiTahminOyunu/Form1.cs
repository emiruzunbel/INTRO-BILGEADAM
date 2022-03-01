using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sayi = new Random().Next(1000, 9999).ToString();

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = sayi;
            char[] tutulanSayi = sayi.ToCharArray();

            bool durum = false;

            while (!durum)
            {
                string tahmin =textBox1.Text;
                string sonuc = "";
                char[] tahminSayisi = tahmin.ToCharArray();

                for (int i = 0; i < tahmin.Length; i++)
                {
                    if (tutulanSayi[i]==tahminSayisi[i])
                    {
                        sonuc += "+";
                    }
                    else if (sayi.Contains(tahminSayisi[i]))
                    {
                        sonuc += "-";
                    }
                    else
                    {
                        sonuc += "*";
                    }
                }

                if (sonuc=="++++")
                {
                    durum = true;
                    MessageBox.Show("Doğru");

                }
                else
                {
                    MessageBox.Show("Yanlış");
                    MessageBox.Show(sonuc + "İşaretlere bak ve tekrar deneyebilirsiniz");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
