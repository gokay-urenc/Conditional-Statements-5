using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HESAP MAKİNESİ\n\nBirinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yapılacak işlemi tercih ediniz (+, -, *, /, O, H): ");
            char islem = Convert.ToChar(Console.ReadLine());
            double sonuc;
            if (islem == '+')
            {
                sonuc = sayi1 + sayi2;
                Console.Write("\nBu iki sayının toplamı " + sonuc + "'idir.");
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
                Console.Write("\nBu iki sayının farkı " + sonuc + "'idir.");
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
                Console.Write("\nBu iki sayının çarpımı " + sonuc + "'idir.");
            }
            else if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
                Console.Write("\nBu iki sayının bölümü " + sonuc + "'idir.");
            }
            else if (islem == 'O' || islem == 'o')
            {
                double ortalama = (sayi1 + sayi2) / 2;
                Console.Write("\nBu iki sayının ortalaması " + ortalama + "'idir");
            }
            else if (islem == 'H' || islem == 'h')
            {
                double toplam = sayi1 + sayi2, fark = sayi1 - sayi2, carpim = sayi1 * sayi2, bolum = sayi1 / sayi2, ortalama = (sayi1 + sayi2) / 2;
                Console.Write("\nToplamları: " + toplam + "\nFarkları: " + fark + "\nÇarpımları: " + carpim + "\nBölümleri: " + bolum + "\nOrtalamaları: " + ortalama);
            }
            else
            {
                Console.Write("\nLütfen geçerli bir işlem seçiniz.");
            }
            Console.ReadKey();
        }
    }
}
// Kullanıcıdan alınan iki sayının, yine toplanıcıdan alınan işlem tercihine göre hesaplama yapan program.
