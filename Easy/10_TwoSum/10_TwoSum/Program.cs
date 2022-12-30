using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_TwoSum
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

        // Verilen şartları sağlayan metot
        public static string TwoSum(int[] arr)
        {
            string sonuc = "";
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[0] == (arr[i] + arr[j]))
                    {
                        sonuc += "(" + arr[i] + ", " + arr[j] + ") ";
                    }
                }
            }
            if (sonuc.Length == 0)
            {
                return "-1";
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // Integer bir dizideki ilk eleman hariç dizideki herhangi iki elemanın toplamı dizinin ilk elemanını veren tüm sayı çiftlerini yazdıran program.
            // Eğer dizide böyle bir çift yok ise -1 yazdırılmalı.
            // Örnek girdi: TwoSum(new int[] { 17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7 })
            //       çıktı: (6, 11)  (10, 7)  (15, 2)
            // Örnek girdi: TwoSum(new int[] { 7, 6, 4, 1, 7, -2, 3, 12 })
            //       çıktı: (6, 1)  (4, 3)
            // Örnek girdi: TwoSum(new int[] { 17, 4, 5, 6 })
            //       çıktı: -1

        CONTROL1:
            Console.Write("Oluşturulacak dizi kaç terimli olsun: ");
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
                Console.Write("Lütfen dizinin " + (i + 1) + ". terimini giriniz: ");
                string deger = Console.ReadLine();
                if (!TamSayiMi(deger))
                {
                    Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = Convert.ToInt32(deger);
            }
            Console.WriteLine("Sonuç: " + TwoSum(dizi));

            Console.ReadKey();
        }
    }
}
