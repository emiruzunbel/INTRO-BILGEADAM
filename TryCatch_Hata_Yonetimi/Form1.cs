using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch_Hata_Yonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());           
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("Doğru Format");
        }

        private void btnHataYonetimiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                //Bu alana hata riski olan kod satırları eklenir. 
                int gelenDeger = Convert.ToInt32(textBox4.Text);
                MessageBox.Show("Doğru Format");
            }
            catch
            {
                //Try bloğunda içerisinde yazmış olduğunuz kodlarda herhangi bir hata çıkarsa Catch bloğu devreye girer.
                MessageBox.Show("Lütfen Doğru gir");            
                
            }
        }

        private void btnDetayliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = int.Parse(textBox5.Text);
                MessageBox.Show("Tebrikler ! Doğru format girdiniz.");
            }
            catch (Exception hata)
            {
                //Catch ifadesinin yanındaki excaption kelime anlamı =>> istisna...
                //Uygulamanın karlılığını bozan istinai durumla ilgili sizlere detayları teslim eder.
                //Özetle hatanın sistem tarafından atanan mesajını size teslim eder.

                MessageBox.Show(hata.Message);



                
            }
        }

        private void btnFinallyOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelenDeger = Convert.ToInt32(textBox6.Text);
                MessageBox.Show("Tebrikler!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Hata olsada olmasa da çalışmasını istediğiniz kodları yazdığımız alandır.
                //Try-Catch-Finally üçlüsü en son çalışır.
                MessageBox.Show("Hata var mı yok mu bilmiyorum..");
            }          

        }


        private void btnHataTipleri_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(textBox7.Text);
            }            
            catch (DivideByZeroException hata) //Sıfıra bölünme hatası yakalarsan 
            {
                MessageBox.Show("DivideByZeroException : " + hata.Message);
            }
            catch(OverflowException ex) //Veri tipinin boyutunu aşması durumunda alınan hata
            {
                MessageBox.Show("OwerflowException : " + ex.Message);

            }
            catch(FormatException exs) //Format hata tipi
            {
                MessageBox.Show("FormatException : " + exs.Message);
            }
            catch (Exception ) //Exception sınıfı tanımlı olan hatalar haricinde bir hata ile karşılaşırsa bu alandaki hata bloğu çalışacaktır.
            {
                MessageBox.Show("Hata var");
            }




        }


        //ÇALIŞMA ZAMANI HATALARI (RUNTIME EXCAPTION) 
        //----------------------------------------------
        //Çoğunlukla kullanıcı kaynaklı hatalardır.
        //Verilerin yanlış ,eksik ya da boş gönderilmesi.Çözüm yolu try-catch ile kullanıcı kaynaklı bu hataları çözebilirsiniz.

        //DERLEME ZAMANI HATALARI (COMPILE EXCAPTION)
        //----------------------------------------------
        //Tamamen yazılımcı kaynaklı hatalardır.Yazılım hataları meydana geldiğinde devreye girer.
        //En kolay çözülen hata tipidir.
        //Visual studio sizi uyarır.(Aşağıdaki error list penceresi ile)
        //İlgili hatanın üzerine gelip çift tıklarsanız sizi hataya götürür.

        //MANTIKSAL HATALAR
        //Tamamen yazılımcı kaynaklı hatalardır.
        //Uygulamanın algoritmasında meydana gelirler.Örneğin : bölme yapılacak yerde işlemi unutmak gibi.
        //Bu hatalar çözülmesi en zor hatalardır.Anlık olarak derleme aşaması takip edilmelidir.
        //Bu konuda visual studio harika toolar sunar. (watch, breakpoint )


        //BREAK POINT :
        //----------------------------------
        //Yan tarafdaki gri alana koyuluyor.
        //Derleme aşamasında adım adım dahil olup gözlememek için kullandığımız yardımcı tool'dur.
        //Yapmamız gereken tek şey hangi satırdan derleme anında dahil olmak istiyor iseniz ilgili satıra tıklayıp F9 tuşuna basmak olacaktır.Derleyici işaretlenen satıra gelindiğinde sizi oraya dahil edecektir ve adımları birlikte yönetebileceksiniz.
        //F11 ile ilerleyebilirsiniz.Değişkenlerin nesnelerini fare ile üzerne gelip beklediğinizde üzerindeki o anlık değeri görebilirsiniz. İşlemin bittiğini düşünüyor isenin F5 'e basarak Breakpoint'den çıkabilirsiniz.
        //Sol blokta çıkan sarı ok , derlenen satırın işaretçisidir.Mause yardımı ile geri oynatılabilir.Yani adımları atlayabilir veya tekrarlayabilirsiniz.


        //WATCH PENCERESİ :
        //----------------------------------
        //Yalnızca run time ' da çalışma zamanında kullanılır.Dolayısı ile penceremiz sadece çalışma zamanında görünür.
        //Eğer bu pencere kapalı ise uygulamayı çalıştırdığınızda "ctrl + alt + w" ardından 1'e basarsanız watch penceresini getirebilirsiniz.
        //Runtime'da elinizde olan değerleri takip etmenizi sağlar.
        //Açılan pencerede iki alan çıkar karşınıza.Birisi "name" alanı diğeri de "value" alanı.Sizler takip etmek istediğiniz değişkenin adını name bölümüne yazarsanız program ilerledikçe eklemiş olduğunuz değişken yani field program içerisindeki değer değişiklikleri watch penceresinden takip edilebilir.Bu arada name alanında ctrl+space yaparsanız intalecance kısmına aradığınız değişkenleri hızlıca bulabilirsiniz.
        //Noktalarınız virgülleriniz tüm c# yazım kuralları burada geçerlidir.


        //Eğer dışarıdan bir veri alıyorsanız , verilerin tutarlılığından emin değilseniz , orada mutlaka bir sorun çıkar.



        //TRY-CATCH
        //------------------------------------------
        //Try Alanının içerisine bütün hata alınabilecek kodlar alınır.
        //Catch bloğunun içerisinde ise alınacak hata karşılığında fırlatılacak olan exception fırlatılır ya da mesaj verdilir.



    }
}
