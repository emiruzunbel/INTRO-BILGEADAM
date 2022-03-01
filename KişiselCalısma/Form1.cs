using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KişiselCalısma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)        
        {
            //Örnek 1: Butona basıldığında 10 defa Adınızı Soyadınızı ListBox’ a ekleyin.
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Emir Uzunbel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Örnek 2: Butona basıldığında TextBox’ a girilen metni 10 defa ListBox’a yazdırın.
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Örnek 3: Butona basıldığında kullanıcının girdiği metni kullanıcının girdiği adet kadar listBox’ yazdırın.
            int adet = Convert.ToInt32(textBox3.Text);
            for (int i = 0; i < adet; i++)
            {
                listBox1.Items.Add(textBox2.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Örnek 4: Butona basıldığında 1 den 100 e kadar sayıları ListBox’ yazdırın.
            for (int i = 0; i < 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Örnek 5: Butona basıldığında 100′ den 1′ e kadar sayıları geriye doğru yazdırın.
            for (int i = 100; i >=1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///Örnek 6: Butona basıldığında 1′ den kullanıcının girdiği sayıya kadar sayıları ListBox’ a ekleyin.
            int sayi = Convert.ToInt32(textBox4.Text);
            for (int i = 0; i < sayi; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Örnek 7: Butona basıldığında başlangıç ve bitiş değerini kullanıcının verdiği sayıları ListBox’ ekleyin.
            for (int i = Convert.ToInt32(textBox5.Text); i < Convert.ToInt32(textBox6.Text); i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Örnek 8: Butona basıldığında başlangıç ve bitiş değerini kullanıcının verdiği sayılar içindeki çift sayıları ListBox’ a yazdırın.
            int baslangıc = Convert.ToInt32(textBox7.Text);
            int bitis = Convert.ToInt32(textBox8.Text);
           
            
            if (baslangıc%2==0)
            {
                for (int i = baslangıc; i < bitis; i += 2)
                {
                    listBox1.Items.Add(i);
                }
            }
            else if (baslangıc % 2 == 1)
            {
                int yeniDeger = baslangıc + 1;
                for (int k = yeniDeger; k < bitis; k+=2)
                {
                    listBox1.Items.Add(k);
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Butona basıldığında başlangıç ve bitiş değerini kullanıcının verdiği sayılar içindeki 3'e ve 5'e tam bölünen sayıları lsitBoxa yazdıralım

            int start = Convert.ToInt32(textBox9.Text);
            int finish = Convert.ToInt32(textBox10.Text);

            for (int i = start; i <= finish ; i++)
            {
                if ( i % 5 == 0 && i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Örnek 10:Butona basıldığında başlangıç ve bitiş değerini kullanıcının verdiği sayılar içindeki 3’e ve 5’e bölünen sayıların adetini yazdırın.

            int start = Convert.ToInt32(textBox11.Text);
            int finish = Convert.ToInt32(textBox12.Text);
            int sayac = 0;
            for (int i = start; i <= finish; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    listBox1.Items.Add(i);
                    sayac++;
                }
            }
            MessageBox.Show("3'e ve 5'e bölünen sayı adeti : " + sayac);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Örnek 11: Buton basıldığında 1′ den kullanıcının girdiği sayıya kadar olan sayıları toplayın.

            int baslangıc = Convert.ToInt32(textBox13.Text);
            int toplam = 0;
            for (int i = 1; i <=baslangıc; i++)
            {
                listBox1.Items.Add(i);
                toplam = toplam + i;
            }
            MessageBox.Show("Girmiş olduğunuz sayıların toplamı : " + toplam);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Örnek 12: Butona basıldığında kullanıcının girdiği sayının faktoriyelini hesaplayın.

            int faktöriyel = 1;
            int sayi = Convert.ToInt32(textBox14.Text);
            for (int i = sayi; i >= 1; i--)
            {
                faktöriyel = faktöriyel * i;
            }
            MessageBox.Show("Girmiş olduğunuz sayının faktöriyeli : " + faktöriyel.ToString());
        }

       
    }
}
