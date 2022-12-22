using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SuperIncreasing
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

        // Verilen algoritma şartları kontrol eden metot
        public static bool SuperIncreasing(int[] arr)
        {
            int toplam = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                toplam += arr[i];
                if (toplam >= arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            // İşlevin arr'de saklanan sayı dizisini almasını ve dizinin, dizideki her öğenin önceki tüm öğelerin toplamından daha büyük olduğu bir süper artan dizi oluşturup
            // oluşturmadığını belirlemesini sağlayın. Dizi yalnızca pozitif tam sayılardan oluşacaktır.

            // Örnek girdi: [1, 2, 3, 4]
            //       çıktı: false
            // Örnek girdi: [1, 2, 5, 10]
            //       çıktı: true
            // Örnek girdi: [1, 3, 6, 13, 54]
            //       çıktı: true

        CONTROL1:
            Console.Write("Oluşturacağınız dizi kaç terimli olacak: ");
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
                if (!PozitifTamSayiMi(deger))
                {
                    Console.WriteLine("Girmiş olduğunuz ifade bir pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = Convert.ToInt32(deger);
            }
            Console.WriteLine("Sonuç: " + SuperIncreasing(dizi));

            Console.ReadKey();
        }
    }
}
