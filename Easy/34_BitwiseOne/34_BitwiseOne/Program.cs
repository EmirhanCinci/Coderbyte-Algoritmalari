using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_BitwiseOne
{
    internal class Program
    {
        // Girilen string bir ifadenin ikilik taban sayısı olup olmadığını kontrol eden metot
        public static bool IkilikTabanSayisiMi(string veri)
        {
            for (int i = 0; i < veri.Length; i++)
            {
                if (veri[i] != '1' && veri[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }

        // Eşit uzunlukta olup olmadığını kontrol eden metot
        public static bool BitwiseOneUzunlukKontrol(string veri1, string veri2) 
        {
            if (veri1.Length == veri2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Verilen şartlara göre çıktı veren metot
        public static string BitwiseOne(string[] arr)
        {
            string sonuc = "";
            for (int i = 0; i < arr[0].Length; i++)
            {
                if (arr[0][i] == '1' || arr[1][i] == '1')
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
            // İşlevin, ikili sayıları temsil eden eşit uzunlukta yalnızca iki dizi içerecek olan strArr'da saklanan dizeler dizisini almasını ve
            // her iki dizide de bitsel OR işlemini gerçekleştiren son bir ikili diziyi döndürmesini sağlayın.
            // Bitsel OR işlemi, her iki ikili dizide de sıfırların olduğu yeni diziye bir 0 yerleştirir, aksi takdirde o noktaya bir 1 yerleştirir.
            // Örneğin: strArr ["1001", "0100"] ise, programınız "1101" dizesini döndürmelidir.
            // Örnek girdi: ["100", "000"]
            //       çıktı: 100
            // Örnek girdi: ["00011", "01010"]
            //       çıktı: 01011

        CONTROL:
            Console.Write("Lütfen 1. ikilik taban sayısını giriniz: ");
            string veri1 = Console.ReadLine();
            Console.Write("Lütfen 2. ikilik taban sayısını giriniz: ");
            string veri2 = Console.ReadLine();
            if (!IkilikTabanSayisiMi(veri1) || !IkilikTabanSayisiMi(veri2) || !BitwiseOneUzunlukKontrol(veri1, veri2))
            {
                Console.WriteLine("Girilen ifadelerin ya uzunlukları eşit değil ya da ikilik taban sayısı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            Console.WriteLine("Sonuç: " + BitwiseOne(new string[] { veri1, veri2 }));

            Console.ReadKey();
        }
    }
}
