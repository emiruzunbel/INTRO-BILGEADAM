using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Dışarıdan kullanıcı Admin girerse hoşgeldin Admin desin
            if (txt_kadi.Text.ToLower() == "admin")
            {
                MessageBox.Show("Hoşgeldin Admin");
                
            }
            else
            {
                MessageBox.Show("Tanıyamadım");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txt_kadi.Text == "Admin" && txt_sifre.Text == "123")
            {
                Profil prf2 = new Profil();
                prf2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş bilgileri");
            }
            
        }

        //Karar Yapilari
        //-----------------------------
        //Uygulamanızın çalışması esnasında farklı senaryolara göre yönlendirmeler yapabiliriz.
        //Örneğin , kullanıcıdan gelen dğeeri aralıklarına göre uygulamadaki mantıksal işlemlerine göre sonuçlarına göre yönlendirebilirsiniz.
        //3 Temel karar yapısı karşımıza çıkar =>> if else - switch case - Ternary Operatörü

        //Karşılaştırma Operatörleri
        //-----------------------------
        //1) == Karşılıklı iki değerin birbiriyle eşit olması durumu
        //2) != Karşılıklı değerlerin birbiriyle eşit olmaması durumu
        //3) < Soldaki değerin sağdaki değerden küçük olması durumu
        //4) > Soldaki değerin sağdaki değerden büyük olması durumu
        //5) <= Soldaki değerin sağdaki değere küçük eşit olması durumu
        //6) >= Soldaki değerin sağdaki değere büyük eşit olması durumu





    }
}
