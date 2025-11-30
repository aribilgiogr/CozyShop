-- Kategori 1: Kahve Çekirdekleri
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Ethiopia Yirgacheffe', 'Çiçeksi ve meyvemsi notalar', 'Etiyopya''nýn Yirgacheffe bölgesinden özenle seçilmiþ, çiçeksi aromalar ve hafif asiditeyle öne çýkan özel kahve çekirdekleri. Orta kavrulmuþ, tek köken kahve.', 'ethiopia-yirgacheffe.jpg', 2, 185.00, 0, 150, 'BEAN-ETH-001', 1, 1, '2024-03-15', '2024-08-22', 0, 1),
('Colombia Supremo', 'Dengeli ve yumuþak', 'Kolombiya''nýn yüksek rakýmlý bölgelerinden gelen premium kalite çekirdekler. Karamel ve çikolata notalarýyla dengeli bir tat profili sunar.', 'colombia-supremo.jpg', 2, 165.00, 10, 200, 'BEAN-COL-002', 1, 1, '2024-01-20', '2024-09-10', 0, 1),
('Brazil Santos', 'Fýndýk aromalý klasik', 'Brezilya''nýn en popüler kahvesi. Düþük asidite, fýndýk ve kakao notalarýyla yumuþak içim deneyimi.', 'brazil-santos.jpg', 2, 145.00, 0, 180, 'BEAN-BRA-003', 0, 1, '2024-05-08', '2024-10-15', 0, 1),
('Kenya AA', 'Canlý ve ekþimsi', 'Kenya''nýn en yüksek kalite sýnýflandýrmasý. Siyah frenk üzümü ve narenciye notalarýyla parlak asidite.', 'kenya-aa.jpg', 2, 195.00, 0, 120, 'BEAN-KEN-004', 1, 1, '2024-02-11', '2024-11-05', 0, 1),
('Espresso Karýþýmý', 'Güçlü ve kremamsý', 'Özel olarak espresso için hazýrlanmýþ karýþým. %70 Arabica, %30 Robusta ile yoðun crema ve dengeli tat.', 'espresso-blend.jpg', 2, 155.00, 15, 250, 'BEAN-BLE-005', 1, 1, '2024-04-25', '2024-11-20', 0, 1);

-- Kategori 2: Espresso Makineleri
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Delonghi Dedica EC685', 'Kompakt ev tipi makine', 'Ýnce tasarýmýyla mutfaklara uygun profesyonel espresso makinesi. 15 bar pompa basýncý, termostat kontrollü.', 'delonghi-dedica.jpg', 3, 3499.00, 10, 25, 'ESPR-DEL-001', 1, 2, '2024-01-05', '2024-07-18', 0, 1),
('Breville Barista Express', 'Entegre deðirmenli sistem', 'Dahili konik taþ deðirmen, hassas sýcaklýk kontrolü ve otomatik süt köpürtme özelliðine sahip yarý profesyonel makine.', 'breville-barista.jpg', 3, 8999.00, 5, 15, 'ESPR-BRE-002', 1, 2, '2024-03-22', '2024-09-30', 0, 1),
('Gaggia Classic Pro', 'Klasik Ýtalyan tasarým', '58mm profesyonel portafilter, ticari stil grup kafasý ile ev kullanýmý için ideal espresso makinesi.', 'gaggia-classic.jpg', 3, 6799.00, 0, 20, 'ESPR-GAG-003', 0, 2, '2024-06-14', '2024-11-08', 0, 1),
('Rancilio Silvia', 'Profesyonel seviye performans', 'Ticari kalitede bileþenler, pirinç grup kafasý ve güçlü buhar gücü ile ev barista''larý için üst segment makine.', 'rancilio-silvia.jpg', 3, 9999.00, 0, 10, 'ESPR-RAN-004', 1, 2, '2024-02-28', '2024-10-12', 0, 1);

