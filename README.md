#  Patika Kütüphane Kitap Kayıt Uygulaması

Bu proje, C# dili kullanılarak geliştirilen basit bir kitap kayıt uygulamasıdır. Kitaplar, adı, yazar adı-soyadı, sayfa sayısı, yayınevi ve kayıt tarihi ile sisteme kaydedilir. Proje, C# dilinde `class`, `constructor`, `property` ve `new` anahtar kelimelerinin kullanımını öğrenmek amacıyla hazırlanmıştır.

## Özellikler

- Kitap bilgileri nesne olarak tutulur.
- İki farklı `constructor` (yapıcı metot) desteği:
  - **Varsayılan Constructor**: Parametre almaz, kayıt tarihini otomatik atar.
  - **Parametreli Constructor**: Kitap bilgilerini parametre olarak alır, kayıt tarihini otomatik atar.
- Kitap bilgilerini ekrana yazdıran `BilgileriYazdir()` metodu içerir.

##  Örnek Kullanım

```csharp
// Parametreli constructor ile kitap nesnesi oluşturma
Kütüphane kitap1 = new Kütüphane("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
kitap1.BilgileriYazdir();

// Default constructor ile kitap nesnesi oluşturma
Kütüphane kitap2 = new Kütüphane();
kitap2.KitapAd = "The Witcher";
kitap2.YazarAd = "Andrzej";
kitap2.YazarSoyAd = "Sapkowski";
kitap2.SayfaSayisi = 440;
kitap2.YayinEvi = "Öncü Yayınevi";
kitap2.BilgileriYazdir();

 Kullanılan Temel Kavramlar
Class (Sınıf): Nesne yapılarının tanımlandığı şablondur.

Constructor (Yapıcı Metot): Nesne oluşturulduğunda çalışan özel metottur.

Property (Özellik): Sınıf içindeki alanlara (field) dış erişimi sağlar.

new: Bellekte yeni bir nesne oluşturmak için kullanılır.

Amaç
Bu uygulama, C# dilinde nesne yönelimli programlamayı öğrenmek ve temel yapı taşlarını uygulamak için geliştirilmiştir. Eğitim ve kişisel gelişim amacıyla kullanılabilir.
