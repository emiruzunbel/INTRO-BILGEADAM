using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = string.Empty;
            textBox3.Clear();
            textBox4.Text = null;
            textBox5.Text = default(string);
        }

        void temizleme()
        {
            textBox1.Text = " ";
            textBox2.Text = string.Empty;
            textBox3.Clear();
            textBox4.Text = null;
            textBox5.Text = default(string);
        }
        //Geriye değer döndürmeyen metotlar (void) ,yalnızca üzerine düşen işi yaparlar.Subrutin de denir.
        //Amacı tekrar kodlarının önüne geçmek , engellemektir.
        //Kod kalabalığından kurtulup daha esnek kodlar yazabilmektir.
        //Merkeziyetçi bir yöentim yapısından dolayı herhangi bir problem ya da değişklik olduğu durumda birden fazla yeri kontrol yerine , merkez yapıya müdahale ederek en kısa ve net şekilde sorunu çözebilirz
        private void button2_Click(object sender, EventArgs e)
        {
            temizleme();
        }
    }
}
