# 🛒 Market Yönetim ve Satış Otomasyonu (C# .NET WinForms)

[![Language: C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![Framework: .NET Framework](https://img.shields.io/badge/Framework-.NET_WinForms-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Architecture: N-Tier / OOP](https://img.shields.io/badge/Architecture-N--Tier_ClassLib-blue?style=for-the-badge)](https://github.com/MertCinbar/Market_Proje)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)

C# ve Nesne Yönelimli Programlama (OOP) prensipleri kullanılarak geliştirilmiş; **Katmanlı Mimari (Class Library)** yapısına sahip, rol bazlı yetkilendirme (Yönetici, Kasiyer, Müşteri) ve dinamik sepet/kasa yönetimini içeren kapsamlı bir masaüstü otomasyon sistemidir.

---

## 🌟 Öne Çıkan Özellikler

- 👥 **Rol Bazlı Kullanıcı Girişi (`FormGiris`):**
  - **👑 Yönetici (Admin):** Ürün stok ve fiyat güncelleme, kasa durumunu izleme ve ciro denetimi.
  - **💼 Kasiyer:** Hızlı satış ekranı, müşteri sepetini kasadan geçirme, ödeme alma ve fiş oluşturma.
  - **🛒 Müşteri:** Reyon ürünlerini listeleme, sepet oluşturma ve ürün detaylarını inceleme.
- 🧱 **Nesne Yönelimli Programlama (OOP) ve Katmanlı Mimari:**
  - `ISatis` arayüzü (Interface) ile sözleşme tabanlı satış metotları.
  - `BaseSatis` soyut sınıfı (Abstract Class) ile kod tekrarını önleyen kalıtım yapısı.
  - Model sınıfları (`Urun`, `Kullanici`, `Siparis`, `Kasa`, `Fiyatlar`) ile yüksek kapsülleme (Encapsulation).
- 💳 **Dinamik Sepet ve Ödeme Modülü (`FormSepet`, `FormOdeme`):**
  - Ürün adet artırma/azaltma, anlık KDV ve toplam tutar hesaplama, para üstü ve kasa güncelleme.

---

## 🏗️ Katmanlı Mimari ve Sınıf Şeması

Proje, iş mantığını (`ClassLib`) kullanıcı arayüzünden (`MarketProje`) tamamen izole eden **N-Tier (Çok Katmanlı)** bir yapıdadır:

```mermaid
classDiagram
    class ISatis {
        <<interface>>
        +SatisYap()
        +ToplamTutarHesapla()
    }

    class BaseSatis {
        <<abstract>>
        +int SatisId
        +DateTime Tarih
        +double ToplamTutar
        +OdemeAl()
    }

    class Urun {
        +int UrunId
        +string UrunAdi
        +double Fiyat
        +int Stok
    }

    class Kullanici {
        +int KullaniciId
        +string KullaniciAdi
        +string Sifre
        +string Rol
    }

    class Kasa {
        +double Bakiye
        +NakitGiris()
        +KasaRaporuAl()
    }

    ISatis <|.. BaseSatis : Implements
    BaseSatis --> Urun : uses
    BaseSatis --> Kullanici : authorized by
    BaseSatis --> Kasa : updates
```

---

## 🔄 Rol Bazlı Kullanım Akışı

```mermaid
flowchart TD
    Login["🔐 FormGiris (Kullanıcı Doğrulama)"] --> RoleCheck{"Rol Kontrolü"}
    
    RoleCheck -- Yönetici --> Admin["👑 FormYonetici\n- Ürün Fiyatlarını Güncelle\n- Kasa & Ciro Takibi\n- Stok Kontrolü"]
    RoleCheck -- Kasiyer --> Cashier["💼 FormKasiyer\n- Hızlı Barkod / Ürün Satışı\n- Fiş & Ödeme Onayı\n- Kasa Girişi"]
    RoleCheck -- Müşteri --> Customer["🛒 FormMusteri\n- Reyon Gezinme\n- FormSepet ile Ürün Toplama\n- FormOdeme ile Satın Alma"]
```

---

## 📁 Proje Dosya Yapısı

```text
Market_Proje/
├── MarketProje.sln             # Visual Studio Solution Çözüm Dosyası
├── ClassLib/                   # İş Mantığı ve Veri Modeli Katmanı
│   ├── ISatis.cs               # Satış Interface tanımı
│   ├── BaseSatis.cs            # Abstract temel sınıf
│   ├── Urun.cs                 # Ürün entity sınıfı
│   ├── Kullanici.cs            # Kullanıcı ve yetki modelleri
│   ├── Kasa.cs                 # Kasa ve bakiye operasyonları
│   ├── Siparis.cs              # Sipariş nesnesi
│   └── Fiyatlar.cs             # Fiyat yönetimi
└── MarketProje/                # Windows Forms Arayüz Katmanı
    ├── FormGiris.cs            # Kullanıcı login penceresi
    ├── FormYonetici.cs         # Yönetici yönetim ekranı
    ├── FormKasiyer.cs          # Kasiyer hızlı satış ekranı
    ├── FormMusteri.cs          # Müşteri alışveriş ekranı
    ├── FormSepet.cs            # Sepet ve tutar paneli
    └── FormOdeme.cs            # Ödeme alma penceresi
```

---

## 🛠️ Nasıl Çalıştırılır?

1. **Gereksinimler:** Visual Studio 2019 / 2022 (.NET Desktop Development iş yükü ile).
2. **Çalıştırma:**
   - `MarketProje.sln` dosyasını Visual Studio ile açın.
   - Çözümü Derleyin (`Build Solution` - `Ctrl+Shift+B`).
   - `F5` tuşuna basarak projeyi başlatın.

---

## 📜 Lisans

Bu proje eğitim ve portföy amaçlı açık kaynak olarak sunulmuştur.

**Geliştirici:** [Mert Çinbar](https://github.com/MertCinbar)  
*Muğla Sıtkı Koçman Üniversitesi - Bilişim Sistemleri Mühendisliği*
