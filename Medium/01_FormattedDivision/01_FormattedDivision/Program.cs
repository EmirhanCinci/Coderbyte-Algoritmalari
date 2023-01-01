using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FormattedDivision
{
    internal class Program
    {
        // Girilen string bir ifadenin tam sayıya dönüştürme kontrolünü yapan metot
        public static bool IsInteger(string text)
        {
            try
            {
                int number = Convert.ToInt32(text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Girilen sayıları verilen kurallara göre uygulayan metot 
        public static string FormattedDivision(int num1, int num2)
        {
            double divide = (double)num1 / (double)num2;
            return String.Format("{0:n4}", divide);
            // Virgülden sonra kaç tane sıfır olması gerektiğini n4 ile belirttik. 
        }

        static void Main(string[] args)
        {
        // Girilen num1 ve num2 integer değerler girilecek ve num1 sayısı, num2'ye bölündüğünde sonucu ondalık basamakta virgülden sonra 4 anlamlı basamak içeren bir dize döndüren program.
        // Örnek girdi: FormattedDivision(2, 3)
        //       çıktı: 0,6667
        // Örnek girdi: FormattedDivision(123000, 7)
        //       çıktı: 17.571,4286

        CONTROL1:
            Console.Write("Lütfen bölmek istediğiniz sayıyı giriniz: ");
            string text1 = Console.ReadLine();
            if (!IsInteger(text1))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyiniz...");
                goto CONTROL1;
            }
        CONTROL2:
            Console.Write("Lütfen kaça böleceğinizi yazınız: ");
            string text2 = Console.ReadLine();
            if (!IsInteger(text2))
            {
                Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyiniz...");
                goto CONTROL2;
            }
            int num1 = Convert.ToInt32(text1);
            int num2 = Convert.ToInt32(text2);
            Console.WriteLine(num1 + " / " + num2 + " = " + FormattedDivision(num1, num2));
            Console.ReadKey();
        }
    }
}
