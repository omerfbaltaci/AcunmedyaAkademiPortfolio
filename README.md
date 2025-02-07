# Acunmedya Akademi Portfolio

Bu proje, Acunmedya Akademi kapsamında geliştirilen bir **ASP.NET MVC** tabanlı portföy web uygulamasıdır. Kullanıcılar, kişisel bilgilerini, projelerini ve deneyimlerini sergileyebilecekleri bir portföy sayfası oluşturabilirler.

## Özellikler
- **ASP.NET MVC 5** mimarisi
- **C# dili** ile geliştirilmiş backend
- **HTML, CSS, JavaScript** ile modern ve duyarlı (responsive) arayüz
- **Entity Framework** ile veritabanı yönetimi
- **SQL Server entegrasyonu** (Veri saklama ve yönetimi)
- **Özelleştirilebilir portföy sayfası**
- **Bootstrap ve jQuery desteği**
- **Dinamik içerik yönetimi** (Projeler, beceriler, referanslar vb.)

## Kurulum
### Gereksinimler
- **Visual Studio 2019** veya daha yeni bir sürüm
- **.NET Framework 4.7.2** veya daha güncel bir sürüm
- **SQL Server** ve **SQL Server Management Studio (SSMS)** (Eğer veritabanı kullanıyorsa)
- **NuGet Paketleri** (Gerekli bağımlılıkların yüklenmesi için)

### Projeyi Çalıştırma
1. Bu repoyu yerel makinenize klonlayın veya indirin:
   ```sh
   git clone https://github.com/omerfbaltaci/AcunmedyaAkademiPortfolio.git
   ```
2. Visual Studio ile `AcunmedyaAkademiPortfolio.sln` dosyasını açın.
3. **NuGet bağımlılıklarını yüklemek için:**
   - Visual Studio'da **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** seçeneğini açın.
   - `Restore` seçeneğini kullanarak eksik paketleri yükleyin.
4. **Veritabanını yapılandırma:**
   - `Web.config` dosyasındaki **connection string** ayarlarını kendi veritabanınıza göre güncelleyin.
   - SQL Server üzerinde yeni bir veritabanı oluşturun ve gerekli tabloları migration işlemiyle ekleyin.
5. **Projeyi başlatma:**
   - **F5** tuşuna basarak veya **IIS Express** kullanarak çalıştırın.
   
## Kullanım
### Ana Sayfa
- Kullanıcının temel bilgilerini ve projelerini sergileyen bir portföy sayfasıdır.

### Projeler Sayfası
- Kullanıcının eklediği projeleri listeleyen ve detaylarını gösteren bir bölümdür.

### İletişim Sayfası
- Kullanıcıya mesaj gönderebilecek bir iletişim formu içerir.

### Yönetici Paneli
- Kullanıcı giriş yaparak kendi portföyünü düzenleyebilir, yeni projeler ekleyebilir veya bilgilerini güncelleyebilir.

## Lisans
Bu proje **Apache License 2.0** altında lisanslanmıştır. Daha fazla bilgi için `LICENSE.txt` dosyasına göz atabilirsiniz.
