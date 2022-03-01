using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotOverload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Metot overload nedir :
        //--------------------------
        //Bir metota fazla yük yapabilmektir.
        //İlgili metodu aynı ad ile tekrar oluşturabilirsiniz.
        //Eğer metot overload edilecekse , metot imzalarına (parametre,geridönül tipleri) dikkate almalısınız...
        //Farklı parametre tipleri almak zorundasınız.

        #region ÖRNEK
        /// <summary>
        /// Sunucu adi bilinmediği durumlarda dışarıdan girilsin diye bu metot var.
        /// </summary>
        /// <param name="ad">mail adresinin username kısmı girilir</param>
        /// <param name="sunucuadi">Domain adı girilir</param>
        void MailOlusturucu(string ad, string sunucuadi)
        {
            MessageBox.Show(ad + "@" + sunucuadi);
        }

        /// <summary>
        /// Bu metot isimden gelen bilgiyle birlikte ismini@bilgeadam.com olarak mesaj gönderir.
        /// </summary>
        /// <param name="ad">adınızı giriniz </param>
        void MailOlusturucu(string ad)
        {
            MessageBox.Show(ad + "@bilgeadam.com");
        }
        #endregion

        private void btnMailAdresiOlustur_Click(object sender, EventArgs e)
        {
            //Kullanıcıdan tercih ettiği adi ve tercih ettiği sunucu bilgisini alan ve şu şekilde birleştiren //TextBox.text@cmbsunuculistesi

            if (comboBox1.SelectedIndex==-1)
            {
                MailOlusturucu(textBox1.Text);
            }
            else
            {
                MailOlusturucu(textBox1.Text, comboBox1.SelectedItem.ToString());
            }



        }
    }
    }
    



