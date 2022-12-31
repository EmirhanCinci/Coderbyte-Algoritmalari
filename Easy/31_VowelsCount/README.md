# 31_VowelsCount Algoritma Sorusu

* İşlevin, iletilen str string parametresini almasını ve dizenin içerdiği sesli harflerin sayısını döndürmesini sağlayın.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(VowelCount("hello"));
// Çıktı: 2
Console.WriteLine(VowelCount("coderbyte"));
// Çıktı: 3
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak sesli harf sayısını tutmak için bir sesli adlı bir değişken ve sesli harfler dizisi tanımlandı. 

* Daha sonrasında kullanıcı tarafından girilen ifadenin karakter karater kontrolü yapıldı. Yani karakterin sesli harfler dizisinde olup olmadığına bakıldı. Eğer varsa sayac bir arttırılır değilse diğer karaktere geçer.

* Son olarak sesli değişkenini döndürürüz.

~~~ C#
public static int VowelsCount(string veri)
{
    int sesli = 0;
    char[] sesliHarfler = { 'A', 'E', 'I', 'O', 'U', 'Ö', 'İ', 'Ü', 'a', 'e', 'ı', 'o', 'u', 'ö', 'i', 'ü' };
    for (int i = 0; i < veri.Length; i++)
    {
        if (sesliHarfler.Contains(veri[i]))
        {
            sesli++;
        }
    }
    return sesli;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + VowelsCount(veri));

    Console.ReadKey();
}
~~~