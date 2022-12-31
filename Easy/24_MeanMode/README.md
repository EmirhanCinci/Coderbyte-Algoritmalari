# 24_MeanMode Algoritma Sorusu

* İşlevin arr'de saklanan sayı dizisini almasını ve mod ortalamaya eşitse 1, birbirine eşit değilse 0 döndürmesini sağlayın. Dizi boş olmayacak, yalnızca pozitif tamsayılar içerecek ve birden fazla mod içermeyecektir.


## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(MeanMode(new int[] { 1, 2, 3 }));
// Çıktı: 0
Console.WriteLine(MeanMode(new int[] { 4, 4, 4, 6, 2 }));
// Çıktı: 1
Console.WriteLine(MeanMode(new int[] { 5, 3, 3, 3, 1 }));
// Çıktı: 1
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Bu algoritmanın cevabını bulmak için 2 farklı metot yazarak ana metotta kullandık. Şimdi gelelim ilk yardımcı metodumuza.

* İlk olarak dizinin aritmetik ortalamasını bulan metot oluşturduk. Yani bir toplam değişkeni tanımladık. Daha sonra for döngüsü ile dizinin tüm elemanları toplam değişkeninde toplanıldı. Son olarak bulunan toplam, dizinin eleman sayısına bölünerek ortalama bulundu.

~~~ C#
public static int Ortalama(int[] arr)
{
    int toplam = 0;
    foreach (var item in arr)
    {
        toplam += item;
    }
    return toplam / arr.Length;
}
~~~

* Dizinin içerisinde en çok tekrar eden elemanı yazdırdık bu metodumuz ile.

~~~ C#
public static int ModBulma(int[] arr)
{
    int buyuk = 0;
    int mod = 0;
    int sayac = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
            {
                sayac++;
            }
        }
        if (sayac > buyuk)
        {
            buyuk = sayac;
            mod = i;
        }
        sayac = 0;
    }
    return arr[mod];
}
~~~

* Yukarıda yazdığımız iki metot ile ortalama ve mod'un aynı olup olmadığı kontrol edilir. Eğer aynı ise 1 değeri, değilse 0 değeri döner.

~~~ C#
public static int MeanMode(int[] arr)
{
    if (Ortalama(arr) == ModBulma(arr))
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.WriteLine("[1, 2, 3] -----> Sonuç: " + MeanMode(new int[] { 1, 2, 3 }));
    Console.WriteLine("[4, 4, 4, 6, 2] -----> Sonuç: " + MeanMode(new int[] { 4, 4, 4, 6, 2 }));
    Console.WriteLine("[5, 3, 3, 3, 1] -----> Sonuç: " + MeanMode(new int[] { 5, 3, 3, 3, 1 }));

    Console.ReadKey();
}
~~~