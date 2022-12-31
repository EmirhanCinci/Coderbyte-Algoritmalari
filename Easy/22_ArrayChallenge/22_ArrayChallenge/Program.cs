using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ArrayChallenge
{
    internal class Program
    {
        // Verilen şartı kontrol eden metot
        public static bool ArrayChallenge(int[] arr)
        {
            Array.Sort(arr);
            int toplam = 0;
            int enBuyuk = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    return false;
                toplam += arr[i];
            }
            return (toplam >= enBuyuk);
        }

        static void Main(string[] args)
        {
            // İşlevin arr'de saklanan sayı dizisini almasını ve dizideki herhangi bir sayı kombinasyonu (en büyük sayı hariç) dizideki en büyük sayıya eşit olacak şekilde
            // toplanabilirse true dizesini döndürmesini sağlayın, aksi takdirde dizeyi false döndürün.

            // Örnek girdi: new int[] {5, 7, 16, 1, 2}
            //       çıktı: false
            // Örnek girdi: new int[] {3, 5, -1, 8, 12}
            //       çıktı: true
            // Örnek girdi: new int[] {4, 6, 23, 10, 1, 3}
            //       çıktı: true

            Console.WriteLine("Girilen Dizi: {5, 7, 16, 1, 2}");
            Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 5, 7, 16, 1, 2 }));

            Console.WriteLine("Girilen Dizi: {3, 5, -1, 8, 12}");
            Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 3, 5, -1, 8, 12 }));

            Console.WriteLine("Girilen Dizi: {4, 6, 23, 10, 1, 3}");
            Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 4, 6, 23, 10, 1, 3 }));

            Console.ReadKey();
        }
    }
}