-- Kategori 3: Filtre Kahve Ekipmanlarý
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Hario V60 Dripper', 'Japon el damlatma hunisi', 'Seramik V60 dripper, 1-4 fincan kapasiteli. Spiral kaburga tasarýmý ile mükemmel ekstraksiyon.', 'hario-v60.jpg', 3, 285.00, 0, 80, 'FILT-HAR-001', 1, 3, '2024-01-18', '2024-08-05', 0, 1),
('Chemex 6 Cup', 'Klasik cam demleme kabý', 'Zarif ahþap saplý cam chemex. Kalýn filtreler ile temiz ve berrak kahve.', 'chemex-6cup.jpg', 3, 645.00, 0, 45, 'FILT-CHE-002', 1, 3, '2024-04-09', '2024-10-22', 0, 1),
('Aeropress', 'Taþýnabilir basýnçlý demleme', 'Hýzlý ve kolay kullaným. Hem espresso tarzý hem filtre kahve yapabilme esnekliði.', 'aeropress.jpg', 3, 425.00, 10, 100, 'FILT-AER-003', 1, 3, '2024-02-14', '2024-09-17', 0, 1),
('Kalita Wave 185', 'Düz tabanlý dripper', 'Üç delikli düz taban tasarýmý ile tutarlý ve dengeli ekstraksiyon saðlar.', 'kalita-wave.jpg', 3, 295.00, 0, 60, 'FILT-KAL-004', 0, 3, '2024-05-21', '2024-11-02', 0, 1),
('French Press 1L', 'Klasik batýrma yöntemi', 'Paslanmaz çelik French Press. Zengin body ve tam gövdeli kahve için ideal.', 'french-press.jpg', 3, 385.00, 15, 70, 'FILT-FRE-005', 0, 3, '2024-03-30', '2024-10-18', 0, 1);

-- Kategori 4: Kahve Deðirmenleri
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Baratza Encore', 'Giriþ seviyesi konik deðirmen', '40 öðütme ayarý, tutarlý parçacýk boyutu. Filtre kahve ve espresso için uygun.', 'baratza-encore.jpg', 3, 2499.00, 0, 35, 'GRND-BAR-001', 1, 4, '2024-01-25', '2024-07-30', 0, 1),
('Comandante C40', 'Manuel premium deðirmen', 'El deðirmeni, konik çelik taþlar. Taþýnabilir ve hassas öðütme kalitesi.', 'comandante-c40.jpg', 3, 3799.00, 0, 20, 'GRND-COM-002', 1, 4, '2024-04-17', '2024-10-05', 0, 1),
('Wilfa Svart', 'Ýskandinav tasarým', 'Düz taþ deðirmen, 17 ayar. Sessiz çalýþma ve homojen öðütme.', 'wilfa-svart.jpg', 3, 1899.00, 10, 40, 'GRND-WIL-003', 0, 4, '2024-06-03', '2024-11-12', 0, 1),
('Timemore C2', 'Kompakt el deðirmeni', 'Uygun fiyatlý, paslanmaz çelik taþlar. Seyahat için ideal boyut.', 'timemore-c2.jpg', 3, 899.00, 5, 60, 'GRND-TIM-004', 0, 4, '2024-02-08', '2024-09-25', 0, 1);

-- Kategori 5: Süt Köpürtücüler
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Nanofoamer Pro', 'Mikroköpük teknolojisi', 'Pille çalýþan, profesyonel mikro köpük oluþturucu. Latte art için ideal yoðunluk.', 'nanofoamer-pro.jpg', 3, 549.00, 0, 50, 'FRTH-NAN-001', 1, 5, '2024-03-12', '2024-08-28', 0, 1),
('Severin SM 3590', 'Elektrikli süt köpürtücü', 'Otomatik ýsýtma ve köpürtme. 500ml kapasite, paslanmaz çelik gövde.', 'severin-sm3590.jpg', 3, 849.00, 10, 30, 'FRTH-SEV-002', 0, 5, '2024-05-19', '2024-10-27', 0, 1),
('Bellman Steamer', 'Buhar basýnçlý sistem', 'Stovetop buhar üreteci. Profesyonel süt dokusu ve mikroköpük.', 'bellman-steamer.jpg', 3, 1299.00, 0, 15, 'FRTH-BEL-003', 1, 5, '2024-01-30', '2024-09-08', 0, 1);

