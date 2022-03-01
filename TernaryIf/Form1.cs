using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TernaryIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ternary Operatörü:
        //----------------------
        //Tek satırda ufak bir karar mekanizmasi ile kodunuza devam etmek isterseniz , soru işareti operatörü bu pratikliği sağlar.

        //Yazım Formatı ; 
        //KontrolDeger (Karşılaştırma operatörü)? Durumun olumlu olma durumu : "Durumun olumsuz durumu" ;



        private void Form1_Load(object sender, EventArgs e)
        {
            string girilenDeger = "Bilge Adam";
            //MessageBox.Show(girilenDeger == "Bilge Adam" ? "Doğu Değer":"Hatalı Değer");

            this.Text = girilenDeger == "Bilge Adam" ? "Doğru Değer" : "Hatalı Değer";

            string sonuc = 10 < 0 ? "Küçüktür" : "Büyüktür";
            MessageBox.Show(sonuc);



        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text.Length == 0 ? "Default" : textBox1.Text);
        }
    }
}
