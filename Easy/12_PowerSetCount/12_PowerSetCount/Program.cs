using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PowerSetCount
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

        // Verilen şartları sağlayan algoritma metodu
        public static int PowerSetCount(int[] arr)
        {
            return (int)Math.Pow(2, arr.Length);
        }

        static void Main(string[] args)
        {
            // Oluşturulan bir dizinin alt küme sayısını bulan programı yazınız.
            // Alt küme sayısını bulmak için kullanacağımız matematik formülü -----> 2 ^ (dizinin eleman sayısı)
            // Örnek girdi: PowerSetCount(new int[]{ 1, 2, 3, 4 })
            //       çıktı: 16
            // Örnek girdi: PowerSetCount(new int[]{ 5, 6 })
            //       çıktı: 4

        CONTROL1:
            Console.Write("Oluşturulacak dizi kaç terimli olacak: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Girmiş olduğunuz ifade bir pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL1;
            }
            int terim = Convert.ToInt32(veri);
            int[] dizi = new int[terim];
            for (int i = 0; i < terim; i++)
            {
            CONTROL2:
                Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
                string deger = Console.ReadLine();
                if (!TamSayiMi(deger))
                {
                    Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = Convert.ToInt32(deger);
            }
            Console.WriteLine("Sonuç: " + PowerSetCount(dizi));

            Console.ReadKey();
        }
    }
}
