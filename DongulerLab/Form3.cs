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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //ÖRNEK : Dışarıdan aldığınız cümlenin içerisinde kaç adet sesli harf olduğunu tespit edip gösteriniz.

            //BENİM YAPTIĞIM :
            //---------------------------------------
            //int sayac = 0;
            //string cumle = textBox1.Text;
            //for (int i = 0; i < cumle.Length; i++)
            //{
            //    if (cumle[i]=='a' || cumle[i]=='e' || cumle[i]=='i' || cumle[i]=='ı' || cumle[i]=='o' || cumle[i]=='ö' || cumle[i]=='u' || cumle[i]=='ü')
            //    {
            //        sayac++;
            //    }
            //}
            //MessageBox.Show(sayac.ToString());



            //HOCANIN YAPTIĞI :
            //---------------------------------------
            string[] sesliler = { "a", "e", "i", "ı", "o", "ö", "ü", "u" };
            string metin =textBox1.Text;
            int sayac=0;

            for (int i = 0; i < metin.Length; i++)
            {
                for (int Z = 0; Z < sesliler.Length; Z++)
                {
                    if (sesliler[Z]==metin[i].ToString())
                    {
                        sayac++;
                    }
                }
            }
            MessageBox.Show("Girdiğiniz cümledeki sesli harf sayısı : " + sayac);


        }
    }
}
