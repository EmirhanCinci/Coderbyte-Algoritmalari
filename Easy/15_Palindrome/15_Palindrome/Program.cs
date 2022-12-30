using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Palindrome
{
    internal class Program
    {
        // Girilen string bir ifadenin palindrom olup olmadığını kontrol eden metot
        public static bool Palindrome(string veri)
        {
            veri = veri.Replace(" ", "");
            string kontrol = "";
            for (int i = veri.Length - 1; i >= 0; i--)
            {
                kontrol += veri[i];
            }
            if (kontrol == veri)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Palindrom: Tersten okunuşu aynı olan cümle, kelime ve sayılara denir.
            // Bu algoritmada kullanıcının girdiği ifadenin palindrom olup olmadığını belirtin.
            // Örnek girdi: Palindrome("never odd or even")
            //       çıktı: true
            // Örnek girdi: Palindrome("eye")
            //       çıktı: true

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + Palindrome(veri));

            Console.ReadKey();
        }
    }
}
