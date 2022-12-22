# 01_FizzBuzz Algoritma Sorusu

* Kullanıcı tarafından girilen pozitif bir tam sayının 1'den başlayarak girilen sayıya kadar birer birer artarak bir kontrol işlemi yapılır. Eğer sayı 3'e bölünürse ***Fizz***; 5'e bölünürse ***Buzz***; hem 3'e hem 5'e tam bölünürse ***FizzBuzz*** yazdırılır. Sayı bu kurallara uymuyorsa sayının kendisi yazdırılır.

## Örnek Girdi ve Çıktılar

~~~ C#
// Örnek girdi:
Console.WriteLine(FizzBuzz(12));
// Çıktı:
// 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz

// Örnek girdi:
Console.WriteLine(FizzBuzz(16));
// Çıktı:
// 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16

// Örnek girdi:
Console.WriteLine(FizzBuzz(32));
// Çıktı:
// 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32
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

* Hata kontrolümüz yapıldığına göre şimdi gelelim asıl algoritmamızın şartları sağlayacak metodu oluşturalım.

* Console ekranına çıktı verebilmek için boş bir string değişkeni tanımlandı ve for döngüsü oluşturuldu. Buradaki for döngüsü ile 1'den başlayarak girilen sayıya kadar birer birer verilen bölme kurallarına göre sonuc değişkenine ekleme yapılarak devam eder. Son olarak sonuc değişkeni çıktı olarak döndürülür. 

~~~ C#
public static string FizzBuzz(int sayi)
{
    string sonuc = "";
    for (int i = 1; i <= sayi; i++)
    {
        if (i % 3 == 0 && i % 5 != 0)
        {
            sonuc += "Fizz "; 
        }
        else if (i % 5 == 0 && i % 3 != 0)
        {
            sonuc += "Buzz ";
        }
        else if (i % 3 == 0 && i % 5 == 0)
        {
            sonuc += "FizzBuzz ";
        }
        else
        {
            sonuc += i.ToString() + " ";
        }
    }
    return sonuc;
}
~~~

* Aynı işlemi yapan farklı bir FizzBuzz metodunu inceleyelim şimdi de.

* String.Join(); komutu ile dizi içerisindeki elemanları boşluk ile birleştirerek string formata getirilmesini sağladı. 
* Enumerable.Range(); komutu ile 1 ile girilen pozitif tam sayı aralığı belirlendi.
* Select(); komutu ile sayılar tek tek bölme kontrolünden geçerek uygun çıktı seçildi.

~~~ C#
public static string FizzBuzz2(int sayi)
{
    return String.Join(" ", Enumerable.Range(1, sayi)
        .Select(x => x % 15 == 0 ? "FizzBuzz" 
        : x % 3 == 0 ? "Fizz" 
        : x % 5 == 0 ? "Buzz" 
        : x.ToString()));
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
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen bir pozitif tam sayı giriniz.");
        goto CONTROL;
    }
    int sayi = Convert.ToInt32(veri);
    Console.WriteLine("Girmiş " + sayi + " sayısının sonucu: " + FizzBuzz(sayi));
    Console.WriteLine("Girmiş " + sayi + " sayısının sonucu: " + FizzBuzz2(sayi));
    
    Console.ReadKey();
}
~~~