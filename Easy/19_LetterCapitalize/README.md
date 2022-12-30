# 19_LetterCapitalize Algoritma Sorusu

* İşlevin geçirilen veri parametresini almasını ve her kelimenin ilk harfini büyük yazmasını sağlayın. Kelimeler sadece bir boşlukla ayrılacaktır.

## Örnek Girdi ve Çıktılar 

~~~ C#
Console.WriteLine(LetterCapitalize("hello world"));
// Çıktı: Hello World
Console.WriteLine(LetterCapitalize("merhaBa HERKESE"));
// Çıktı: Merhaba Herkese
~~~ 

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak yeni içi boş string değişkeni tanımlanır. Daha sonrasında for döngüsü yardımı ile girilen string ifadenin karakterleri tek tek incelenir. Eğer index sıfır ise karakter büyük harfle yazılır veya boşluk karakterinden sonra gelen karakter büyük harfle yazdırılır ve i değişkeni bir arttırılır. Tekrar aynı karakteri yazmasın diye. Eğer bu koşulları sağlamıyorsa doğrudan küçük harf ile karakterler yazılır.

* Son olarak sonuc değişkeni döndürülür.

~~~ C#
public static string LetterCapitalize(string veri)
{
    string sonuc = "";
    for (int i = 0; i < veri.Length; i++)
    {
        if (veri[i] == ' ')
        {
            sonuc += " " + veri[i + 1].ToString().ToUpper();
            i++;
        }
        else if (i == 0)
        {
            sonuc += veri[i].ToString().ToUpper();
        }
        else
        {
            sonuc += veri[i].ToString().ToLower();
        }
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
    Console.WriteLine("Sonuç: " + LetterCapitalize(veri));

    Console.ReadKey();
}
~~~