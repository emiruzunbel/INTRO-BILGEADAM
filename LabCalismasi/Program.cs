using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ÖRNEK-1
            //Dışarıdan alinan iki sayinin toplamiyla farkının birbirnie bölümünden kalanın sonucu nedir

            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = sayi1 + sayi2;
            //int fark = sayi1 - sayi2;            
            //int kalan = toplam % fark;

            //Console.WriteLine("Verdiğiniz iki sayının toplamı ile farkının birbirine bölümünden kalan: "  + kalan);








            #endregion

            #region ÖRNEK-2
            ////Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi kaçtır ?
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //int islem = ((sayi3 - 10 + 20) % 2)  ;
            //Console.WriteLine("Girdiğiniz sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi: " + (islem*islem));
            #endregion

            #region ÖRNEK-3
            //Dışarıdan girilen iki sayının karelerinin toplami ile karalerinin farkı toplamı kaçtır ??
            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int sayi5 = Convert.ToInt32(Console.ReadLine());

            //int birincikare = sayi4 * sayi4;
            //int ikincikare = sayi5 * sayi5;
            //int toplam = birincikare + ikincikare;
            //int fark = birincikare - ikincikare;
            //int sonuc = toplam + fark;
            //Console.WriteLine("işleminizin sonucu " + sonuc);

            #endregion

            #region ÖRNEK-4
            //bİR PROGRAM İÇERSİNİDE ÖĞRENCİNİN VİZE VE FİNAL NOTU ALINIP NOT ORTALAMASINI ÇIKARAN PROGRAMI YAZIN 
            //Vize notunun %30 final notunun %70 alıp ortalamayı bastırınız
            //Console.Write("Lütfen vize notunu giriniz: ");
            //double vize = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Lütfen final notunu giriniz: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = ((vize * 0.30) + (final * 0.70));

            //Console.WriteLine("Vize ve final sınavlarınızın ortalaması : " + ortalama);




            #endregion

            #region ÖRNEK-5
            //Dışarıdan kullanıcının adını sonra soyadını ayrı ayrı alınız . ve adı.soyadi@bilgeadam.com bir mail adresi oluşturup kullanıcıya gösterinizi

            //Console.WriteLine("Lütfen adınızı giriniz");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Lütfen soyadınızı giriniz");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Mail adresiniz : " + ad+"."+soyad+"@bilgeadam.com");




            #endregion

            #region ÖRNEK-6
            //Dışarıdan aldığımız iki dış açısı verilen üçgenin üçüncü dış açısınınm hesaplayayn programı yazın

            Console.WriteLine("Lütfen üçgenin bir dış açısını giriniz");
            double acı1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen üçgenin diğer dış açısını giriniz");
            double acı2 = Convert.ToDouble(Console.ReadLine());

            double acı3 = (360 - acı1 - acı2);

            Console.WriteLine("İki dış açısını girdiğiniz üçgenin diğer dış açısı : " + acı3);








            #endregion

            Console.ReadLine();
        }
    }
}
