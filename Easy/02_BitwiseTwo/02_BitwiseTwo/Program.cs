using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitwiseTwo
{
    internal class Program
    {
        // Girilen string bir ifadenin ikilik taban sayısı olup olmadığını kontrol eden metot
        public static bool IkilikTabanSayisiMi(string veri)
        {
            char[] ikilik = { '0', '1' };
            foreach (var item in veri)
            {
                if (!ikilik.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }

        // Girilen iki string ifadeninin uzunluklarının aynı olup olmadığını kontrol eden metot
        public static bool UzunlukKontrol(string veri1, string veri2)
        {
            if (veri1.Length == veri2.Length)
            {
                return true;
            }
            return false;
        }

        // İstenilen şartı yerine getiren metot
        public static string BitwiseTwo(string[] arr)
        {
            string sonuc = "";
            for (int i = 0; i < arr[0].Length; i++)
            {
                if (arr[0][i] == '1' && arr[1][i] == '1')
                {
                    sonuc += "1";
                }
                else
                {
                    sonuc += "0";
                }
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin, ikili sayıları temsil eden eşit uzunlukta yalnızca iki dizi içerecek olan strArr'da saklanan dizi dizisini almasını ve her iki dizide de bitsel işlemini
            //      gerçekleştiren son bir ikili dizi döndürmesini sağlayın.
            // Bit düzeyinde bir AND işlemi, ikili dizilerin her iki konumunda da 1 bulunan yeni diziye bir 1 yerleştirir, aksi halde o noktaya bir 0 yerleştirir.

            // Örnek girdi: new String[] { "100", "000" }
            //       çıktı: 000
            // Örnek girdi: new String[] { "10100", "11100" }
            //       çıktı: 10100
            // Örnek girdi: new String[] { "10111", "01101" }
            //       çıktı: 00101

        CONTROL:
            Console.WriteLine("-----> Lütfen gireceğiniz ikilik taban sayıları eşit uzunlukta olmalıdır. <-----");
            Console.Write("Lütfen 1. ikilik taban sayısını giriniz: ");
            string veri1 = Console.ReadLine();
            Console.Write("Lütfen 2. ikilik taban sayısını giriniz: ");
            string veri2 = Console.ReadLine();
            if (!IkilikTabanSayisiMi(veri1) || !IkilikTabanSayisiMi(veri2) || !UzunlukKontrol(veri1, veri2))
            {
                Console.WriteLine("Girmiş olduğunuz ikilik taban sayılarının ya uzunlukları eşit değildir ya da ikilik taban sayısı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            string[] dizi = { veri1, veri2 };
            Console.WriteLine("Sonuç: " + BitwiseTwo(dizi));

            Console.ReadKey();
        }
    }
}
