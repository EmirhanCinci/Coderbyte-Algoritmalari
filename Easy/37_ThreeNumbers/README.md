# 37_ThreeNumbers Algoritma Sorusu

* İşlevin, iletilen str parametresini almasını ve dizedeki her sözcükte tam olarak üç benzersiz, tek basamaklı tam sayı bulunup bulunmadığını belirlemesini sağlayın. Tam sayılar kelimenin herhangi bir yerinde görünebilir, ancak hepsi birbirine bitişik olamaz. Her kelime, içinde bir yerde tam olarak 3 benzersiz tamsayı içeriyorsa, o zaman diziyi true olarak döndürün, aksi takdirde diziyi false döndürün.

* Örneğin: str "2hello6o3 wor6l7d2" ise, programınız "true" döndürmelidir, ancak dize "hello268o w6or2l4d" ise, programınız "false" döndürmelidir. Çünkü ilk kelimede tüm tamsayılar birbirine bitişiktir.

## Örnek Girdi ve Çıktılar

~~~ C#
Console.WriteLine("2a3b5 w1o2r13d g1gg92");
// Çıktı: true
Console.WriteLine("21aa3a ggg4g4g6ggg");
// Çıktı: false
~~~

## Yazdığım Kodları Adım Adım İnceleyelim.

* İlk olarak girilen string ifadedeki kelimeleri boşluk karakteri ile ayırarak bir dizi içerisinde topladık. Daha sonra foreach döngüsü ile kelimeleri tek tek kontrol işlemi yapıyoruz.

* Kelimelerin içindeki rakamları tutmak için HashSet veri yapısı kullanıyoruz. for döngüsü ile kontrol işlemine başlıyrouz. İlk kontrolümüz arka arkaya 3 tane rakam gelmesi durumunda false değerini döndüren iç içe if bloklarıdır. Aksi durumda devam eder işlemlere.

* İkinci kontrolümüz ise eğer karakter sayı ise HashSet veri yapımıza ekler. HashSet veri yapısı benzersizleri eklediği için aynı karakter yine gelirse bu sefer eklemez.

* Daha sonra HashSet verimizin içerisindeki eleman sayısı 3 değilse false değeri döndürür. Aksi halde devam eder işlemlere. 

* Eğer foreach döngüsünde false değerlerine ulaşılmazsa true değeri döner.

~~~ C#
public static bool ThreeNumbers(string veri)
{
    string[] kelimeler = veri.Split(' ');
    foreach (var item in kelimeler)
    {
        HashSet<char> list = new HashSet<char>();
        for (int i = 0; i < item.Length; i++)
        {
            if (char.IsNumber(item[i]) && item[i] != item[item.Length - 1] && item[i] != item[item.Length - 2])
            {
                if (char.IsNumber(item[i + 1]) && char.IsNumber(item[i + 2]))
                {
                    return false;
                }
            }
            if (char.IsNumber(item[i]))
            {
                list.Add(item[i]);
            }
        }
        if (list.Count != 3)
        {
            return false;
        }
        list.Clear();
    }
    return true;
}
~~~

* Main metodu içerisine ise kullanıcının uygun yönergeler ile işlemlerin yapılması ve istenilen çıktının console ekranına yazılması sağlandı.

~~~ C#
static void Main(string[] args)
{
    Console.Write("Lütfen bir ifade giriniz: ");
    string veri = Console.ReadLine();
    Console.WriteLine("Sonuç: " + ThreeNumbers(veri));

    Console.ReadKey();
}
~~~