-- Kategori 6: Kahve Fincanlarý ve Bardaklar
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Espresso Fincaný Seti', 'Porselen 6''lý set', 'Klasik Ýtalyan tarzý espresso fincanlarý. 60ml, kalýn cidarlý porselen.', 'espresso-cups.jpg', 3, 395.00, 0, 80, 'CUPS-ESP-001', 0, 6, '2024-02-22', '2024-07-14', 0, 1),
('Latte Bardaðý Çift Camlý', 'Termal izolasyonlu', 'Borosilikat cam, çift cidarlý tasarým. 350ml, ýsýyý korur.', 'latte-glass.jpg', 3, 185.00, 15, 100, 'CUPS-LAT-002', 1, 6, '2024-04-05', '2024-11-01', 0, 1),
('Cappuccino Fincaný', 'Geniþ aðýzlý tasarým', 'Latte art için ideal 200ml fincan. Mat beyaz porselen.', 'cappuccino-cup.jpg', 3, 145.00, 0, 120, 'CUPS-CAP-003', 0, 6, '2024-06-18', '2024-10-09', 0, 1),
('Chemex Cam Kupa', 'El üretimi cam', 'Chemex tarzý zarif tasarým. 300ml, ýsýya dayanýklý borosilikat.', 'chemex-mug.jpg', 3, 275.00, 0, 50, 'CUPS-CHE-004', 1, 6, '2024-03-07', '2024-09-21', 0, 1);

-- Kategori 7: Aksesuarlar
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Dijital Terazi 0.1g', 'Hassas ölçüm', 'Timer fonksiyonlu, 2kg kapasiteli profesyonel kahve terazisi. 0.1g hassasiyet.', 'digital-scale.jpg', 3, 485.00, 10, 70, 'ACCS-SCA-001', 1, 7, '2024-01-12', '2024-08-16', 0, 1),
('Tamper 58mm', 'Paslanmaz çelik', 'Aðýr, dengeli tamper. Düz taban, ahþap sap. Profesyonel kalite.', 'tamper-58mm.jpg', 3, 345.00, 0, 60, 'ACCS-TAM-002', 0, 7, '2024-05-26', '2024-11-15', 0, 1),
('Süt Sürahisi 600ml', 'Latte art için', 'Paslanmaz çelik, gaga uçlu. Süt köpürtme ve latte art için ideal.', 'milk-pitcher.jpg', 3, 225.00, 0, 90, 'ACCS-PIT-003', 1, 7, '2024-02-19', '2024-10-03', 0, 1),
('Temizleme Fýrçasý Seti', 'Grup kafasý bakýmý', '3 parçalý fýrça seti. Grup kafasý, portafilter ve deðirmen temizliði.', 'cleaning-brush.jpg', 3, 125.00, 0, 100, 'ACCS-BRU-004', 0, 7, '2024-04-28', '2024-09-13', 0, 1),
('Knock Box', 'Kahve telvesi kutusu', 'Dayanýklý plastik gövde, çýkarýlabilir bar. Sessiz kullaným.', 'knock-box.jpg', 3, 285.00, 5, 55, 'ACCS-KNO-005', 0, 7, '2024-06-07', '2024-11-18', 0, 1);

