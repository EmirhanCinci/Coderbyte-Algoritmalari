# 21_PowersOfTwo Algoritma Sorusu

* Kullanıcı tarafından girilen bir pozitif tam sayının 2'nin kuvveti olup olmadığını belirten program

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(PowerOfTwo(16));
// Çıktı: true
Console.WriteLine(PowerOfTwo(1));
// Çıktı: true
Console.WriteLine(PowerOfTwo(124));
// Çıktı: false
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

* Sayının 1 olması durumunda doğrudan true değeri döndürür. Eğer sayı ikiye tam bölünmüyorsa ve sayı 0'a eşit ise false değeri döndürür. Bu koşulların hiçbiri sağlanmazsa sayı 2'ye bölünerek işlem tekrar edilir.

~~~ C#
public static bool PowerOfTwo(int sayi)
{
    if (sayi == 1)
    {
        return true;
    }
    if (sayi % 2 != 0 || sayi == 0)
    {
        return false;
    }
    return PowerOfTwo(sayi / 2);
}
~~~

* Şimdi de PowersOfTwo metodunun farklı yazım şekline bakalım.

* Girilen pozitif tam sayıyı Math.Pow() komutu ile sürekli olarak 2'nin kuvvetleri ile kontrol yapılır. Eğer eşit gelirse true değeri; eğer girilen değer kuvvetlerden büyük geldiğinde false değerini döndüren metottur.

~~~ C#
public static bool PowerOfTwo2(int sayi)
{
    int i = 0;
    while (true)
    {
        if (Math.Pow(2, i) == sayi)
        {
            return true;
        }
        else if (Math.Pow(2, i) > sayi)
        {
            return false;
        }
        i++;
    }
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL:
    Console.Write("Lütfen pozitif bir tam sayı giriniz: ");
    string veri = Console.ReadLine();
    if (!PozitifTamSayiMi(veri))
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Sonuç: " + PowerOfTwo(sayi));
    Console.WriteLine("Sonuç: " + PowerOfTwo2(sayi));

    Console.ReadKey();
}
~~~