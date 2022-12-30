using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_SimpleEvens
{
    internal class Program
    {
        // Girilen string bir ifadenin tam sayı olup olmadığını kontrol eden metot
        public static bool TamSayiMi(string veri)
        {
            try
            {
                int sayi = Convert.ToInt32(veri);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Verilen şartları kontrol eden metot
        public static bool SimpleEvens(int sayi)
        {
            sayi = Math.Abs(sayi);
            while (sayi > 0)
            {
                int kalan = sayi % 10;
                if (kalan % 2 != 0)
                {
                    return false;
                }
                sayi /= 10;
            }
            return true;
        }

        static void Main(string[] args)
        {
            // Girilen bir pozitif tam sayının her bir rakamı çift sayı olup olmadığını kontrol eden programdır.
            // Örnek girdi: SimpleEvens(4602225)
            //       çıktı: false
            // Örnek girdi: SimpleEvens(226486)
            //       çıktı: true
            // Örnek girdi: SimpleEvens(2645846)
            //       çıktı: false

        CONTROL:
            Console.Write("Lütfen bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!TamSayiMi(veri))
            {
                Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Sonuç: " + SimpleEvens(sayi));

            Console.ReadKey();
        }
    }
}
