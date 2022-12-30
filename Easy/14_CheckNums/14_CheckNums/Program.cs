using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CheckNums
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
        public static string CheckNums(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                return "false";
            }
            else if (sayi1 < sayi2)
            {
                return "true";
            }
            else
            {
                return "-1";
            }
        }

        static void Main(string[] args)
        {
            // Girilen sayı1 ve sayı2 durumlarını inceleyin.
            // Eğer sayı1, sayı2'den büyük ise false; sayı2, sayı1'den büyük ise true; eşit ise -1'i ekrana yazdırılmasını sağlayın.
            // Örnek Girdi: CheckNums(11, 26);
            //       Çıktı: true
            // Örnek Girdi: CheckNums(21, 2);
            //       Çıktı: false
            // Örnek Girdi: CheckNums(25, 25);
            //       Çıktı: -1

        CONTROL:
            Console.Write("Lütfen 1. sayıyı giriniz: ");
            string veri1 = Console.ReadLine();
            Console.Write("Lütfen 2. sayıyı giriniz: ");
            string veri2 = Console.ReadLine();
            if (!TamSayiMi(veri1) || !TamSayiMi(veri2))
            {
                Console.WriteLine("Girmiş olduğunuz ifadelerden biri veya ikisi de tam sayı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi1 = Convert.ToInt32(veri1);
            int sayi2 = Convert.ToInt32(veri2);
            Console.WriteLine("Sonuç: " + CheckNums(sayi1, sayi2));

            Console.ReadKey();
        }
    }
}
