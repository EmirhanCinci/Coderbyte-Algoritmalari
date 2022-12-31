# 26_SecondGreatLow Algoritma Sorusu

* İşlevin arr'de saklanan sayı dizisini almasını ve bir boşlukla ayrılmış olarak sırasıyla ikinci en düşük ve ikinci en büyük sayıları döndürmesini sağlayın. Dizi boş olmayacak ve en az 2 sayı içerecektir. Sadece iki sayı varsa zor olabilir!

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(SecondGreatLow(new int[]{ 7, 7, 12, 98, 106 }));
// Çıktı: 12 98
Console.WriteLine(SecondGreatLow(new int[]{ 1, 42, 42, 180 }));
// Çıktı: 42 42 
Console.WriteLine(SecondGreatLow(new int[]{ 4, 90 }));
// Çıktı: 90 4
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

* Bu metot ile dizinin en küçük 2. terimini ve dizinin en büyük 2. terimini bulan metottur.

~~~ C#
public static string SecondGreatLow(int[] arr)
{
    string sonuc = "";
    Array.Sort(arr);
    if (arr.Length == 2)
    {
        if (arr[0] == arr[1])
        {
            return arr[0] + " " + arr[0];
        }
    }
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[0] != arr[i])
        {
            sonuc += arr[i].ToString() + " ";
            break;
        }
    }
    for (int i = arr.Length - 2; i >= 0; i--)
    {
        if (arr[arr.Length - 1] != arr[i])
        {
            sonuc += arr[i].ToString();
            break;
        }
    }
    return sonuc;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Kaç terimli bir dizi oluşturacaksınız: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
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
            Console.WriteLine("Hatalı bir giriş yapıldı. Lütfen tekrar deneyiniz.");
            goto CONTROL2;
        }
        dizi[i] = Convert.ToInt32(deger);
    }
    Console.WriteLine("Sonuç: " + SecondGreatLow(dizi));
    Console.ReadKey();
}
~~~