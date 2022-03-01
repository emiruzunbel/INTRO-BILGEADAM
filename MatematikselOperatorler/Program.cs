using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Toplama İşlemi
            int sayiBir = 102;
            int sayiİki = 25;
            int toplam = sayiBir + sayiİki;

            Console.WriteLine("Toplama işlemi sonucu: " + toplam); // Çıktı
            Console.WriteLine("Toplama işlemi sonucu: " + sayiBir+sayiİki );
            Console.WriteLine("Toplama işlemi sonucu: " +(sayiBir+sayiİki));


            Console.WriteLine("----------------------------------------------------------------");

            #endregion

            #region Çıkartma İşlemi
            int fark = sayiBir - sayiİki;

            Console.WriteLine("Çıkartma işlem sonucu: "+ fark);
            Console.WriteLine("Çıkartma işlemi sonucu: " + (sayiBir - sayiİki));

            Console.WriteLine("----------------------------------------------------------------");

            #endregion

            #region Çarpım İşlemi
            int Carpim = sayiBir * sayiİki;

            Console.WriteLine("Çarpma işlem sonucu: " + Carpim);
            Console.WriteLine("Carpma işlemi sonucu: " + (sayiBir * sayiİki));

            Console.WriteLine("----------------------------------------------------------------");

            #endregion

            #region Bölme İşlemi
            int Bölme = sayiBir * sayiİki;

            Console.WriteLine("Bölme işlem sonucu: " + Bölme);
            Console.WriteLine("Bölme işlemi sonucu: " + (sayiBir / sayiİki));

            Console.WriteLine("----------------------------------------------------------------");

            #endregion

            #region Mod Alma
            int Mod = sayiBir % sayiİki;

            Console.WriteLine("Mod işleminin sonucu: " + Mod);
            Console.WriteLine("Mod işleminin sonucu: " + (sayiBir%sayiİki));

            Console.WriteLine("----------------------------------------------------------------");

            #endregion

            #region Sayıyı Bir Arttırma
            int sayi = 15;
            Console.WriteLine("Sayının ilk değeri " + sayi);

            sayi = sayi + 1;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            sayi += 1;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            sayi++;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            Console.WriteLine("----------------------------------------------------------------");
            #endregion

            #region Sayıyı Bir azaltma          
            sayi = 15;
            Console.WriteLine("Sayının ilk değeri " + sayi);

            sayi = sayi - 1;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            sayi -= 1;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            sayi--;
            Console.WriteLine("Sayının bir üst değerine atanmış hali " + sayi);

            Console.WriteLine("----------------------------------------------------------------");
            #endregion


            Console.ReadLine();
        }
    }
}
