using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NumberReverse
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

        // Girilen string bir dizinin istenilen formatta yazımı
        public static string NumberReserve(string[] arr)
        {
            string sonuc = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sonuc += arr[i].ToString() + " ";
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin, bir sayı dizisi olacak str parametresini iletmesini sağlayın ve sayılarla ters sırada yeni bir dize döndürün.
            // Örnek girdi: 1 2 3
            //       çıktı: 3 2 1
            // Örnek girdi: 10 20 50
            //       çıktı: 50 20 10

        CONTROL:
            Console.Write("Oluşturulacak dizi kaç terimli olacak: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int terim = Convert.ToInt32(veri);
            string[] dizi = new string[terim];
            for (int i = 0; i < terim; i++)
            {
            CONTROL2:
                Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
                string deger = Console.ReadLine();
                if (!PozitifTamSayiMi(veri))
                {
                    Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = deger;
            }
            Console.WriteLine("Sonuç: " + NumberReserve(dizi));

            Console.ReadKey();
        }
    }
}
