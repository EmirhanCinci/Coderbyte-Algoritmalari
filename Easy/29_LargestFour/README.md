# 29_LargestFour Algoritma Sorusu

* İşlevin arr'de saklanan tamsayı dizisini almasını ve en büyük dört öğeyi bulmasını ve toplamlarını döndürmesini sağlayın. 

* Örneğin: arr [4, 5, -2, 3, 1, 2, 6, 6] ise, bu dizideki en büyük dört öğe 6, 6, 4 ve 5'tir ve bu sayıların toplamı 21'dir. Bu nedenle programınız 21 değerini döndürmelidir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(LargestFour(new int[] {1, 1, 1, -5}));
// Çıktı: -2
Console.WriteLine(LargestFour(new int[] {0, 0, 2, 3, 7, 1}));
// Çıktı: 13
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Algoritmamızın çalışması için kullanıcıdan bir pozitif tam sayı girmesini istediğimiz için ilk olarak pozitif tam sayı kontrolü yapılır. Yani kullanıcı pozitif bir tam sayı yerine metinsel ifade, işaretler veya pozitif tam sayı olmayan sayılar girebilir. Bunun için bir hata kontrolü yapıldı.

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

* Kullanıcı tarafından oluşturulacak dizinin elemanların tam sayı olup olmadığını kontrol eden hata kontrol metodudur.

~~~ C#
public static bool TamSayiMi(string veri)
{
    try
    {
        int sayi = Convert.ToInt32(veri);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}
~~~

* İlk olarak bir toplam değişkeni tanımlandı. Daha sonra eğer dizinin eleman sayısı 4 veya daha az ise doğrudan tüm elemanları topladık ve toplam sonucunu döndürdük.

* Eğer dizinin eleman saysısı 4'ten fazla ise dizi küçükten büyüğe doğru sıralanır ve for döngüsü yardımı ile toplam değişkenine son dört terim eklenir.

* Son olarak toplam değişkeni döndürülür.

~~~ C#
public static int LargestFour(int[] arr)
{
    int toplam = 0;
    if (arr.Length <= 4)
    {
        foreach (var item in arr)
        {
            toplam += item;
        }
        return toplam;
    }
    Array.Sort(arr);
    for (int i = arr.Length - 1; i >= arr.Length - 4; i--)
    {
        toplam += arr[i];
    }
    return toplam;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı. 

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Oluşturulacak dizinin kaç terimi olacak: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
        goto CONTROL1;
    }
    int terim = Convert.ToInt32(veri);
    int[] dizi = new int[terim];
    for (int i = 0; i < terim; i++)
    {
    CONTROL2:
        Console.Write("Dizinin " + (i + 1) + ". terimini giriniz: ");
        string deger = Console.ReadLine();
        if (!TamSayiMi(deger))
        {
            Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = Convert.ToInt32(deger);
    }
    Console.WriteLine("Sonuç: " + LargestFour(dizi));

    Console.ReadKey();
}
~~~