# 33_FindIntersection Algoritma Sorusu

* İşlevin strArr'da saklanan ve 2 öğe içerecek dize dizisini okumasını sağlayın. İlk öğe, artan düzende sıralanmış virgülle ayrılmış sayıların bir listesini temsil edecek, ikinci öğe, virgülle ayrılmış sayıların ikinci bir listesini temsil edecek. Amacınız, strArr öğelerinde oluşan sayıları sıralanmış düzende içeren virgülle ayrılmış bir dize döndürmektir. Kesişme yoksa, dizgeyi false olarak döndürün.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" }));
// Çıktı: 1 4 13
Console.WriteLine(FindIntersection(new string[] { "1, 3, 9, 10, 17, 18", "1, 4, 9, 10" }));
// Çıktı: 1 9 10
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Girilen iki terimli string dizinin içerisindeki pozitif tam sayıları virgül ile ayırarak bir dizi içerisine aktardık.

* Daha sonra dizinin elemanları sırasıyla karşılaştırıldı. Eğer aynı eleman her iki dizide bulunuyorsa string değişkenine eklenir ve bir boşluk bırakılır.

* Son olarak sonuc değişkeninin uzunluğu sıfırdan büyük ise sonuc değişkeni değilse false değeri döndürülür.

~~~ C#
public static string FindIntersection(string[] arr)
{
    string sonuc = "";
    string[] birinci = arr[0].Split(',');
    string[] ikinci = arr[1].Split(',');
    foreach (var b in birinci)
    {
        foreach (var i in ikinci)
        {
            if (b == i)
            {
                sonuc += b + " ";
            }
        }
    }
    if (sonuc.Length > 0)
    {
        return sonuc;
    }
    return "false";
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen birinci diziyi giriniz: ");
    string veri1 = Console.ReadLine();
    Console.Write("Lütfen ikinci diziyi giriniz: ");
    string veri2 = Console.ReadLine();
    Console.WriteLine("Sonuç: " + FindIntersection(new string[] { veri1, veri2 }));

    Console.ReadKey();
}
~~~