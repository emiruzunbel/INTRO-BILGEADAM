using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Arrays_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        string[] Arabalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Audi","Seat","Honda","Volvo","Alfa Romeo" };

        private void btnSonElemanıGoster_Click(object sender, EventArgs e)
        {
            //Dizinin eleman sayısını bilmiyor iseniz ancak sizden son elemanı isteniyorsa:
           string sonEleman = Arabalar[Arabalar.Length - 1];
            MessageBox.Show("Son eleman =>> " + sonEleman);
        }

        private void btnRastgeleGetir_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Rastgele olarak dizinin bir elemanını formun tepesinde yazdır

            string[] Markalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Audi", "Seat", "Honda", "Volvo", "Alfa Romeo" };
            Random rastgele = new Random();
            int a = rastgele.Next(0, Markalar.Length);
            this.Text = Arabalar[a];           
            
        }

        int index = 0;
        int havuz = 0;

        private void btnListboxaEkle_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //Buttona her bastığımda ilk elemandan başlayarak sırası ile tek tek listboxa ekleyin
            //Ancak eklediğiniz her elemanı bir havuzda toplayarak anlık olarak toplam durumunu formun textinde gösteriniz.
            if (index<sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
                havuz+=sayilar[index];
                this.Text="Havuzdaki şuana dek toplam değeriniz : " + havuz;
                index++;
            }
            else
            {
                MessageBox.Show("Dizinin son elemanına geldik.");
            }


            
            

        }
    }
}
