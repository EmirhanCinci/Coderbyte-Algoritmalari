# 01_FormattedDivision Algoritma Sorusu

* Girilen num1 ve num2 integer değerler girilecek ve num1 sayısı, num2'ye bölündüğünde sonucu ondalık basamakta virgülden sonra 4 anlamlı basamak içeren bir dize döndüren algoritmadır.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(FormattedDivision(2, 3));
// Çıktı: 0,6667
Console.WriteLine(FormattedDivision(123000, 7));
// Çıktı: 17.571,4286
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak kullanıcı tarafından girilen sayıların tam sayı olup olmadıklarını kontrol eden hata kontrol metodudur. Eğer kullanıcı tam sayı girerse true değeri, girmezse false değeri döndürür.

~~~ C#
public static bool IsInteger(string text)
{
    try
    {
        int number = Convert.ToInt32(text);
        return true;
    }
    catch (Exception)
    {
        return false;
    }
}
~~~

* İlk olarak verilen integer sayılarını double veri tipine döndürerek bölme işlemi yapılır ve sonuç double veri tipinde tutulur. Daha sonra string formatta virgülden sonra 4 basamağını dönderdik.

~~~ C#
public static string FormattedDivision(int num1, int num2)
{
    double divide = (double)num1 / (double)num2;
    return String.Format("{0:n4}", divide);
    // Virgülden sonra kaç tane sıfır olması gerektiğini n4 ile belirttik. 
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
CONTROL1:
    Console.Write("Lütfen bölmek istediğiniz sayıyı giriniz: ");
    string text1 = Console.ReadLine();
    if (!IsInteger(text1))
    {
        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyiniz...");
        goto CONTROL1;
    }
CONTROL2:
    Console.Write("Lütfen kaça böleceğinizi yazınız: ");
    string text2 = Console.ReadLine();
    if (!IsInteger(text2))
    {
        Console.WriteLine("Hatalı giriş yapıldı. Tekrar deneyiniz...");
        goto CONTROL2;
    }
    int num1 = Convert.ToInt32(text1);
    int num2 = Convert.ToInt32(text2);
    Console.WriteLine(num1 + " / " + num2 + " = " + FormattedDivision(num1, num2));

    Console.ReadKey();
}
~~~