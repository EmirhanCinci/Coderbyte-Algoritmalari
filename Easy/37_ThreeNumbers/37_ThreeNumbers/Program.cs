using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ThreeNumbers
{
    internal class Program
    {
        // Verilen şartları kontrol eden metot
        public static bool ThreeNumbers(string veri)
        {
            string[] kelimeler = veri.Split(' ');
            foreach (var item in kelimeler)
            {
                HashSet<char> list = new HashSet<char>();
                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsNumber(item[i]) && item[i] != item[item.Length - 1] && item[i] != item[item.Length - 2])
                    {
                        if (char.IsNumber(item[i + 1]) && char.IsNumber(item[i + 2]))
                        {
                            return false;
                        }
                    }
                    if (char.IsNumber(item[i]))
                    {
                        list.Add(item[i]);
                    }
                }
                if (list.Count != 3)
                {
                    return false;
                }
                list.Clear();
            }
            return true;
        }

        static void Main(string[] args)
        {
            // İşlevin, iletilen str parametresini almasını ve dizedeki her sözcükte tam olarak üç benzersiz, tek basamaklı tamsayı bulunup bulunmadığını belirlemesini sağlayın.
            // Tamsayılar kelimenin herhangi bir yerinde görünebilir, ancak hepsi birbirine bitişik olamaz.
            // Her kelime, içinde bir yerde tam olarak 3 benzersiz tamsayı içeriyorsa, o zaman diziyi true olarak döndürün, aksi takdirde diziyi false döndürün.
            // Örneğin: str "2hello6o3 wor6l7d2" ise, programınız "true" döndürmelidir, ancak dize "hello268o w6or2l4d" ise, programınız "false" döndürmelidir.
            // Çünkü ilk kelimede tüm tamsayılar birbirine bitişiktir.
            // Örnek girdi: 2a3b5 w1o2r13d g1gg92
            //       çıktı: true
            // Örnek girdi: 21aa3a ggg4g4g6ggg
            //       çıktı: false

            Console.Write("Lütfen bir ifade giriniz: ");
            string veri = Console.ReadLine();
            Console.WriteLine("Sonuç: " + ThreeNumbers(veri));

            Console.ReadKey();
        }
    }
}
