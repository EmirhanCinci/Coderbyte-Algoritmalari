using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_GCF
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığını belirten metot
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

        // Verilen 2 terimli bir integer dizinin ebobunu bulan metot
        public static int GCF(int[] arr)
        {
            int ebob = 1;
            Array.Sort(arr);
            for (int i = 2; i <= arr[0]; i++)
            {
                if (arr[0] % i == 0 && arr[1] % i == 0)
                {
                    ebob = i;
                }
            }
            return ebob;
        }

        static void Main(string[] args)
        {
            // İşlevin, arr'de saklanan ve her zaman yalnızca iki pozitif tam sayı içerecek sayı dizisini almasını ve bunların en büyük ortak çarpanını döndürmesini sağlayın.
            // Örneğin: arr [45, 12] ise, programınız 3 döndürmelidir. Dizide her zaman iki eleman olacak ve bunlar pozitif tamsayılar olacaktır.
            // Örnek girdi: new int[] {1, 6}
            //       çıktı: 1
            // Örnek girdi: new int[] {12, 28}
            //       çıktı: 4

        CONTROL:
            Console.Write("Lütfen 1. pozitif tam sayıyı giriniz: ");
            string veri1 = Console.ReadLine();
            Console.Write("Lütfen 2. pozitif tam sayıyı giriniz: ");
            string veri2 = Console.ReadLine();
            if (!PozitifTamSayiMi(veri1) || !PozitifTamSayiMi(veri2))
            {
                Console.WriteLine("Girilen ifadelerden bazıları ya da hepsi pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi1 = Convert.ToInt32(veri1);
            int sayi2 = Convert.ToInt32(veri2);
            Console.WriteLine("Sonuç: " + GCF(new int[] { sayi1, sayi2 }));

            Console.ReadKey();
        }
    }
}
