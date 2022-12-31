# 38_ThirdGreatest Algoritma Sorusu

* İşlevin strArr'da saklanan dize dizisini almasını ve içindeki üçüncü en büyük sözcüğü döndürmesini sağlayın. 

* Örneğin: strArr ["hello", "world", "before", "all"] ise çıktınız world olmalıdır çünkü "before" 6 harf uzunluğundadır. "hello" ve "world" her ikisi de 5'tir, ancak dizideki son 5 harfli kelime olarak göründüğü için çıktı world olmalıdır. strArr ["hello", "world", "after", "all"] ise, çıktı after olmalıdır çünkü ilk üç kelimenin tümü 5 harf uzunluğundadır, bu nedenle sonuncuyu döndürün.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(ThirdGreatest(new string[] { "hello", "world", "before", "all" }));
// Çıktı: world
Console.WriteLine(ThirdGreatest(new string[] { "hello", "world", "after", "all" }));
// Çıktı: after
Console.WriteLine(ThirdGreatest(new string[] { "coder", "byte", "code" }));
// Çıktı: code
Console.WriteLine(ThirdGreatest(new string[] { "abc", "defg", "z", "hijk" }));
// Çıktı: abc
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Girilen string bir dizideki ifadelerin uzunluklarına göre büyükten küçüğe doğru sıralanmış bir dizi oluşturuldu. Daha sonra bu dizinin 3. elemanını string formatta döndürür.

~~~ C#
public static string ThirdGreatest(string[] arr)
{
    string[] sonuc = arr.OrderByDescending(x => x.Length).ToArray();
    return sonuc[2];
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
            // Dizi en az üç dize olacak ve her dize yalnızca harf içerecektir.
            // Örnek girdi: ["coder", "byte", "code"]
            //       çıktı: code
            // Örnek girdi: ["abc", "defg", "z", "hijk"]
            //       çıktı: abc
    Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "before", "all" }));
    Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "hello", "world", "after", "all" }));
    Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "coder", "byte", "code" }));
    Console.WriteLine("Sonuç: " + ThirdGreatest(new string[] { "abc", "defg", "z", "hijk" }));

    Console.ReadKey();
}
~~~