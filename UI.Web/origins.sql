-- Origins tablosu için örnek veriler
INSERT INTO [dbo].[Origins] ([Country], [Region], [Farm], [Altitude], [Description], [ImageUrl], [CreatedAt], [UpdatedAt], [Deleted], [Active])
VALUES 
-- Etiyopya
('Etiyopya', 'Yirgacheffe', 'Kochere Kooperatifi', '1800-2200m', 'Yirgacheffe, Etiyopya''nýn en ünlü kahve bölgelerinden biridir. Çiçeksi ve meyvemsi notalarýyla tanýnýr. Kochere bölgesi özellikle kaliteli kahve üretimiyle ünlüdür.', 'origin-ethiopia-yirgacheffe.jpg', '2024-02-15', '2024-09-20', 0, 1),
('Etiyopya', 'Sidamo', 'Guji Bölgesi Çiftlikleri', '1700-2000m', 'Sidamo bölgesi, dengeli asidite ve çikolata notalarýyla bilinen kahveler üretir. Geleneksel iþleme yöntemleriyle üretilen premium kahveler.', 'origin-ethiopia-sidamo.jpg', '2024-03-10', '2024-10-05', 0, 1),
('Etiyopya', 'Harar', 'Harar Geleneksel Çiftlikler', '1500-2100m', 'Dünyanýn en eski kahve üretim bölgelerinden biri. Vahþi, meyve notalarý ve hafif þarap tadý ile karakteristik profile sahip.', 'origin-ethiopia-harar.jpg', '2024-01-22', '2024-08-14', 0, 1),

-- Kolombiya
('Kolombiya', 'Huila', 'Finca El Paraiso', '1600-2000m', 'Huila, Kolombiya''nýn en prestijli kahve bölgesidir. Volkanik topraklar ve ideal iklim koþullarý sayesinde yüksek kaliteli Arabica kahveler üretilir.', 'origin-colombia-huila.jpg', '2024-02-28', '2024-09-15', 0, 1),
('Kolombiya', 'Antioquia', 'Finca La Esperanza', '1400-1800m', 'Medellin bölgesinin kahve üretim merkezi. Karamelli, çikolatalý ve fýndýklý notalarla dengeli kahveler.', 'origin-colombia-antioquia.jpg', '2024-04-12', '2024-10-22', 0, 1),
('Kolombiya', 'Nariño', 'El Tambo Çiftlikleri', '1900-2300m', 'Kolombiya''nýn en yüksek rakýmlý kahve üretim bölgesi. Yoðun tatlar ve parlak asidite ile öne çýkar.', 'origin-colombia-narino.jpg', '2024-03-05', '2024-11-08', 0, 1),

-- Brezilya
('Brezilya', 'Minas Gerais', 'Fazenda Santa Ines', '900-1200m', 'Brezilya kahve üretiminin kalbi. Düþük asidite, fýndýk ve çikolata notalarý ile yumuþak içimli kahveler.', 'origin-brazil-minas.jpg', '2024-01-18', '2024-07-30', 0, 1),
('Brezilya', 'Sul de Minas', 'Fazenda Rainha', '1000-1300m', 'Premium Bourbon çeþitleri yetiþtiren bölge. Tatlý, karamelli ve dengeli tat profili.', 'origin-brazil-sul.jpg', '2024-05-08', '2024-10-18', 0, 1),
('Brezilya', 'Cerrado', 'Cerrado Kooperatifi', '800-1100m', 'Brezilya''nýn ilk coðrafi iþaretli kahve bölgesi. Tutarlý kalite ve düþük asidite ile bilinir.', 'origin-brazil-cerrado.jpg', '2024-02-20', '2024-09-03', 0, 1),

-- Kenya
('Kenya', 'Nyeri', 'Gatomboya Factory', '1700-1900m', 'Kenya AA kahvelerinin en prestijli üretim bölgesi. Siyah frenk üzümü ve narenciye notalarý ile canlý asidite.', 'origin-kenya-nyeri.jpg', '2024-03-14', '2024-11-02', 0, 1),
('Kenya', 'Kirinyaga', 'Barichu Kooperatifi', '1600-1800m', 'Mount Kenya eteklerinde yetiþen kahveler. Kompleks meyve notalarý ve parlak asidite.', 'origin-kenya-kirinyaga.jpg', '2024-04-22', '2024-10-12', 0, 1),

