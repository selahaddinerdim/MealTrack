 Tamamlananlar
 Proje katmanları oluşturuldu: MealTrack.Domain, MealTrack.Application, MealTrack.Infrastructure, MealTrack.UI.
 Entity Framework Core yapılandırıldı.
 Student, Meal, TurnstilePass gibi domain entity'leri tanımlandı.
 Dependency Injection için temel yapı kuruldu (IRepository<T>, EfRepository<T>).
 Guna UI2 eklendi, modern kullanıcı arayüzü başlangıcı yapıldı.


 
Yapılacaklar Listesi 
---------------------------------

 Mimari
 --------------------------------
 Clean Architecture kurallarına tam uyum
 Uygulama içi servisleri Application.Services altında soyutlamak
 Command-Query Separation (CQRS) yapısını uygulamak (opsiyonel)

 Dependency Injection & Abstraction
 --------------------------------
 Tüm servisleri interface tabanlı hale getirmek
 DI container üzerinden tüm bağımlılıkları yönetmek

 Test & Kalite
--------------------------------
 Unit Test projesi (MealTrack.Tests) oluşturmak
 Service, Validator ve Repository testleri yazmak

 Exception & Validation
--------------------------------

 Global exception handling mekanizması kurmak
 FluentValidation kullanarak form validasyonlarını ayırmak

 Logging
 --------------------------------
 Serilog veya benzeri bir yapı ile log sistemi kurmak
 Log seviyelerini (info, warning, error) ayırmak
 
 Raporlama
 ---------------------------------
 Öğrenciye ve tarihe göre filtreli raporlama ekranı
 Günlük / aylık yemek tüketim istatistikleri


 Akıllı Kullanım Kolaylıkları
 ----------------------------------
 Öğrenci no veya RFID ile hızlı tanıma
 Aynı gün çift yemek yenmişse uyarı sistemi
