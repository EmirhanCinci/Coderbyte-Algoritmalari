# 06_SnakeCase Algoritma Sorusu

* İşlevin geçirilen veri parametresini almasını ve her kelimenin küçük harfle yazıldığı ve bitişik kelimelerden bir alt çizgi ile ayrıldığı uygun yılan durumu biçiminde döndürmesini sağlayın. Dize yalnızca harfleri ve her bir sözcüğü ayıran sınırlayıcı noktalama karakterlerinin bazı kombinasyonlarını içerecektir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(SnakeCase("cats AND*Dogs-are Awesome"));
// Çıktı: cats_and_dogs_are_awesome
Console.WriteLine(SnakeCase("a b c d-e-f%g"));
// Çıktı: a_b_c_d_e_f_g
Console.WriteLine(SnakeCase("BOB loves-coding"));
// Çıktı: bob_loves_coding
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen ifadenin çıktısını tutabilmek için bir string değişkeni tanımlandı ve girilen ifadeki karakterler küçük harflere dönüştürüldü.

* Döngü yardımıyla girilen verideki karkaterlerden harf olanları tanımlanan string değişkenine doğrudan ekleriz. Eğer harf değilse tanımlanan string değişkenine bir alt çizgi **("_")** eklenir.

* Son olarak sonuc değişkeni döndürülür.

~~~ C#
public static string SnakeCase(string veri)
{
    string sonuc = "";
    veri = veri.ToLower();
    foreach (var item in veri)
    {
        if (item >= 97 && item <= 122)
        {
            sonuc += item;
        }
        else
        {
            sonuc += "_";
        }
    }
    return sonuc;
}
~~~

* Bir de bu algoritmayı regex kütüphanesini kullanarak yazabiliriz.

* Burada girilen string ifadedeki harfleri küçük harflere dönüştürür. Eğer harf değilse alt çizgi karakterini ekler.

~~~ C#
public static string SnakeCase2(string veri)
{
    return Regex.Replace(veri.ToLower(), "[^a-z]", "_");
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + SnakeCase(veri));
    Console.WriteLine("Sonuç: " + SnakeCase2(veri));

    Console.ReadKey();
}
~~~