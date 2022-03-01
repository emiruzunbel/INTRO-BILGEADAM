using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MattSınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            this.Text = Math.PI.ToString();
            string deger = Math.PI.ToString();
            deger = deger.Substring(0, 4);
            this.Text = deger;
        }

        private void btnABS_Click(object sender, EventArgs e)
        {
            //ABS = MUTLAK DEGER

            int mutlakdeger = Math.Abs(-45);
            this.Text = mutlakdeger.ToString();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            //FLOOR = Verilen ondalıklı değeri bri alt değere tamamlar..

            double deger = Math.Floor(12.99);
            MessageBox.Show(deger.ToString());
        }

        private void btnCeiling_Click(object sender, EventArgs e)
        {
            //Ceiling => Verilen ondalıklı değeri bir üst degere tamamlar.
            double DEGER = Math.Ceiling(12.98);
            MessageBox.Show(DEGER.ToString());
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //round => Sayının yarısından fazlasının bir üste yarısından azını ise bir alta yuvarlar...

            //.'dan önceki sayı çift ise bir alt degere , tek ise bir üst degere tamamlar.
            double deger = Math.Round(13.50);
            MessageBox.Show(deger.ToString());
        }

        private void btnTruncate_Click(object sender, EventArgs e)
        {
            //Truncate : Sayının ondalıklı kısmına bakmaz , yalnızca tam kısmını size verir.
            double deger = Math.Truncate(75.30);
            MessageBox.Show(deger.ToString());
        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            //MAX : Verilen iki farklı değerden büyüğünü verir. 2 den fazla değer veremez
            int max = Math.Max(45, 75);
            MessageBox.Show(max.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //MİN :Verilen iki farklı değerden küçüğünü verir. 2. den fazla değer verilmez.
            int min = Math.Min(45, 75);
            MessageBox.Show(min.ToString());
        }

        private void btnPOW_Click(object sender, EventArgs e)
        {
            //POW : Kuvvet alma işlemlerinde kullanılır.
            //İlk parametrede taban , ikinci parametrede ise üst değer verilir.
            double kuvvet = Math.Pow(3, 4);
            MessageBox.Show(kuvvet.ToString());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            //Sqrt =>> Bir sayının karakökünün hesaplanması için tanımlanan fonksiyondur

            double deger = Math.Sqrt(17);
            MessageBox.Show(deger.ToString());
        }

        private void btnSıgn_Click(object sender, EventArgs e)
        {
            //Sign =>> Bir sayi negatif pozitif yada 0 eşit olup olmadığını bizlere dönen metottur.
            //Eğer sayı negatifse -1 , pozitifse 1 ,sıfıtsa 0 degerini döner.
            int deger =Math.Sign(-80);
        }
    }
}