-- Kosta Rika
('Kosta Rika', 'Tarrazu', 'Hacienda Sonora', '1200-1700m', 'Dünyanýn en kaliteli kahve üretim bölgelerinden biri. Temiz tat, parlak asidite ve dengeli gövde.', 'origin-costarica-tarrazu.jpg', '2024-01-30', '2024-08-25', 0, 1),
('Kosta Rika', 'West Valley', 'Finca Palmilera', '1200-1600m', 'Bal ve karamel notalarý ile bilinen bölge. Honey process yöntemiyle iþlenen kahveler.', 'origin-costarica-westvalley.jpg', '2024-05-17', '2024-11-15', 0, 1),

-- Guatemala
('Guatemala', 'Antigua', 'Finca La Azotea', '1500-1700m', 'Volkanik topraklar üzerinde yetiþtirilen kahveler. Çikolata, baharat ve çiçek notalarý.', 'origin-guatemala-antigua.jpg', '2024-02-08', '2024-09-28', 0, 1),
('Guatemala', 'Huehuetenango', 'La Bolsa Çiftliði', '1500-2000m', 'Guatemala''nýn en yüksek ve en uzak kahve bölgesi. Meyve ve çiçek notalarý ile kompleks tatlar.', 'origin-guatemala-huehue.jpg', '2024-04-25', '2024-10-30', 0, 1),

-- Honduras
('Honduras', 'Copan', 'Finca El Cielito', '1200-1600m', 'Maya uygarlýðýnýn merkezi olan bölgede kahve üretimi. Tatlý, dengeli ve temiz kahveler.', 'origin-honduras-copan.jpg', '2024-03-20', '2024-08-11', 0, 1),
('Honduras', 'Marcala', 'COMSA Kooperatifi', '1300-1700m', 'Honduras''un ilk coðrafi iþaretli kahve bölgesi. Organik ve sürdürülebilir üretim.', 'origin-honduras-marcala.jpg', '2024-01-12', '2024-07-22', 0, 1),

-- Peru
('Peru', 'Cajamarca', 'Chirinos Kooperatifi', '1700-2200m', 'Yüksek rakýmda organik kahve üretimi. Narenciye ve çikolata notalarý.', 'origin-peru-cajamarca.jpg', '2024-05-13', '2024-10-25', 0, 1),
('Peru', 'Cusco', 'Machu Picchu Çiftlikleri', '1200-1900m', 'Tarihi Ýnka topraklarýnda üretilen kahveler. Yumuþak, fýndýklý ve dengeli.', 'origin-peru-cusco.jpg', '2024-02-26', '2024-09-17', 0, 1),

-- Endonezya
('Endonezya', 'Sumatra', 'Gayo Daðlarý', '1200-1600m', 'Wet-hulled iþleme yöntemiyle ünlü. Toprak, çikolata ve baharatlý notalar ile tam gövdeli.', 'origin-indonesia-sumatra.jpg', '2024-04-05', '2024-11-10', 0, 1),
('Endonezya', 'Java', 'Ijen Platosu Çiftlikleri', '1400-1800m', 'Tarihi Hollanda plantasyonlarý. Dengeli, hafif tatlý ve temiz içimli kahveler.', 'origin-indonesia-java.jpg', '2024-01-28', '2024-08-19', 0, 1),

-- Ruanda
('Ruanda', 'Nyamasheke', 'Buf Kahve Kooperatifi', '1700-2000m', 'Afrika''nýn yükselen kahve yýldýzý. Çiçeksi, meyvemsi ve parlak asiditeyle öne çýkar.', 'origin-rwanda-nyamasheke.jpg', '2024-03-30', '2024-10-15', 0, 1),

-- Panama
('Panama', 'Boquete', 'Hacienda La Esmeralda', '1400-1800m', 'Geisha çeþidinin dünyaca ünlü üretim yeri. Yasemin, bergamot ve tropik meyve notalarý.', 'origin-panama-boquete.jpg', '2024-05-22', '2024-11-20', 0, 1),

-- Vietnam
('Vietnam', 'Dalat', 'Cau Dat Çiftliði', '1500-1650m', 'Arabica üretiminin merkezi. Çikolata ve karamel notalarý ile orta gövdeli kahveler.', 'origin-vietnam-dalat.jpg', '2024-02-14', '2024-09-05', 0, 1),

-- Yemen
('Yemen', 'Haraz', 'Geleneksel Teraslý Çiftlikler', '2000-2400m', 'Kahvenin doðduðu topraklar. Vahþi, baharat ve kýrmýzý meyve notalarý ile benzersiz karakter.', 'origin-yemen-haraz.jpg', '2024-04-18', '2024-10-28', 0, 1);
