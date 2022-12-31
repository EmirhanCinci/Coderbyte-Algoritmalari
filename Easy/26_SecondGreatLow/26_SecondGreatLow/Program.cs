using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_SecondGreatLow
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

        // Girilen integer değerli pozitif bir dizinin içerisinde verilen şartlara göre çıktı veren metot
        public static string SecondGreatLow(int[] arr)
        {
            string sonuc = "";
            Array.Sort(arr);
            if (arr.Length == 2)
            {
                if (arr[0] == arr[1])
                {
                    return arr[0] + " " + arr[0];
                }
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[0] != arr[i])
                {
                    sonuc += arr[i].ToString() + " ";
                    break;
                }
            }
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[arr.Length - 1] != arr[i])
                {
                    sonuc += arr[i].ToString();
                    break;
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin arr'de saklanan sayı dizisini almasını ve bir boşlukla ayrılmış olarak sırasıyla ikinci en düşük ve ikinci en büyük sayıları döndürmesini sağlayın.
            // Dizi boş olmayacak ve en az 2 sayı içerecektir. Sadece iki sayı varsa zor olabilir!

            // Örnek girdi: [7, 7, 12, 98, 106]
            //       çıktı: 12 98
            // Örnek girdi: [1, 42, 42, 180]
            //       çıktı: 42 42
            // Örnek girdi: [4, 90]
            //       çıktı: 90 4

        CONTROL1:
            Console.Write("Kaç terimli bir dizi oluşturacaksınız: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
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
                    Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
                    goto CONTROL2;
                }
                dizi[i] = Convert.ToInt32(deger);
            }
            Console.WriteLine("Sonuç: " + SecondGreatLow(dizi));
            Console.ReadKey();
        }
    }
}
