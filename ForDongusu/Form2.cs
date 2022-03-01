using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForDongusu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            string ad = "mehmet";
            string[] takimlar = { "Galatasaray", "Fenerbahçe", "Beşiktaş","BursaSpor","AnkaraGücü","Trabzonspor","HataySpor","İBB"};

            MessageBox.Show(takimlar[3]);



            for (int i = 0; i < takimlar.Length; i++)
            {
                listBox1.Items.Add(takimlar[i]);
            }
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 : Sayısal bir dizi tanımlayalım.Array sınıfını kullanmadan o dizini içerisindeki en büyük elemanı bulunuz.

            int[] sayilar = { 31, 53, 63, 75, 23, 64, 24, 98, 54, 3, 6, 93, 0, 35 };
            int enbuyukSayi = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (enbuyukSayi<sayilar[i])
                {
                    enbuyukSayi = sayilar[i];
                    
                }
                MessageBox.Show("En büyük eleman : " + enbuyukSayi);
            }         
                           
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //ÖRNEK-3 : Aşağıdaki dizide kaç tane çift kaç tane tek sayı vardır ? Kullanıcıyı bilgilendiriniz.

            int[] sayilar = { 31, 53, 63, 75, 23, 64, 24, 98, 54, 3, 6, 93, 0, 35 };

            int tekSayilar=0;
            int ciftSayilar=0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    ciftSayilar++;
                    
                }
                else if (sayilar[i]%2==1)
                {
                    tekSayilar++;
                }
            }
            MessageBox.Show(string.Format("Bu dizide toplamda ,{} adet çift sayi ,{1} adet tek sayı bulunmaktadır.", ciftSayilar, tekSayilar));
        }



        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //ÖRNEK 4: Aşağıda verilmiş olan adim değişkeninde yer alan metni tersten ister formun text'ine isterseniz mbox'a yazdırınız.
            //NOT =>> Stringler char dizinleridir

            string adim = "bilgeadam";
            string terstenYazim = "";

            for (int i = adim.Length-1; i >=0 ; i--)
            {
                terstenYazim += adim[i];
            }
            MessageBox.Show(terstenYazim);           


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //ÖRNEK 5 : Karmaşık olarak 50 adet sayıyı listbox'a ekleyiniz

            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int karmasikdeger = rnd.Next(0,101);
                listBox1.Items.Add(karmasikdeger);
            }

           

            
        }

        private void btnOrnek6_Click(object sender, EventArgs e)
        {
            // Form üzerinde yer alan tüm butonların backColour rengini kırmızı , yazı rengini ise Sarı yapalım

            //Not eğer kontrol yapıyor iseniz == != gibi operatörler kullanılır fakat nesneler üzerinde kontrol istiyor iseniz is keyword'ü kullanmanız şarttır.

            //Listbox'ın backColor deüişelim darkblue olsun.yazı rengi sarı olsun

            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Red;
                    this.Controls[i].ForeColor= Color.Black;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkBlue;
                    this.Controls[i].ForeColor = Color.Yellow;
                    this.Controls[i].Font = new Font("TAHOMA",20);
                }
                else if (this.Controls[i] is TextBox)
                {
                    this.Controls[i].Name = "deneme";
                }
            }            

        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen bir sayısal ifadenin rakamlarının toplamını bulan programı yazınız. 
            //Örneğin 123 = 1+2+3=6

            int toplam = 0;
            for (int i = 0; i < txtGirisAlan.Text.Length; i++)
            {
                int cevrilecekDeger = Convert.ToInt32(txtGirisAlan.Text[i].ToString());
                toplam += cevrilecekDeger;

            }
            MessageBox.Show(toplam.ToString());
            






        }

      
    }
}
