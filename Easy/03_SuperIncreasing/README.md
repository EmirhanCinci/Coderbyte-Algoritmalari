# 03_SuperIncreasing Algoritma Sorusu

* İşlevin arr'de saklanan sayı dizisini almasını ve dizinin, dizideki her öğenin önceki tüm öğelerin toplamından daha büyük olduğu bir süper artan dizi oluşturup oluşturmadığını belirlemesini sağlayın. Dizi yalnızca pozitif tam sayılardan oluşacaktır.

## Örnek Girdi ve Çıktılar

~~~ C#
// Örnek girdi:
Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 3, 4 }));
// Çıktı:
// false

// Örnek girdi:
Console.WriteLine(SuperIncreasing(new int[] { 1, 2, 5, 10 }));
// true

// Örnek girdi:
Console.WriteLine(SuperIncreasing(new int[] { 1, 3, 6, 13, 54 }));
// Çıktı:
// true
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Algoritmamızın çalışması için kullanıcıdan bir pozitif tam sayı dizesi almak istiyoruz. Bu nedenle kullanıcı pozitif bir tam sayı haricinde bir ifade girilirse hata vermesi sağlandı.

~~~ C#
public static bool PozitifTamSayiMi(string veri)
{
    try
    {
        int sayi = Convert.ToInt32(veri);
        if (sayi > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    catch (Exception)
    {
        return false;
    }
}
~~~

* Pozitif tam sayılardan oluşan bir integer dizinin artan olup olmadığının kontrolü yapıldı. Elemanları tek tek toplayarak bir sonraki elemandan büyük olma durumuna göre kontrol işlemi yapıldı. Eğer for döngüsü içerisindeki if bloğuna girmezse sonuç süper artandır.

~~~ C#
public static bool SuperIncreasing(int[] arr)
{
    int toplam = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        toplam += arr[i];
        if (toplam >= arr[i + 1])
        {
            return false;
        }
    }
    return true;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile bir pozitif tam sayılar içeren bir dizi oluşturulması sağlandı. İşlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Oluşturacağınız dizi kaç terimli olacak: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Girmiş olduğunuz ifade bir pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL1;
    }
    int terim = Convert.ToInt32(veri);
    int[] dizi = new int[terim];
    for (int i = 0; i < terim; i++)
    {
    CONTROL2:
        Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
        string deger = Console.ReadLine();
        if (!PozitifTamSayiMi(deger))
        {
            Console.WriteLine("Girmiş olduğunuz ifade bir pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = Convert.ToInt32(deger);
    }
    Console.WriteLine("Sonuç: " + SuperIncreasing(dizi));

    Console.ReadKey();
}
~~~