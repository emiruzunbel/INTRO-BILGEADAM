using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_daKullanılanNesneler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_TextChanged(object sender, EventArgs e)
        {
            int karakterVarUzerınde = textBox1.Text.Length;
            int fark = 450 - karakterVarUzerınde;
            label1.Text = fark.ToString();
        }

       

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            //ÜZERİNDEN MOUSE AYRILDIĞINDA ARKAPLANI siyah YAZI RENGİNİ kırmızı YAPSIN
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.Red;
        }




        //textbox.text.length=>> ilgili alanın üzerinde karakter adetini verir.





    }        
}
