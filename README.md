# Flight-Resarvation

Bu Proje Neredeyse benim ilk c# projem diyebiliriz. İlk dönem ki birazcık C bilgimle beraber uzun araştırmalar sonucu basit ama Çook fazla Sınıf yapısından oluşan bir Uçak Rezervasyon sistemi yapmaya çalıştım.
Uçak, Müşteri, Lokasyon, Rezervasyon, Gibi temel classlarımız mevcut. Programım İlk başta aynı gerçek bir uçak rezervasyon sistemi gibi sizin konumunuzu ve nereye gitmek istediğiniz Soruyor.
ŞİMDİLİK yaklaşık 5 adet Ülke, 25 Şehir, Ve Yaklaşık 30 adet Havalimanı mevcut. Bu bilgileri Program içinde List Yapısında Kullandık.
Konumunuzu ve Gideceğiniz yeri seçtikten sonra sizden uçuş tarihi girmenizi istiyor. Tarihi girdikten sonra ise Klasik müşteri bilgileri olan AD, SOYAD, YAŞ, TELEFON NUMARASI, CİNSİYET VE TC KİMLİK NUMARANIZI girmenizi istiyor. 
Burada program içinde Telefon numarasına ve Kimlik bilgilerini girerken belirli kıstılamalar getirdim. Yani Telefon numarası girerken maksimum 10 karakter girmenizi istiyorum Eğer Yanlış tuşlama veya basında 0 olarak Telefon numarası girerseniz, Program size Uyarı veriyor ve tekrar giriş yapmanızı istiyor.
Kimlik girişindede aynı şekilde 11 karakteri doğru girdiğinizde kabul ediyor. Eksik yada Harf kullanımı yaparsanız Hata uyarısı verip tekrar denemenizi istiyor.
Bütün bu bilgileri girdikten sonra sizleri Açıklama ekranı karşılıyor. İlk olarak Konumunuzu - Gideceğiniz Konumu - UÇUŞ Tarihinizi - Ad - Soyad - Uçak bilginizi - Koltuk Numaranızı - Ve Ücretinizi Görüyorsunuz.
Burada gördüğünüz Uçak ve ücret sistemini Random olarak görüyorsunuz. Uçak classımızda 4 Farklı Uçak modeli bulunmakta ve her seçiminizde random olarak size bir uçak gösteriyor.
Ücret kısmı da aynı şekilde 2000-15000 Arasından Random bir sayı veriyor ve buda sizin uçak biletinizin ücreti olarak gözükmekte.
Açıkcası çok fazla karışık olduğunu hissediyorum. Vize Notumu aldıktan sonra Yüksek ihtimalle üzerinde biraz daha çalışıp Hata sistemini bütün girişlere eklemeyi, Daha Fazla Ülke, Şehir ve Havalimanı Eklemeyi düşünüyorum. Belki daha sonralarda bu bilgileri bir exel dosyasından çekip bir text dosyasına da yazdıma ekleyebilirim.
Programın KOD kısımlarında olabildiğince İngilizce kelimeler ve harfler kullanmaya çalıştım. GituHuba yüklediğimiz için. Belki ilerleyen dönemlerde Projeyi Komple İngilizceye çevirebilirim..
