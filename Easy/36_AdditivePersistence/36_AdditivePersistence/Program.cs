using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_AdditivePersistence
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

        // Girilen pozitif tam sayının basamaklarındaki rakamların toplamını bulan metot
        public static int BasamakToplami(int sayi)
        {
            int toplam = 0;
            while (sayi > 0)
            {
                int kalan = sayi % 10;
                toplam += kalan;
                sayi /= 10;
            }
            return toplam;
        }

        // Verilen şartı sağlayan metot
        public static int AdditivePersistence(int sayi)
        {
            int sonuc = 0;
            if (sayi < 10)
            {
                return sayi;
            }
            while (sayi > 10)
            {
                sonuc = BasamakToplami(sayi);
                sayi = BasamakToplami(sayi);
            }
            return sonuc;
        }

        static void Main(string[] args)
        {
            // İşlevin, her zaman pozitif bir tamsayı olacak olan geçirilmekte olan num parametresini almasını ve tek bir basamağa ulaşana kadar num'daki
            // basamakları toplamanız gereken sayı olan toplama kalıcılığını döndürmesini sağlayın. Örneğin: num 2718 ise programınız 2 döndürmelidir.
            // Çünkü 2 + 7 + 1 + 8 = 18 ve 1 + 8 = 9 ve 9'da durursunuz.

        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Sonuç: " + AdditivePersistence(sayi));

            Console.ReadKey();
        }
    }
}
