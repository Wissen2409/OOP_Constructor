

// 1. tanımlama yöntemi
Personel p = new Personel();
p.Ad = "Nihat";
p.Soyad = "Şahin";
p.Yas = 30;




// 2 . tanımlama yöntemi 
Personel p1 = new Personel()
{
    Ad = "Nihat",
    Soyad = "Şahin",
    Yas = 60,
};

// Konu : Peki biz nesne heap bölgesinde oluşturulurken verileride yanında götürüp, tek seferde
// bu işlemi yapamaz mıyız ?

// Default Ctor  Çalıştı ve Nesne içerisindeki her bir değişkenin default değerini 
// bellekte allocate etti

Personel p2 = new Personel();
Console.WriteLine(p2.Ad);
Console.WriteLine(p2.Yas);

Personel p3 = new Personel();
Console.WriteLine(p3.Ad);
Console.WriteLine(p3.Yas);


