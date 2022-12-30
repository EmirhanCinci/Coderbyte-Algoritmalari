using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HappyNumbers
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

        // İstenilen şartları kontrol eden metot
        public static bool HappyNumbers(int sayi)
        {
            int toplam = 0;
            while (sayi > 0)
            {
                int kalan = sayi % 10;
                toplam += (int)Math.Pow(kalan, 2);
                sayi /= 10;
            }
            if (1 == toplam)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Girilen bir pozitif tam sayının basamaklarındaki rakamlarının kareleri toplamı 1 ise mutlu sayıdır; değil ise mutlu sayı değildir.
            // 10 sayısını inceleyelim... -----> 1^2 + 0^2 = 1 + 0 = 1 olduğu için mutlu sayıdır.
            // Örnek girdi: HappyNumbers(1)
            //       çıktı: true
            // Örnek girdi: HappyNumbers(10)
            //       çıktı: true
            // Örnek girdi: HappyNumbers(101)
            //       çıktı: false

        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Girmiş olduğunuz ifade pozitif bir tam sayı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Sonuç: " + HappyNumbers(sayi));

            Console.ReadKey();
        }
    }
}
