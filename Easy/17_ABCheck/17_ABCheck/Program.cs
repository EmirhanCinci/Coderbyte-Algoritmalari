using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_ABCheck
{
    internal class Program
    {
        // Girilen string bir ifadenin içerisindeki a ve b uzunluklarına verilen kurala uygunluğunu kontrol eden metot
        public static bool ABCheck(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] == 'a' && (i + 4) < text.Length && text[i + 4] == 'b') || (text[i] == 'b' && (i + 4) < text.Length && text[i + 4] == 'a'))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            // Girilen string bir ifadenin içerisindeki a ve b karakterlerinin arası bir kez 3 karakter ise true; değil ise false döndürülmesini sağlayın.
            // Örnek girdi: ABCheck("after badly")
            //       çıktı: false
            // Örnek girdi: ABCheck("Laura sobs")
            //       çıktı: true

            Console.Write("Lütfen bir ifade giriniz: ");
            string text = Console.ReadLine();
            if (ABCheck(text))
            {
                Console.WriteLine("Girmiş olduğunuz ifade kuralı karşılıyor.");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz ifade kuralı karşılamıyor.");
            }

            Console.ReadKey();
        }
    }
}
