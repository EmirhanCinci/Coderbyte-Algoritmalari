using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_LargestFour
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

        // Verilen işlemleri kontrol edip ona göre bir çıktı veren metot
        public static int LargestFour(int[] arr)
        {
            int toplam = 0;
            if (arr.Length <= 4)
            {
                foreach (var item in arr)
                {
                    toplam += item;
                }
                return toplam;
            }
            Array.Sort(arr);
            for (int i = arr.Length - 1; i >= arr.Length - 4; i--)
            {
                toplam += arr[i];
            }
            return toplam;
        }

        static void Main(string[] args)
        {
            // İşlevin arr'de saklanan tamsayı dizisini almasını ve en büyük dört öğeyi bulmasını ve toplamlarını döndürmesini sağlayın.
            // Örneğin: arr [4, 5, -2, 3, 1, 2, 6, 6] ise, bu dizideki en büyük dört öğe 6, 6, 4 ve 5'tir ve bu sayıların toplamı 21'dir.
            // Bu nedenle programınız 21 değerini döndürmelidir.
            // Dizide dörtten az sayı varsa, programınız dizideki tüm sayıların toplamını döndürmelidir.
            // Örnek girdi: new int[] {1, 1, 1, -5}
            //       çıktı: -2
            // Örnek girdi: new int[] {0, 0, 2, 3, 7, 1}
            //       çıktı: 13

        CONTROL1:
            Console.Write("Oluşturulacak dizinin kaç terimi olacak: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
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
                    Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = Convert.ToInt32(deger);
            }
            Console.WriteLine("Sonuç: " + LargestFour(dizi));

            Console.ReadKey();
        }
    }
}
