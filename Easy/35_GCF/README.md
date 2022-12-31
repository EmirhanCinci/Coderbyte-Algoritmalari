# 35_GCF Algoritma Sorusu

*  İşlevin, arr'de saklanan ve her zaman yalnızca iki pozitif tam sayı içerecek sayı dizisini almasını ve bunların en büyük ortak çarpanını döndürmesini sağlayın.

* Örneğin: arr [45, 12] ise, programınız 3 döndürmelidir. Dizide her zaman iki eleman olacak ve bunlar pozitif tamsayılar olacaktır.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(GCF(new int[] {1, 6}));
// Çıktı: 1
Console.WriteLine(GCF(new int[] {12, 28}));
// Çıktı: 4
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

* İlk olarak bir ebob değişkeni tanımlanır ve değerine 1 atanır. Daha sonrasında verilen dizi küçükten büyüğe doğru sıralanır. Daha sonra 2'deb başlayarak girilen sayılardan küçük olan sayıya kadar birer birer kontrol işlemi yapılır. Eğer küçük ve büyük sayıları tam bölen bir sayı bulunrsa ebob o sayıyla değiştirilir. 

* Son olarak ebob değişkeni döndürülür.

~~~ C#
public static int GCF(int[] arr)
{
    int ebob = 1;
    Array.Sort(arr);
    for (int i = 2; i <= arr[0]; i++)
    {
        if (arr[0] % i == 0 && arr[1] % i == 0)
        {
            ebob = i;
        }
    }
    return ebob;
}
~~~


* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen 1. pozitif tam sayıyı giriniz: ");
    string veri1 = Console.ReadLine();
    Console.Write("Lütfen 2. pozitif tam sayıyı giriniz: ");
    string veri2 = Console.ReadLine();
    if (!PozitifTamSayiMi(veri1) || !PozitifTamSayiMi(veri2))
    {
        Console.WriteLine("Girilen ifadelerden bazıları ya da hepsi pozitif tam sayı değildir. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi1 = Convert.ToInt32(veri1);
    int sayi2 = Convert.ToInt32(veri2);
    Console.WriteLine("Sonuç: " + GCF(new int[] { sayi1, sayi2 }));

    Console.ReadKey();
}
~~~