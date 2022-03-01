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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd;

        private void Form3_Load(object sender, EventArgs e)
        {
            //Random : Rastgele sayı üretmek için kullandığımız sayı üretmek ile görevli olan sınıftır.
            //int rastgele3 =rnd.Next(min,max)) :>> Sizden iki parametre ister . Oluşturulacak olan sayının maksimum minummum değerleri verilir.
            //NOT: Her zaman verdiğiniz max değerin bir eksiği gelir
            rnd=new Random();
            

            int gelensayi = rnd.Next(10000000,100000000);
            lblRasgeleKarakter.Text = gelensayi.ToString();           
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            if (textBox1.Text==lblRasgeleKarakter.Text)
            {
                MessageBox.Show("Doğru giriş tebrikler");
            }
            else
            {
                int kalanhakkımız = Convert.ToInt32(lblKalanHak.Text);
                kalanhakkımız--;
                lblKalanHak.Text=kalanhakkımız.ToString();

                if (lblKalanHak.Text!="0")
                {
                    rnd = new Random();
                    int gelenSayi = rnd.Next(10000000, 100000000);
                    lblRasgeleKarakter.Text = gelenSayi.ToString();
                }
                else
                {
                    button1.Enabled = false;
                    MessageBox.Show("Giriş hakkınız bittiğinden dolayı sistm otomatik olarak kapatılmıştır. ");
                }
            }
        }


        //Formun ilk açılış anında 8 haneli rastgele bir sayı label'a yazdırılsın. Ve kullanıcı butona bastığı anda textbox'daki yazıyla label'daki yazının karşılaştırılması yapılacak.
        //Eğer karşılaştırm olumsuz ise lblKalanHakkımız labelin'daki değeri 1 azaltın.
        //Eğer kullanıcı 5 defa hatalı giriş yaparsa butonun aktifliğini kapatın.
        //Her hatalı girişte rastgele yeni bir sayı üretmelisiniz.













    }
}
