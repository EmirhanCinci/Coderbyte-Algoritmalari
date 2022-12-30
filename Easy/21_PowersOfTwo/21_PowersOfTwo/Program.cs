using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_PowersOfTwo
{
    internal class Program
    {
        // Girilen string bir ifadenin pozitif tam sayı olup olmadığını belirleyen metot
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

        // İstenilen şartı kontrol eden metot
        public static bool PowerOfTwo(int sayi)
        {
            if (sayi == 1)
            {
                return true;
            }
            if (sayi % 2 != 0 || sayi == 0)
            {
                return false;
            }
            return PowerOfTwo(sayi / 2);
        }

        // İstenilen şartı kontrol eden farklı bir metot
        public static bool PowerOfTwo2(int sayi)
        {
            int i = 0;
            while (true)
            {
                if (Math.Pow(2, i) == sayi)
                {
                    return true;
                }
                else if (Math.Pow(2, i) > sayi)
                {
                    return false;
                }
                i++;
            }
        }

        static void Main(string[] args)
        {
        // Kullanıcı tarafından girilen bir pozitif tam sayının 2'nin kuvveti olup olmadığını belirten program
        CONTROL:
            Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
            string veri = Console.ReadLine();
            if (!PozitifTamSayiMi(veri))
            {
                Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
                goto CONTROL;
            }
            int sayi = Convert.ToInt32(veri);
            Console.WriteLine("Sonuç: " + PowerOfTwo(sayi));
            Console.WriteLine("Sonuç: " + PowerOfTwo2(sayi));

            Console.ReadKey();
        }
    }
}
