# 10_TwoSum Algoritma Sorusu

* Integer bir dizideki ilk eleman hariç dizideki herhangi iki elemanın toplamı dizinin ilk elemanını veren tüm sayı çiftlerini yazdıran algoritma. Eğer dizide böyle bir çift yok ise -1 yazdırılmalı.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6, 10, 11, 4, -3, -5, 3, 15, 2, 7 }));
// Çıktı: (6, 11)  (10, 7)  (15, 2)
Console.WriteLine(TwoSum(new int[] { 7, 6, 4, 1, 7, -2, 3, 12 }));
// Çıktı: (6, 1)  (4, 3)
Console.WriteLine(TwoSum(new int[] { 17, 4, 5, 6 }));
// Çıktı: -1
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak dizinin eleman sayısını kullanıcı belirlerken pozitif tam sayı girmeli o nedenle bir hata kontrolü yapıldı. Herhangi bir yanlış ifade girdiğinde programımız kullanıcıyı uyaracak.

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

* Daha sonrasında dizimiz tam sayı dizilerinden oluşacağı için yine bir hata kontrolü yapıldı. Burada ise eğer kullanıcının girdiği ifade tam sayı değilse programımız yine kullanıcıyı uyaracak.

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

* Şimdi gelelim asıl algoritmamızın çıktısını verecek metoda.

* İlk olarak uygun toplam çiftlerini yazdıracağımız içi boş string formatta bir sonuc değişkeni tanımlandı. Daha sonrasında ilk elemana eşit olan toplamları bulmak için tek tek kontrol işlemi yapıldı. Kontrol işlemi doğru ise sayı çiftleri sonuc değişkenine eklendi. 

* Daha sonrasında sonuc değişkenine bir şey yazıldı mı yazılmadı mı onun kontrolünü yapmak için uzunluk kontrolü yapıldı. Eğer değişkenin uzunluğu sıfır ise -1 değeri döndürür. Aksi halde çiftleri döndürür.

~~~ C#
public static string TwoSum(int[] arr)
{
    string sonuc = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[0] == (arr[i] + arr[j]))
            {
                sonuc += "(" + arr[i] + ", " + arr[j] + ") ";
            }
        }
    }
    if (sonuc.Length == 0)
    {
        return "-1";
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Oluşturulacak dizi kaç terimli olsun: ");
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
        Console.Write("Lütfen dizinin " + (i + 1) + ". terimini giriniz: ");
        string deger = Console.ReadLine();
        if (!TamSayiMi(deger))
        {
            Console.WriteLine("Girmiş olduğunuz ifade bir tam sayı değildir. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = Convert.ToInt32(deger);
    }
    Console.WriteLine("Sonuç: " + TwoSum(dizi));

    Console.ReadKey();
}
~~~