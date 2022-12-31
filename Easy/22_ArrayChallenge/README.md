# 22_ArrayChallenge Algoritma Sorusu

* İşlevin arr'de saklanan sayı dizisini almasını ve dizideki herhangi bir sayı kombinasyonu (en büyük sayı hariç) dizideki en büyük sayıya eşit olacak şekilde toplanabilirse true dizesini döndürmesini sağlayın, aksi takdirde dizeyi false döndürün.

## Örnek Girdi ve Çıktılar 

~~~ C#
Console.WriteLine(ArrayChallenge(new int[] { 5, 7, 16, 1, 2 }));
// Çıktı: false
Console.WriteLine(ArrayChallenge(new int[] { 3, 5, -1, 8, 12 }));
// Çıktı: true
Console.WriteLine(ArrayChallenge(new int[] { 4, 6, 23, 10, 1, 3 }));
// Çıktı: true
~~~

## Yazdığım Kodları Adım Adım İncelyelim.

* İlk olarak dizideki elemanlar küçükten büyüğe doğru sıralandı ve toplam değişkeni ile en büyük değer belirlendi.

* Daha sonrasında for döngüsü ile dizide aynı eleman olup olmadığı kontrol edildi. Eğer var ise false değeri döndürülür. toplam değişkeni ile son terim hariç toplam'a eklenir.

* Son olarak toplam değişkeni en büyük değerden büyük eşit ise true değeri değilse false değeri döner.

~~~ C#
public static bool ArrayChallenge(int[] arr)
{
    Array.Sort(arr);
    int toplam = 0;
    int enBuyuk = arr[arr.Length - 1];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            return false;
        }
        toplam += arr[i];
    }
    return (toplam >= enBuyuk);
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.WriteLine("Girilen Dizi: {5, 7, 16, 1, 2}");
    Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 5, 7, 16, 1, 2 }));
    Console.WriteLine("Girilen Dizi: {3, 5, -1, 8, 12}");
    Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 3, 5, -1, 8, 12 }));
    Console.WriteLine("Girilen Dizi: {4, 6, 23, 10, 1, 3}");
    Console.WriteLine("Sonuç: " + ArrayChallenge(new int[] { 4, 6, 23, 10, 1, 3 }));
            
    Console.ReadKey();
}
~~~