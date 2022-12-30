# 05_AlphabetSoup Algoritma Sorusu

* İşlevin, iletilen veri string parametresini almasını ve dizeyi harflerle alfabetik sırayla döndürmesini sağlayın. Sayıların ve noktalama işaretlerinin dizeye dahil edilmeyeceğini varsayalım.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(AlphabetSoup("coderbyte"));
// Çıktı:
// bcdeeorty
Console.WriteLine(AlphabetSoup("hooplah"));
// Çıktı:
// ahhloop
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak metot içerisinde bir sonuc değişkeni tanımladık ve bunun yanında bir de harfleri tutabilmek için bir List veri yapısını kullandık. Daha sonra kullanıcının girdiği string formattaki ifadenin harflerini foreach döngüsü ile listemize ekledik. 

* Son olarak listemiz tam olarak oluştuğunda bir alfabetik sıralama yapıldı ve foreach döngüsü yardımıyla sonuc değişkenine tek tek harfler eklendi.

* Ekleme işlemi bittiğinde sonuc değişkeni döndürülür.

~~~ C#
public static string AlphabetSoup(string veri)
{
    string sonuc = "";
    List<char> list = new List<char>();
    foreach (var item in veri)
    {
        if ((item >= 65 && item <= 90) || (item >= 97 && item <= 122))
        {
            list.Add(item);
        }
    }
    list.Sort();
    foreach (var item in list)
    {
        sonuc += item;
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + AlphabetSoup(veri));

    Console.ReadKey();
}
~~~