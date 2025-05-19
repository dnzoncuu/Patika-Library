using Patika_Kütüphane;



Kütüphane kitap1 = new Kütüphane("Korku","osho","-",234,"Öncü yayınevi");
kitap1.BilgileriYazdir();

Kütüphane kitap2 = new Kütüphane("Kördüğüm","Ayşe","Kulin",352,"Öncü yayınevi");
kitap2.BilgileriYazdir();

Kütüphane kitap3 = new Kütüphane();

kitap3.KitapAd = "The Witcher";
kitap3.YazarAd = "Andrzej";
kitap3.YazarSoyAd = "Sapkowski";
kitap3.SayfaSayisi = 440;
kitap3.BilgileriYazdir();

