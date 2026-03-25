# 🚀 RapidApiAkademiq Dashboard

Bu proje, **ASP.NET Core MVC** mimarisi kullanılarak geliştirilmiş, 10 farklı dinamik veriyi tek bir ekranda sunan kapsamlı bir **Dashboard** uygulamasıdır. Projedeki tüm veriler **RapidAPI** üzerinden anlık olarak çekilmektedir.

## 🧠 Tasarım ve Yaklaşım
Dashboard tasarım süreci, modern UI/UX prensipleri doğrultusunda **Claude AI** kullanılarak hazırlanmıştır. Proje, modülerliği artırmak ve temiz kod (Clean Code) prensiplerine uymak amacıyla **ViewComponent** yapısı üzerine inşa edilmiştir.

---

## 🔌 Kullanılan API'ler
Proje kapsamında entegre edilen 10 adet API ve görevleri aşağıdadır:

| Veri Başlığı | API Host Adresi | Açıklama |
| :--- | :--- | :--- |
| **Kripto Para** | `coinranking1.p.rapidapi.com` | Güncel kripto para fiyatları ve piyasa verileri. |
| **Döviz Kurları** | `exchange-rates7.p.rapidapi.com` | Anlık döviz kuru değişimleri. |
| **Yemek Tarifi** | `tasty.p.rapidapi.com` | Günün yemek önerisi ve tarif detayları. |
| **Futbol** | `football-prediction-api.p.rapidapi.com` | Güncel futbol maç sonuçları ve analizleri. |
| **Akaryakıt** | `uk-daily-fuel-prices.p.rapidapi.com` | Güncel akaryakıt fiyat verileri. |
| **Film** | `imdb236.p.rapidapi.com` | Günün en popüler filmleri (IMDb verileri). |
| **Müzik** | `spotify23.p.rapidapi.com` | Günün en çok dinlenen şarkıları. |
| **Haberler** | `real-time-news-data.p.rapidapi.com` | 3 adet güncel haber başlığı ve içeriği. |
| **Motivasyon** | `quotes-api12.p.rapidapi.com` | Günün motivasyon sözü. |
| **Hava Durumu** | `open-weather13.p.rapidapi.com` | Güncel hava durumu verileri. |

---

## 🛠 Teknik Özellikler
* **Framework:** .NET Core 8.0 MVC
* **Veri Yönetimi:** `IConfiguration` ve `appsettings.json` ile merkezi API yönetimi.
* **Mimari:** Modüler ViewComponent kullanımı.
* **Güvenlik (Bonus):** API anahtarları `.gitignore` ile korunmakta ve repo içerisinde açıkça paylaşılmamaktadır.
* **Responsive Tasarım (Bonus):** Bootstrap Grid sistemi ile tüm mobil cihazlarla tam uyumluluk.

---

## ⚙️ Kurulum ve Çalıştırma
1.  Projeyi klonlayın: `git clone https://github.com/yasindenizcure/RapidapiAkademiq.git`
2.  Visual Studio ile `.sln` dosyasını açın.
3.  `appsettings.json` dosyasını açın ve `RapidApiConfig:ApiKey` kısmına kendi RapidAPI anahtarınızı ekleyin.
4.  Bağımlılıkları geri yükleyin ve `F5` tuşu ile projeyi çalıştırın.

---
<img width="1862" height="1006" alt="12" src="https://github.com/user-attachments/assets/25fb293f-4a10-4fe0-9d7d-dd56c4757b87" />
<img width="1862" height="1015" alt="13" src="https://github.com/user-attachments/assets/7a19406f-a9dc-452a-8911-72c7170d9046" />
<img width="1862" height="1005" alt="14" src="https://github.com/user-attachments/assets/6c79f394-c4fd-4ac2-911d-dfc206a06f1f" />
<img width="1858" height="1015" alt="15" src="https://github.com/user-attachments/assets/d5a66deb-f262-4d9a-b56b-682e5a6ba617" />
<img width="1863" height="1012" alt="16" src="https://github.com/user-attachments/assets/be056ad9-d94b-4ac7-b5df-81331e6b4063" />
<img width="1870" height="1007" alt="17" src="https://github.com/user-attachments/assets/587478ad-c5a7-4121-b65b-7c7f5c147cb6" />
<img width="1846" height="1010" alt="18" src="https://github.com/user-attachments/assets/96bdf21f-2141-493c-a8af-f79cd1e239b2" />
<img width="1842" height="1012" alt="19" src="https://github.com/user-attachments/assets/c96d654a-b42f-415e-97d9-8b3570578fbf" />
<img width="1855" height="1013" alt="20" src="https://github.com/user-attachments/assets/9a2f3945-548f-43c6-a9a8-c6b26bfcbad8" />
<img width="1843" height="1012" alt="21" src="https://github.com/user-attachments/assets/6159630a-646d-446d-881f-9b95106f528d" />
<img width="1845" height="1011" alt="22" src="https://github.com/user-attachments/assets/f51c6a33-5a25-45e0-8a5f-51eddb114c82" />








