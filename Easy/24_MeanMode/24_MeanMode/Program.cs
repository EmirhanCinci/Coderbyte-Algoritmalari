using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_MeanMode
{
    internal class Program
    {
        // Verilen şartları kontrol eden metot
        public static int MeanMode(int[] arr)
        {
            if (Ortalama(arr) == ModBulma(arr))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // Girilen bir dizinin modunu bulan metot
        public static int ModBulma(int[] arr)
        {
            int buyuk = 0;
            int mod = 0;
            int sayac = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        sayac++;
                    }
                }
                if (sayac > buyuk)
                {
                    buyuk = sayac;
                    mod = i;
                }
                sayac = 0;
            }
            return arr[mod];
        }

        // Girilen bir dizinin aritmetik ortalamasını bulan metot
        public static int Ortalama(int[] arr)
        {
            int toplam = 0;
            foreach (var item in arr)
            {
                toplam += item;
            }
            return toplam / arr.Length;
        }

        static void Main(string[] args)
        {
            // İşlevin arr'de saklanan sayı dizisini almasını ve mod ortalamaya eşitse 1, birbirine eşit değilse 0 döndürmesini sağlayın.
            // Dizi boş olmayacak, yalnızca pozitif tamsayılar içerecek ve birden fazla mod içermeyecektir.

            // Örnek girdi: [1, 2, 3]
            //       çıktı: 0
            // Örnek girdi: [4, 4, 4, 6, 2]
            //       çıktı: 1
            // Örnek girdi: [5, 3, 3, 3, 1]
            //       çıktı: 1

            Console.WriteLine("[1, 2, 3] -----> Sonuç: " + MeanMode(new int[] { 1, 2, 3 }));
            Console.WriteLine("[4, 4, 4, 6, 2] -----> Sonuç: " + MeanMode(new int[] { 4, 4, 4, 6, 2 }));
            Console.WriteLine("[5, 3, 3, 3, 1] -----> Sonuç: " + MeanMode(new int[] { 5, 3, 3, 3, 1 }));
            Console.ReadKey();
        }
    }
}
