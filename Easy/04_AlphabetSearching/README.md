# 04_AlphabetSearching Algoritması

* Metotun, iletilen veri parametresini almasını ve dizide İngiliz alfabesinin her bir harfi varsa diziyi true döndürmesini sağlayın, aksi takdirde diziyi false döndürün.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(AlphabetSearching("zacxyjbbkfgtbhdaielqrm45pnsowtuv"));
// Çıktı: true
Console.WriteLine(AlphabetSearching("abcdefghijklmnopqrstuvwxyyyy"));
// Çıktı: false
Console.WriteLine(AlphabetSearching("abc123456kmo"));
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak metodumuzda ingiliz alfabesini sıralı string olarak tanımladık. Daha sonrasında alfabenin uzunluğu ile ilgili kontrol yapacağımız için bir sayac değişkeni tanımlandı.

* Daha sonrasında alfabenin tüm harflerini tek tek dolaşarak karakter kontrolleri yapılır. Eğer aynı harfı kullanıcının girdiği string değişkeninde var ise sayac değişkeni bir arttırılır ve sıradaki alfabe harfine geçilir çünkü eğer geçilmezse ikinci veya fazla aynı karakter bulabilir. Bunun önüne geçilebilmek için break; komutu kullanıldı.

* Son olarak İngiliz alfabesinin uzunluğu 26 harf olduğu için sayac ile kontrol edildi. Eğer aynı ise true değilse, false değeri döner.

~~~ C#
public static bool AlphabetSearching(string veri)
{
    string alfabe = "abcdefghijklmnopqrstuvwxyz";
    int sayac = 0;
    foreach (var a in alfabe)
    {
        foreach (var v in veri)
        {
            if (a == v)
            {
                sayac++;
                break;
            }
        }
    }
    if (sayac == 26)
    {
        return true;
    }
    return false;
}
~~~

* Başka bir şekilde yazmak istersek eğer Regex kütüphanesi ve hashset veri yapısı ile başka bir metot yazabiliriz. Şimdi gelelim o metodu inceleyelim.

* İlk olarak dizideki harf haricindeki bütün karakterler atılır. Daha sonrasında girilen string ifadesindeki bütün karakterler bir HashSet veri yapısı içerisinde diziye dönüştürülür. Buradaki HashSet kullanılma amacı aynı olan karakterleri bir kez yazdırmak içindir. O nedenle ingiliz alfabesinin harf sayısı kadar dizide eleman olması beklenir. Yani hashSet'in eleman sayısı 26 ise true; değilse false değeri döner.

~~~ C#
public static bool AlphabetSearching2(string veri)
{
    string harfler = Regex.Replace(veri.ToLower(), @"[^a-z]+", "");
    var hashSet = new HashSet<char>(harfler.ToCharArray());
    if (hashSet.Count == 26)
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
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + AlphabetSearching(veri));
    Console.WriteLine("Sonuç: " + AlphabetSearching2(veri));

    Console.ReadKey();
}
~~~
