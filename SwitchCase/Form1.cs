using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Switch-Case
        -------------------

         *If-else mantığı ile çalışan bir kontrol mekanizmasidir.
         *Aralarındaki fark if-else yapisi büyük küçüklük durumlarını kontrol ederken , switch case yalnizca eşitlik durumlarını kontrol edebilen yapımızdır.
         *Kendisine ait bir index mekanizması ile koşulları algılar, sıraya koyar ve otomatik olarak yüzlerce koşul olsa bile herbirine bakmadan hangisine uyduğunu bulabilir.Bu da performansı etkiler.
         *Switch bloğu içerisinde yazdığınız veri tipiniz ne ise case(durum) olarak belirttiğimiz tüm veriler de aynı veri tipi olmalıdır.
         *Break =>> Koşul sağlandı ,artık karar yapısındaki kendini dışarı atmak için sisteme verilen mesajdır.  
         
                  
         
         */













        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            switch (textBox1.Text)
            {
                case ":":
                    mesaj = "İki nokta üst üste";
                    break;
                case ".":
                    mesaj = "Nokta";
                    break;
                case "?":
                    mesaj = "Soru İşareti";
                    break;

                default:
                    mesaj = "Böyle bir işaret yok";
                    break;
            }
            MessageBox.Show(mesaj);
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //ÖRNEK-1 : Dışardan mevsim girilsin. O mevsime ait aylar döndürülsün


            string mevsim;
            mevsim = textBox2.Text.ToLower();
            switch (mevsim)
            {
                case "Kış":
                    MessageBox.Show("Aralık - Ocak - Şubat");
                    break;
                case "İlkbahar":
                    MessageBox.Show("Mart -Nisan -Mayıs");
                    break;
                case "Sonbahar":
                    MessageBox.Show("Eylül -Ekim -Kasım");
                    break;
                case "Yaz":
                    MessageBox.Show("Haziran - Temmuz -Ağustos");
                    break;
                default:
                    MessageBox.Show("Böyle bir mevsim yok.");
                    break;
            }
        }

        private void btnPozisyonKontrol_Click(object sender, EventArgs e)
        {
            //ÖRNEK-2 Eğer textbox'a "Admin" ,"Moderator" ,"Yonetici" ,"Başkan" değerleri girilirse
            //"Yönetim paneline yönlendiriliyorsunuz..."
            //"Uye" girilirse "Anasayfaya yönlendiriliyorsunuz..."
            //Harici bir durumda ise " Bu sayfayı görmeye yetkiniz yok" desin.

            //Not :Bir string metodu toLower , ilgili metinsel ifadenin tamamini küçük harfe çevirmekle yükümlüdür.

            string pozisyon;
            string mesaj = "";

            pozisyon = textBox3.Text.ToLower();
            switch (pozisyon)
            {
                case "admin":
                case "moderator":
                case "yonetici":
                case "başkan":
                case "ceo":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz...";
                    break;
                case "uye":
                    mesaj = "Anasayfaya yönlendiriliyorsunuz.";
                    break;
                default:
                    mesaj = " Bu sayfayı görmeye yetkiniz yok";
                    break;
            }
            MessageBox.Show(mesaj);









        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //ÖRNEK-3 :  Kullanıcı adı doğru şifre yanlış ise "Kullanıcı adınız doğru şifreniz hatalıdır." uyarısı
            // Kullanıcı adı yanlışsa "Kullanıcı adınız yanlış. Bu neden ile şifreye bakmadım bile" uyarısı verelim.
            //KullaniciAdi ="bilgeadam"
            //Sifre ="12345";

            string KullaniciAdi = txtKullaniciAdi.Text.ToLower();
            string sifre = txtSifre.Text.ToLower();
            string mesaj = "";

            switch (KullaniciAdi)
            {
                case "bilgeadam":
                    switch (sifre)
                    {
                        case "12345":
                            mesaj = "Giris yapılıyor...";
                            break;

                        default:
                            mesaj = "Kullanıcı adınız doğru ancak şifreniz yanlış!";
                            break;
                    }                   
                    break;
                default:
                    mesaj = "Kullanıcı adını yanlış girdiniz , şifreye bakmadım bile!";
                    break;               
                                                  
            }

            MessageBox.Show(mesaj);




        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //C#7.0 ile gelen yeni özellikle artık küçük büyüklük ,küçük-eşit ,büyük eşit gibi tüm durumlarında kontrol edilebileceğini bilelim.
            //NOT : Visual studio 2017 kullanılabilir. 2015 sürümlü bir pc'de çalışmaz.

            //ÖRNEK-4: 

            int number = int.Parse(textBox4.Text);
            string metin = "";
            switch (number)
            {
                case int s when (s > 100):
                    metin = "Sayi 100'den büyüktür ";
                    break;
                case int s when (s < 100):
                    metin = "Sayi 100'den küçüktür ";
                    break;
                default:
                    metin = "Sayi 100'e eşittir.";
                    break;
                    
            }
            MessageBox.Show(metin);





        }
    }
}
