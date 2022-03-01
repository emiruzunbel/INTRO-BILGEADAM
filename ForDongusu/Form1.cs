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
    public partial class btnFARK : Form
    {
        public btnFARK()
        {
            InitializeComponent();
        }

        //DÖNGÜLER (LOOPS)
        //---------------------------------
        //Bir başlangıç değeri olan belirli bir koşul gerçekleşene dek süren ve bu süre içerisinde bir takım işleri tekrarlı olarak gerçekleştiren nesnelere döngü denir.

        //Döngü çeşitleri :
        //---------------------------------
        //-For
        //-Foreach
        //-while
        //-Do while       
         
        





        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            //Döngü ilk giriş anında derleyici başlangıç değerine bakar ve bir daha asla bu bloğa uğramaz..
            //Bundan sonraki işlemler önce arttır , daha sonra koşula bak ,koşula uygunsa döngünün kod bloğunu harekete geçir ,uygun değilse döngüden çıkar.

            //for (Başlangıç Değeri ; Bitiş Koşulu; Artış veya azalış miktarı)


            for (int deger = 0; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }

           
        }

        private void btnOrnek2_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i >= 0; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek3_Click(object sender, EventArgs e)
        {
            //Örnek 3 = 2'den başlatıp 1000'e kadar çift sayıları görelim

            for (int i = 2; i <= 1000; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btnOrnek4_Click(object sender, EventArgs e)
        {
            //Örnek 4 = 1-1000 arasındaki sayıların toplamınıe ekrana bastırınız

            int toplam = 0;
            for (int i = 1; i <=1000 ; i++)
            {                
                toplam += i;
            }
            MessageBox.Show("Toplam = " + toplam);




        }

        private void btnOrnek5_Click(object sender, EventArgs e)
        {
            //Örnek5 : A'dan Z'ye alfabetik olarak sıralama

            for (char i = 'A'; i <= 'Z' ; i++)
            {
                listBox1.Items.Add(i);
            }

            //ASCİİ değerlerini istiyoruz

            for (char i = 'A'; i < 'Z'; i++)
            {
                listBox1.Items.Add(i + " " + Convert.ToInt32(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ÖRNEK-6 : 1-100 arasındaki çift sayıların toplami ile tek sayıların toplamının farklarının karesini döndüren for döngüsünü yazalım

            int toplamCift = 0;
            for (int i = 2; i <= 100; i+=2)
            {
                toplamCift += i;
            }
            int toplamtek = 0;
            for (int k = 1; k <= 100; k+=2)
            {
                toplamtek += k;
            }

            int fark = (toplamCift - toplamtek) ;
            int kare = (toplamCift - toplamtek)*(toplamCift - toplamtek) ;
            MessageBox.Show(fark.ToString());
            MessageBox.Show(kare.ToString());
        }

        private void btnOrnek7_Click(object sender, EventArgs e)
        {
            //Örnek 7 : 1945 ile 2022 arasındaki yılları lsitbox ekleyelim ancak 1990 ve 1992 olmasın

            {
                for (int i = 1945; i <= DateTime.Now.Year; i++)
                {
                    listBox1.Items.Add(i);
                    if (i!= 1990 && i!=1992)
                    {
                        listBox1.Items.Add(i);
                    }
                    
                }
            }
               
            



        }
    }
}
