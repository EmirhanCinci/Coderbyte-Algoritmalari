# 15_Palindrome Algoritma Sorusu

* Palindrom: Tersten okunuşu aynı olan cümle, kelime ve sayılara denir.

* Bu algoritmada kullanıcının girdiği ifadenin palindrom olup olmadığını belirtin.

## Örnek Girdi ve Çıktılar

~~~ C# 
Console.WriteLine(Palindrome("never odd or even"));
// Çıktı: true
Console.WriteLine(Palindrome("eye"));
// Çıktı: true
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak girilen string bir ifadedeki boşluk karakterleri kaldırıldı. Sonra tersten yazdırdığımızda aynısı olup olmadığını kontrol etmek için kontrol değişkeni tanımlandı.

* Daha sonra kontrol değişkenine for döngüsü ile girilen ifade son karakterden ilk karaktere tek tek yazdırıldı.

* Son olarak kontrol değişkeni ile girilen ifade aynı olup olmadığı kontrol edildi. Eğer aynı ise true değeri; değilse false değeri döner.

~~~ C#
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
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
            // Örnek girdi: Palindrome("never odd or even")
            //       çıktı: true
            // Örnek girdi: Palindrome("eye")
            //       çıktı: true
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + Palindrome(veri));

    Console.ReadKey();
}
~~~