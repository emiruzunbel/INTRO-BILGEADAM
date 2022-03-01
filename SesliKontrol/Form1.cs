using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void SesliKontrol(string gelenMetin)
        {
           char[] karakterler= gelenMetin.ToLower().ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                switch (karakterler[i])
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'o':
                    case 'ö':
                    case 'ü':
                    case 'u':
                        listBox1.Items.Add(karakterler[i]);
                        break;
                    default:
                        listBox2.Items.Add(karakterler[i]);
                        break;
                }
                if (listBox1.Items.Count==0)
                {
                    MessageBox.Show("Sesli harf bulunmamaktadır.");
                }
                else
                {
                    MessageBox.Show("Sesli harf bulunmaktadır ve adeti : " + listBox1.Items.Count);
                }
            
            }
           
        }

        private void btnSesliKontrolEt_Click(object sender, EventArgs e)
        {
            //TextBox'dan gelen değerde eğer sesli bir harf varsa , o harfleri 1.listbox'a atın ve kaç adet olduğunu messagebox ile gösterin. eğer sesli harf yoksa sesli harf yoktur diye  uyarıda bulununuz.
            //Girilen metinde sessiz harfleri listbox2 ye atınız. kullanıcı küçük harf ya da büyük harf gözetmeksizin giriş yapabilir. fakat siz bunları hepsini küçük olarak değerlendirin.

            SesliKontrol(textBox1.Text);
            
        }
    }
}
