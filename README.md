# OKUL KAYIT SİSTEMİ
Öğrenci,Öğretim Üyesi,Ders bilgileri ekleme,güncelleme,silme işlemleri. Sorgulama,listeleme işlemleri.
# 1	AMAÇ
	Bu projenin amacı bir okuldaki eğitim verilerini yönetmek için bir veri tabanı ve C# Form uygulaması oluşturmaktır. Yani veri tabanı tasarımı, kullanıcı arayüzü geliştirme ve veri manipülasyonu üzerine bir çalışma yapmaktır.

# 2	PROJE DETAYI
Bir okuldaki eğitime ait veriler bir veri tabanında kayıt altına alınmak istenmektedir. Bu kapsamda öğrencilere, derslere ve öğretim üyelerine ait veriler sisteme girilebilecek, güncellenebilecek ve silinebilecektir.
Girilen veriler doğrultusunda aşağıdaki sorgulamalar yapılabilecektir.

• Doğum yeri aynı olan öğrenciler,

• Doğum tarihi aynı olan öğrenciler,

• Girilen şehirde doğmuş olan ve notu girilen değerden yüksek olan öğrenciler,

• Girilen dersten 50'nin altında not alan öğrenciler,

• Girilen öğretim üyesinin (istenirse ID kullanılabilir) ismi belirtilen dersinden geçen ve kalan öğrenci sayısı
Sorgu sonuçları uygun nesne içerisinde gösterilebilecektir.

Yani genel olarak veri tabanına öğrenci, ders ve öğretim üyesi verilerini ekleyebilme, güncelleme, silme gibi işlemleri yapabilmek ve ardından belirli sorgularla veriler üzerinde analizler gerçekleştirebilmektir. Bu sorgular arasında doğum yeri veya tarihi aynı olan öğrencileri bulma, belirli bir şehirde doğmuş ve belirli bir notu almış öğrencileri bulma, belirli bir dersten düşük not alan öğrencileri bulma ve öğretim üyesinin dersinden geçen veya kalan öğrenci sayısını bulma gibi örnekler yer alıyor.

# 3	PROJE YAPISI
# 3.2.1	Projede Kullanılan Teknolojiler ve Araçlar:
Programlama Dili: C#
Veri tabanı: SQL Server Management Studio 19 
Geliştirme Ortamı: Visual Studio 2022

# 3.2.2	Veri Tabanı Bağlantısı:
SQL Server veri tabanıyla etkileşim sağlamak amacıyla, bağlantı dizesi kullanılmıştır. Bağlantı dizesi aşağıdaki parametreleri içermektedir:
SqlConnection baglanti = new SqlConnection(@"Data Source=ICLAL\SQLEXPRESS;Initial Catalog=okulkayit;Integrated Security=True;Trust Server Certificate=True");
“ICLAL\SQLEXPRESS”: SQL sunucusunun adı veya IP adresi
“okulkayit” : Bağlanılacak veri tabanının adı
# 3.2.3	Veri Tabanı İşlemleri:
Bağlantı oluşturulduktan sonra, SQL sorguları veya komutları kullanılarak veri tabanı işlemleri gerçekleştirilir. Bu işlemler, veri ekleme, güncelleme, silme veya sorgulama gibi çeşitli işlemleri içerebilir. Aşağıda kodumda kullandığım bir veri tabanı işlemi örneği verilmiştir:
# EKLEME:
 ![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/208fcdd0-178d-4060-90c5-4a0d801be0fc)
# GÜNCELLEME:           
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/2ea8fc56-5579-4f74-b368-d1347ef98caa)
# SİLME:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/4cd9228b-9d2c-452f-9867-20a60f49deba)

# 4	UYGULAMA TANITIMI
# ANA MENÜ:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/fee15076-c99a-4856-b47e-78b53956f9bf)

# ÖĞRENCİ BİLGİ GİRİŞİ EKRANI:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/fe942faf-f00c-454b-a005-42ceb7eb03c7)
# NOT İŞLEMLERİ EKRANI:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/47e7f694-f1f0-4ae2-83f0-a79736c48774)
# ÖĞRETİM ÜYESİ-DERS İŞLEMLERİ EKRANI:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/0900a237-4ea1-4131-bf1b-99b9b2b8f36a)
# SORGULAMA EKRANI:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/4c7ec207-0b71-4a3a-ba8b-ea8304ff15d4)
# 5	SQL VERİ TABANI TABLOLAR VE İLİŞKİLER
# TABLO İLİŞKİLERİ:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/775cfa25-0bbe-4439-bec3-45b136bfeb3e)
# DERSLER TABLOSU:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/c24e2d2b-2f20-4114-b23c-d1ac9ddb34e5)
# NOTLAR TABLOSU:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/4af89f4a-638c-48a8-9273-4de77b9ce11f)
# ÖĞRENCİLER TABLOSU:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/ca27ddbf-3529-4710-8337-e367ac9d84ae)
# ÖĞRETMENLER TABLOSU:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/dad7f9cd-6d8c-402b-aa11-afb34a1d5edc)
# TABLO SÜTUN ÖZELLİKLERİ:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/8767e987-06c5-43c8-8a33-03422bf3721b)
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/8313cd85-cd4b-4c1d-a901-1732810f819d)
# 6	ÖRNEK ÇIKTILAR:
# Öğrenci Bilgileri Ekleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/3fe656e2-4d08-4bc7-a60d-d4aa0b18d8e2)
# Öğrenci Güncelleme İşlemi:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/9f0deefc-f0d0-45a4-9cbe-a9f63275ce62)
# Öğrenci Silme İşlemi:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/08246bff-0b42-4826-95e6-e0101d8ff4a1)
# Not Kaydetme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/df113cfe-1ec8-419f-86f4-b09daf515416)
# Öğretim Üyesi Ekleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/7eef96fc-3d9d-4e77-bace-35c4893db11a)
# Öğretim Üyesi Bilgisi Güncelleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/e5bf8879-ffc4-41e0-bf53-6beadc7c4bca)
# Ders Ekleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/7a62ea18-9552-4f86-ab9b-aa055824f4f5)
# Ders Bilgisi Güncelleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/f644b231-77a6-4eeb-b15b-3311dec792df)
# Öğretim Üyesi Silme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/009f2263-d789-4e92-bab4-59d007ca70b3)
# Ders Silme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/671bce29-a589-4b51-a95c-1cd99e4dae2e)

# SORGULAMA BUTONLARI ÇIKTILARI:
# Seçilen Derste 50’nin Altında Not Alanları Listeleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/c90a3026-c529-4d01-9716-7368d7af45f2)
# Seçilen Şehirde Notu Girilen Değerden Yüksek Olanlar:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/b871ad55-d294-48a9-ae85-bb4f59c36afa)
# Doğum Tarihi Aynı Olanları Listeleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/bc2b804e-ffdc-4dd2-b376-eedb04622986)
# Doğum Yeri Aynı Olanları Listeleme:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/741a1568-253b-438b-a21f-8d8f135d8742)
# Seçilen Dersten Geçen ve Kalan Öğrenci Sayısı Gösterimi:
![image](https://github.com/iclalcengel/Okul-Kayit-Sistemi/assets/115634785/4d2665e3-ef3a-4c47-8fc3-9997c0019711)