-- Kategori 8: Yeþil Kahve
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Yeþil Kahve - Honduras', 'Kavurmaya hazýr çekirdek', 'SHG (Strictly High Grown) Honduras yeþil kahve. 1kg paket, ev kavurma için.', 'green-honduras.jpg', 1, 295.00, 0, 50, 'GREE-HON-001', 0, 8, '2024-03-20', '2024-08-11', 0, 1),
('Yeþil Kahve - Guatemala', 'Antigua bölgesi', 'Yüksek rakým Guatemala çekirdeði. Dengeli asidite profili. 1kg.', 'green-guatemala.jpg', 1, 315.00, 0, 40, 'GREE-GUA-002', 1, 8, '2024-01-16', '2024-09-28', 0, 1),
('Yeþil Kahve - Peru Organic', 'Organik sertifikalý', 'Sertifikalý organik Peru kahvesi. Sürdürülebilir tarým. 1kg paket.', 'green-peru.jpg', 1, 335.00, 10, 35, 'GREE-PER-003', 0, 8, '2024-05-13', '2024-10-25', 0, 1);

-- Kategori 9: Kahve Kavurma Makineleri
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Fresh Roast SR540', 'Ev tipi kavurma', 'Otomatik sýcaklýk kontrolü, 120g kapasite. Cam gözlem penceresi.', 'freshroast-sr540.jpg', 3, 4299.00, 0, 12, 'ROAS-FRE-001', 1, 9, '2024-02-03', '2024-07-22', 0, 1),
('Gene Cafe CBR-101', 'Drum kavurma sistemi', '250g kapasite, dijital kontrol paneli. Profesyonel sonuçlar için ev kullanýmý.', 'genecafe-cbr101.jpg', 3, 7999.00, 5, 8, 'ROAS-GEN-002', 1, 9, '2024-04-12', '2024-10-19', 0, 1),
('Behmor 1600 Plus', 'Büyük kapasite', '1 pound kapasiteli, 5 kavurma profili. Duman azaltma teknolojisi.', 'behmor-1600.jpg', 3, 9499.00, 0, 5, 'ROAS-BEH-003', 0, 9, '2024-06-25', '2024-11-07', 0, 1);

-- Kategori 10: Filtreler ve Kaðýtlar
INSERT INTO [coffeeshopdb].[dbo].[Products] ([Name], [ShortDescription], [Description], [Cover], [ProductType], [BasePrice], [DiscountRate], [StockQuantity], [SKU], [IsFeatured], [CategoryId], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
('Hario V60 Filtre 100''lü', 'Beyaz kaðýt filtre', 'VCF-02-100W model, 02 boy V60 için uyumlu. Aðartýlmýþ beyaz kaðýt.', 'hario-v60-filter.jpg', 3, 85.00, 0, 150, 'FILT-HAR-101', 0, 10, '2024-01-09', '2024-06-30', 0, 1),
('Chemex Filtre Bonded', 'Kalýn kaðýt filtre', '100''lü paket, 6-8-10 cup Chemex için. Oksijen aðartmalý.', 'chemex-filter.jpg', 3, 125.00, 0, 120, 'FILT-CHE-102', 1, 10, '2024-03-27', '2024-11-10', 0, 1),
('Kalita Wave 185 Filtre', 'Yassý tabanlý', '50 adet paket, 185 model için özel tasarým. Kahverengi doðal kaðýt.', 'kalita-filter.jpg', 3, 95.00, 10, 100, 'FILT-KAL-103', 0, 10, '2024-05-04', '2024-09-19', 0, 1),
('Aeropress Filtre 350''li', 'Mikro filtre kaðýdý', 'Orijinal Aeropress filtreleri. Ýnce doku, temiz kahve.', 'aeropress-filter.jpg', 3, 65.00, 0, 200, 'FILT-AER-104', 0, 10, '2024-02-16', '2024-08-07', 0, 1),
('Metal Filtre V60', 'Yýkanabilir paslanmaz', 'Kaðýt filtre yerine kullanýlabilir, ekonomik. Tam gövdeli kahve.', 'metal-filter.jpg', 3, 245.00, 0, 45, 'FILT-MET-105', 1, 10, '2024-04-21', '2024-10-14', 0, 1);