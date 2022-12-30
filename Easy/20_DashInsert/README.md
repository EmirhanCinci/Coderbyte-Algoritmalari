# 20_DashInsert Algoritma Sorusu

* İşlevin veri'deki her iki tek sayının arasına tire (' - ') koymasını sağlayın.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine(DashInsert("454793"));
// Çıktı: 4547-9-3
Console.WriteLine(DashInsert("99946"));
// Çıktı: 9-9-946
Console.WriteLine(DashInsert("56730"));
// Çıktı: 567-30
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* Kullanıcı tarafından girilen string formattaki verilerin pozitif tam sayılara dönüştürülüp dönüştürülmediğini kontrol eden hata kontrol metodudur.

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

* Kullanıcı tarafından girilen pozitif tam sayı string değerinin basamak rakamlarını tek tek kontrol eden metottur. For döngüsünde karakter ve sonraki karakterin 2 ile tam bölünüyorsa araya tire işaretini koyar yoksa normal yazdırarak devam eder.

* Son olarak sonuc değişkemi döndürülür.

~~~ C#
public static string DashInsert(string veri)
{
    string sonuc = "";
    for (int i = 0; i < veri.Length - 1; i++)
    {
        if (Convert.ToInt32(veri[i]) % 2 == 1 && Convert.ToInt32(veri[i + 1]) % 2 == 1)
        {
            sonuc += veri[i].ToString() + "-";
        }
        else
        {
            sonuc += veri[i].ToString();
        }
    }
    sonuc += veri[veri.Length - 1];
    return sonuc;
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
        Console.WriteLine("Hatalı giriş yapıldı. Lütfen tekrar deneyiniz.");
        goto CONTROL;
    }
    Console.WriteLine("Sonuç: " + DashInsert(veri));

    Console.ReadKey();
}
~~~