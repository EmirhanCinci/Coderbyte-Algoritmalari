using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_SimpleAdding
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığını kontrol eden metot
        public static bool PozitifTamSayiMi(string veri)
        {
            try
            {
                int sayi = Convert.ToInt32(veri);
                if (sayi > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Girilen pozitif tam sayıdan başlayıp 1'e kadar olan tam sayıların toplamını veren metot
        public static int SimpleAdding(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            // İşlevin 1'den num'a kadar tüm sayıları toplamasını sağlayın.
            // Örneğin: giriş 4 ise, programınız 10 döndürmelidir çünkü 1 + 2 + 3 + 4 = 10.
            // Test durumları için, parametre num 1 ile 1000 arasında herhangi bir sayı olacaktır.

        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Sonuç: " + SimpleAdding(sayi));

            Console.ReadKey();
        }
    }
}
