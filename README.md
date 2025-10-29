# 📸 HEIC/HCEF → JPG Görsel Dönüştürücü (.NET 6 WinForms)

**HEIC/HEIF tabanlı fotoğrafları Windows’ta kolayca görüntülenebilen JPG formatına dönüştürür.**  
Basit arayüz: kaynak ve hedef klasörü seç, **Başlat**’a tıkla, ilerlemeyi ProgressBar’dan izle.

---

## 🚀 Özellikler

- 🔹 **HEIC / HCEF** dosyalarını yüksek kaliteyle **JPG**’ye dönüştürür  
- 🔹 **Çözünürlük korunur** (varsayılan Quality = 95)  
- 🔹 **ProgressBar** ile anlık ilerleme  
- 🔹 Başarılı / başarısız dönüşüm sayısı bildirimi  
- 🔹 .NET 6 üzerinde Windows Forms arayüz

---

## 🧩 Kullanılan Teknolojiler

- **.NET 6.0 (Windows Forms)**
- [Magick.NET-Q8-AnyCPU](https://www.nuget.org/packages/Magick.NET-Q8-AnyCPU)
- C#

---

## 🧰 Kurulum

1. Depoyu klonla:
   ```bash
   git clone https://github.com/<kullanici_adi>/<repo_adi>.git
2. Projeyi Visual Studio 2022+ ile aç.
3. NuGet paketlerini yükle:
    Magick.NET-Q8-AnyCPU
4. Çalıştır

Kullanım

Kaynak klasör: HEIC/HCEF dosyalarının bulunduğu klasörü seçin.
Hedef klasör: Dönüştürülen JPG’lerin kaydedileceği klasörü seçin.
Başlat butonuna tıklayın.
İşlem sonunda durum penceresi başarı/başarısız sayısını gösterir.
Not: Bazı sistemlerde HEIC/HEIF desteği için HEIF Image Extensions kurulu olmalıdır.

