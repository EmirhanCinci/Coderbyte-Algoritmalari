# 40_WordCount Algoritma Sorusu

* İşlevin geçirilen str string parametresini almasını ve dizenin içerdiği kelime sayısını döndürmesini sağlayın. "Asla kıyılmış buğday veya kek yemeyin" ifadesinde 6 değerini döndürür. Kelimeler tek boşlukla ayrılacaktır.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(WordCount("Hello World"));
// Çıktı: 2
Console.WriteLine(WordCount("one 22 three"));
// Çıktı: 3
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Girilen string bir ifadeyi boşluk karakterinden ayırarak kelimeleri bir dize içerisinde topladık.

* Daha sonra dizinin eleman sayısını döndürdük.

~~~ C#
public static int WordCount(string veri)
{
    string[] kelime = veri.Split(' ');
    return kelime.Length;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + WordCount(veri));

    Console.ReadKey();
}
~~~