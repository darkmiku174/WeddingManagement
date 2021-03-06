USE MASTER
GO
DROP DATABASE IF EXISTS TIECCUOI 

CREATE DATABASE TIECCUOI
USE TIECCUOI
GO

CREATE TABLE DATCOC 
(
	MADC VARCHAR(10) NOT NULL,
	MANV VARCHAR(10) NOT NULL,
	MAKH VARCHAR(10) NOT NULL,
	NGAYDC DATETIME,
	MACTDC VARCHAR(10) NOT NULL,
	CONSTRAINT DC_PK PRIMARY KEY (MADC)
)

CREATE TABLE CTDATCOC 
(
	MACTDC VARCHAR(10) NOT NULL,
	MASANH VARCHAR(10) NOT NULL,
	CA INT,
	NGAYTC DATETIME,
	CONSTRAINT CTDC_PK PRIMARY KEY (MACTDC)
)

CREATE TABLE HOPDONG
(
	MAHD VARCHAR(10) NOT NULL,
	MADC VARCHAR(10) NOT NULL,
	MANV VARCHAR(10) NOT NULL,
	MAKH VARCHAR(10) NOT NULL,
	MACTHD VARCHAR(10) NOT NULL,
	NGAYHD DATETIME,
	MAKM VARCHAR(10),
	CONSTRAINT HD_PK PRIMARY KEY (MAHD)
)

CREATE TABLE CTHOPDONG 
(
	MACTHD VARCHAR(10) NOT NULL,
	TENCODAU NVARCHAR(50) NOT NULL,
	TENCHURE NVARCHAR(50) NOT NULL,
	SOBAN DECIMAL(4),
	SOTIENCOC INT,
	TONGTIEN INT,
	CONSTRAINT CTHD_PK PRIMARY KEY (MACTHD)
)

CREATE TABLE MENU
(
	MAMA VARCHAR(10) NOT NULL,
	TENMA NVARCHAR(50) NOT NULL,
	HINHANH IMAGE,
	GIATIEN INT NOT NULL,
	MOTA NVARCHAR(150),
	CONSTRAINT MENU_PK PRIMARY KEY (MAMA)
)

CREATE TABLE DICHVU
(
	MADV VARCHAR(10) NOT NULL,
	TENDV NVARCHAR(50) NOT NULL,
	HINHANH IMAGE,
	GIATIEN INT NOT NULL,
	MOTA NVARCHAR(150),
	CONSTRAINT DV_PK PRIMARY KEY (MADV)
)

CREATE TABLE KHUYENMAI
(
	MAKM VARCHAR(10) NOT NULL,
	TENKM NVARCHAR(50) NOT NULL,
	HINHANH IMAGE,
	UUDAI INT NOT NULL,
	NGAYBD DATETIME,
	NGAYKT DATETIME,
	MOTA NVARCHAR(150),
	CONSTRAINT KM_PK PRIMARY KEY (MAKM)
)

CREATE TABLE SANH 
(
	MASANH VARCHAR(10) NOT NULL,
	TENSANH NVARCHAR(50) NOT NULL,
	HINHANH IMAGE,
	SOTIENCOC INT,
	MOTA NVARCHAR(150),
	CONSTRAINT SANH_PK PRIMARY KEY (MASANH)
)

CREATE TABLE DSCTMENU
(
	MACTHD VARCHAR(10) NOT NULL,
	MAMA VARCHAR(10) NOT NULL,
	CONSTRAINT DSCTMENU_PK PRIMARY KEY (MACTHD, MAMA)
)

CREATE TABLE DSCTDV
(
	MACTHD VARCHAR(10) NOT NULL,
	MADV VARCHAR(10) NOT NULL,
	CONSTRAINT DSCTDV_PK PRIMARY KEY (MACTHD, MADV)
)

CREATE TABLE KHACHHANG 
(
	MAKH VARCHAR(10) NOT NULL,
	TENKH NVARCHAR(50) NOT NULL,
	SDT VARCHAR(10) NOT NULL,
	EMAIL VARCHAR(50),
	DIACHI NVARCHAR(150),
	CONSTRAINT KH_PK PRIMARY KEY (MAKH)
)

CREATE TABLE NHANVIEN
(
	MANV VARCHAR(10) NOT NULL,
	TENNV NVARCHAR(50) NOT NULL,
	GT INT,
	CHUCVU VARCHAR,
	MUCLUONG INT,
	THUONG INT,
	CONSTRAINT NV_PK PRIMARY KEY (MANV)
)

CREATE TABLE THANHTOANHD
(
	MAHD VARCHAR(10) NOT NULL,
	MANV VARCHAR(10),
	NGAYTT DATETIME,
	TINHTRANG VARCHAR(1),
	SOTIENPS INT,
	MAPHAT VARCHAR(10),
	CONSTRAINT TTHD_PK PRIMARY KEY(MAHD)
)

CREATE TABLE PHIEUPHAT
(
	MAPHAT VARCHAR(10) NOT NULL,
	SONGAYTRE DECIMAL(4),
	DONGIAPHAT INT,
	SOTIENPHAT INT,
	CONSTRAINT PP_PK PRIMARY KEY(MAPHAT)
)

 ALTER TABLE DATCOC ADD CONSTRAINT DC_MANV_FK FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV) 
 ALTER TABLE DATCOC ADD CONSTRAINT DC_MAKH_FK FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH) 
 ALTER TABLE DATCOC ADD CONSTRAINT DC_MACTDC_FK FOREIGN KEY(MACTDC) REFERENCES CTDATCOC(MACTDC) 

 ALTER TABLE CTDATCOC ADD CONSTRAINT CTDATCOC_MASANH_FK FOREIGN KEY(MASANH) REFERENCES SANH(MASANH) 
 
 ALTER TABLE HOPDONG ADD CONSTRAINT HOPDONG_MADC_FK FOREIGN KEY(MADC) REFERENCES DATCOC(MADC) 
 ALTER TABLE HOPDONG ADD CONSTRAINT HOPDONG_MANV_FK FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV) 
 ALTER TABLE HOPDONG ADD CONSTRAINT HOPDONG_MAKH_FK FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
 ALTER TABLE HOPDONG ADD CONSTRAINT HOPDONG_MACTHD_FK FOREIGN KEY(MACTHD) REFERENCES CTHOPDONG(MACTHD)
 ALTER TABLE HOPDONG ADD CONSTRAINT HOPDONG_MAKM_FK FOREIGN KEY(MAKM) REFERENCES KHUYENMAI(MAKM)

 ALTER TABLE DSCTMENU ADD CONSTRAINT DSCTMENU_MACTHD_FK FOREIGN KEY(MACTHD) REFERENCES CTHOPDONG(MACTHD)
 ALTER TABLE DSCTMENU ADD CONSTRAINT DSCTMENU_MAMA_FK FOREIGN KEY(MAMA) REFERENCES MENU(MAMA)

 ALTER TABLE DSCTDV ADD CONSTRAINT DSCTDV_MACTHD_FK FOREIGN KEY(MACTHD) REFERENCES CTHOPDONG(MACTHD)
 ALTER TABLE DSCTDV ADD CONSTRAINT DSCTDV_MADV_FK FOREIGN KEY(MADV) REFERENCES DICHVU(MADV)

 ALTER TABLE THANHTOANHD ADD CONSTRAINT THANHTOANHD_MAHD_FK FOREIGN KEY(MAHD) REFERENCES HOPDONG(MAHD)
 ALTER TABLE THANHTOANHD ADD CONSTRAINT THANHTOANHD_MANV_FK FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
 ALTER TABLE THANHTOANHD ADD CONSTRAINT THANHTOANHD_MAPHAT_FK FOREIGN KEY(MAPHAT) REFERENCES PHIEUPHAT(MAPHAT)


 --THỨ TỰ CHẠY INSERT: MENU -> SẢNH -> KHUYẾN MÃI -> DỊCH VỤ -> KHÁCH HÀNG -> NHÂN VIÊN -> PHIẾU PHẠT -> CT ĐẶT CỌC -> ĐẶT CỌC -> CT HỢP ĐỒNG -> HỢP ĐỒNG -> THANH TOÁN HỢP ĐỒNG -> 2 CÁI DSCT

 --CT ĐẶT CỌC
INSERT INTO CTDATCOC VALUES('CTC01','S1',0,'2020/2/2 02:02:02')
INSERT INTO CTDATCOC VALUES('CTC02','S2',1,'2020/12/12 02:02:02')
INSERT INTO CTDATCOC VALUES('CTC03','S3',0,'2020/2/2 02:02:02')
INSERT INTO CTDATCOC VALUES('CTC04','S4',1,'2020/12/12 02:02:02')

 --CT HỢP ĐỒNG
DELETE FROM CTHOPDONG

INSERT INTO CTHOPDONG VALUES('CTHD01',N'Nguyễn Thị V',N'Nguyễn Văn Z',10,100000000,500000000)
INSERT INTO CTHOPDONG VALUES('CTHD02',N'Nguyễn Thị X',N'Nguyễn Văn Y',10,200000000,650000000)
INSERT INTO CTHOPDONG VALUES('CTHD03',N'Nguyễn Thị U',N'Trần Văn Z',10,400000000,800000000)
INSERT INTO CTHOPDONG VALUES('CTHD04',N'Nguyễn Thị W',N'Trần Văn y',10,500000000,900000000)


 --ĐẶT CỌC
INSERT INTO DATCOC VALUES('C01','NV001','KH001','2020/2/2 02:02:02','CTC01')
INSERT INTO DATCOC VALUES('C02','NV002','KH002','2020/12/12 02:02:02','CTC02')
INSERT INTO DATCOC VALUES('C03','NV006','KH003','2020/2/2 02:02:02','CTC03')
INSERT INTO DATCOC VALUES('C04','NV008','KH004','2020/12/12 02:02:02','CTC04')

 --DỊCH VỤ
INSERT INTO DICHVU VALUES('DV01',N'Đặt bánh cưới',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\DichVu\BanhCuoi.png', SINGLE_CLOB) as Image),2000000,N'Nhà hàng làm bánh cưới cho bữa tiệc.')
INSERT INTO DICHVU VALUES('DV02',N'Hệ thống âm thanh',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\DichVu\AmThanh.png', SINGLE_CLOB) as Image),5000000,N'Nhà hàng cung cấp hệ thống âm thanh cho bữa tiệc.')
INSERT INTO DICHVU VALUES('DV03',N'Hệ thống ánh sáng',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\DichVu\AnhSang.png', SINGLE_CLOB) as Image),7000000,N'Nhà hàng cung cấp hệ thống ánh sáng cho bữa tiệc.')
INSERT INTO DICHVU VALUES('DV04',N'Đặt hoa cưới',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\DichVu\HoaCuoi.png', SINGLE_CLOB) as Image),3000000,N'Nhà hàng cung cấp hoa cho bữa tiệc.')

--DANH SÁCH CT DỊCH VỤ
INSERT INTO  DSCTDV VALUES('CTHD01','DV01')
INSERT INTO  DSCTDV VALUES('CTHD01','DV02')
INSERT INTO  DSCTDV VALUES('CTHD01','DV03')
INSERT INTO  DSCTDV VALUES('CTHD01','DV04')


--DANH SÁCH CT MENU
INSERT INTO DSCTMENU VALUES('CTHD01','M01')
INSERT INTO DSCTMENU VALUES('CTHD01','M05')
INSERT INTO DSCTMENU VALUES('CTHD01','M06')
INSERT INTO DSCTMENU VALUES('CTHD01','M10')
INSERT INTO DSCTMENU VALUES('CTHD01','M11')
INSERT INTO DSCTMENU VALUES('CTHD01','M15')
INSERT INTO DSCTMENU VALUES('CTHD01','M16')
INSERT INTO DSCTMENU VALUES('CTHD01','M20')


--HỢP ĐỒNG
DELETE FROM HOPDONG

INSERT INTO HOPDONG VALUES('HD01','C01','NV001','KH001','CTHD01','2020/2/2 02:02:02','KM01')
INSERT INTO HOPDONG VALUES('HD02','C02','NV002','KH002','CTHD02','2020/12/12 02:02:02','KM02')
INSERT INTO HOPDONG VALUES('HD03','C03','NV006','KH003','CTHD03','2020/2/2 02:02:02','KM03')
INSERT INTO HOPDONG VALUES('HD04','C04','NV008','KH004','CTHD04','2020/12/12 02:02:02','KM04')

--KHÁCH HÀNG
DELETE FROM KHACHHANG

INSERT INTO KHACHHANG VALUES('KH001',N'Nguyễn Văn Z',0123456789,'zzZ@gmail.com',N'123 Hồ Chí Minh.')
INSERT INTO KHACHHANG VALUES('KH002',N'Nguyễn Văn Y',0234567891,'yyY@gmail.com',N'456 Hà Nội.')
INSERT INTO KHACHHANG VALUES('KH003',N'Trần Văn Z',0345678912,'Z888@gmail.com',N'789 Đà Nẵng.')
INSERT INTO KHACHHANG VALUES('KH004',N'Trần Văn Y',0456789123,'Y666@gmail.com',N'678 Hồ Chí Minh.')

--KHUYẾN MÃI
DELETE FROM KHUYENMAI

INSERT INTO KHUYENMAI VALUES('KM01',N'2 NĂM LƯU DẤU VÀNG SON',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\KhuyenMai\2years.png', SINGLE_CLOB) as Image),10,'2020/2/2 02:02:02','2020/12/12 12:12:12',N'Khuyếm mãi giảm giá 5%.')
INSERT INTO KHUYENMAI VALUES('KM02',N'TIỆC CƯỚI VÀNG CHO HÔN NHÂN MỸ MÃN',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\KhuyenMai\GoldenWedding.png', SINGLE_CLOB) as Image),10,'2020/2/2 02:02:02','2020/12/12 12:12:12',N'TẶNG PHÍ PHỤC VỤ. Trang  trí hoa tươi cao cấp.')
INSERT INTO KHUYENMAI VALUES('KM03',N'20 THÁNG 10 – TƯƠI CƯỜI ĐẶT CƯỚI',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\KhuyenMai\20Thang10.png', SINGLE_CLOB) as Image),10,'2020/2/2 02:02:02','2020/12/12 12:12:12',N'Đặc biệt giảm thêm 8% thực đơn. Tặng gói trang trí cao cấp. ')
INSERT INTO KHUYENMAI VALUES('KM04',N'TẤT NIÊN RỘN RÀNG',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\KhuyenMai\TatNienRonRang.png', SINGLE_CLOB) as Image),10,'2020/2/2 02:02:02','2020/12/12 12:12:12',N'Đặc biệt giảm 20%. Menu đa dạng, hấp dẫn.')

 --MENU
DELETE FROM MENU 

INSERT INTO MENU VALUES('M01',N'Salad thịt bò Úc',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\BeefSalad.png', SINGLE_CLOB) as Image),160000,N'Món khai vị.')
INSERT INTO MENU VALUES('M02',N'Salad ức vịt xông khói',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\DuckSalad.png', SINGLE_CLOB) as Image),150000,N'Món khai vị.')
INSERT INTO MENU VALUES('M03',N'Tôm tempura',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\Tempura.png', SINGLE_CLOB) as Image),160000,N'Món khai vị.')
INSERT INTO MENU VALUES('M04',N'Gỏi sò điệp',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\ScallopsSalad.png', SINGLE_CLOB) as Image),130000,N'Món khai vị.')
INSERT INTO MENU VALUES('M05',N'Gỏi nấm hải sản',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\SeafoodMushroomSalad.png', SINGLE_CLOB) as Image),120000,N'Món khai vị.')

INSERT INTO MENU VALUES('M06',N'Súp gà xé nấm hương ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\MushroomChickenSoup.png', SINGLE_CLOB) as Image),120000,N'Món súp.')
INSERT INTO MENU VALUES('M07',N'Súp bào ngư hải sâm  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\AbaloneSoup.png', SINGLE_CLOB) as Image),150000,N'Món súp.')
INSERT INTO MENU VALUES('M08',N'Súp bắp kem thịt cua ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\CrabCreamCornSoup.png', SINGLE_CLOB) as Image),150000,N'Món súp.')
INSERT INTO MENU VALUES('M09',N'Súp rong biển hải sản  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\SeafoodSeaweedSoup.png', SINGLE_CLOB) as Image),120000,N'Món súp.')
INSERT INTO MENU VALUES('M10',N'Súp nấm kim châm ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\NeedleMushroomSoup.png', SINGLE_CLOB) as Image),100000,N'Món súp.')

INSERT INTO MENU VALUES('M11',N'Lẩu hải sản Hàn Quốc + mì ramen  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\KoreanSeafood Hotpot.png', SINGLE_CLOB) as Image),500000,N'Món chính.')
INSERT INTO MENU VALUES('M12',N'Lẩu cua đồng nội + bún tươi  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\CrabHotpot.png', SINGLE_CLOB) as Image),400000,N'Món chính.')
INSERT INTO MENU VALUES('M13',N'Cơm chiên dương châu  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\FriedRice.png', SINGLE_CLOB) as Image),350000,N'Món chính.')
INSERT INTO MENU VALUES('M14',N'Miến xào hải sản   ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\FriedNoodleSeafood.png', SINGLE_CLOB) as Image),350000,N'Món chính.')
INSERT INTO MENU VALUES('M15',N'Cà Ri Bò + Bánh mì  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\BeefCurry.png', SINGLE_CLOB) as Image),400000,N'Món chính.')

INSERT INTO MENU VALUES('M16',N'Trái cây thập cẩm  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\Fruits.png', SINGLE_CLOB) as Image),100000,N'Món tráng miệng.')
INSERT INTO MENU VALUES('M17',N'Rau câu trái cây  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\FruitJelly.png', SINGLE_CLOB) as Image),120000,N'Món tráng miệng.')
INSERT INTO MENU VALUES('M18',N'Bánh tiramisu  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\TiramisuCake.png', SINGLE_CLOB) as Image),150000,N'Món tráng miệng.')
INSERT INTO MENU VALUES('M19',N'Bánh mouse mâm xôi  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\RaspberryMouseCake.png', SINGLE_CLOB) as Image),150000,N'Món tráng miệng.')
INSERT INTO MENU VALUES('M20',N'Chè khúc bạch trái cây  ',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\menu\FruitWhiteTea.png', SINGLE_CLOB) as Image),120000,N'Món tráng miệng.')

--NHÂN VIÊN
INSERT INTO NHANVIEN VALUES('NV001',N'Nguyễn Văn A',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV002',N'Nguyễn Văn B',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV003',N'Nguyễn Văn C',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV004',N'Nguyễn Văn D',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV005',N'Trần Văn A',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV006',N'Trần Văn B',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV007',N'Trần Văn C',0,'N',10,0)
INSERT INTO NHANVIEN VALUES('NV008',N'Trần Văn D',0,'N',10,0)

--PHIẾU PHẠT
INSERT INTO PHIEUPHAT VALUES('PP01',5,10,10000000)
INSERT INTO PHIEUPHAT VALUES('PP02',10,20,20000000)

--SẢNH
INSERT INTO SANH VALUES('S1',N'Virgo',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\Sanh\S1Virgo.png', SINGLE_CLOB) as Image),5000000,N'Sảnh 1.')
INSERT INTO SANH VALUES('S2',N'Aries',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\Sanh\S2Aries.png', SINGLE_CLOB) as Image),5000000,N'Sảnh 2.')
INSERT INTO SANH VALUES('S3',N'Pisces',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\Sanh\S3Pisces.png', SINGLE_CLOB) as Image),7000000,N'Sảnh 3.')
INSERT INTO SANH VALUES('S4',N'Sagittarius',(SELECT * FROM OPENROWSET(BULK N'D:\BaiTapTruong\WeddingManagement\image\Sanh\S4Sagittarius.png', SINGLE_CLOB) as Image),10000000,N'Sảnh 4.')

--THANH TOÁN HỢP ĐỒNG
INSERT INTO THANHTOANHD VALUES('HD01','NV001','2020/2/2 02:02:02',0,10,'PP01')
INSERT INTO THANHTOANHD VALUES('HD02','NV002','2020/12/12 02:02:02',0,10,'PP02')
INSERT INTO THANHTOANHD VALUES('HD03','NV006','2020/2/2 02:02:02',0,10,NULL)
INSERT INTO THANHTOANHD VALUES('HD04','NV008','2020/12/12 02:02:02',0,10,NULL)

--SHOW TẤT CẢ TABLE
SELECT * FROM CTDATCOC
SELECT * FROM CTHOPDONG
SELECT * FROM DATCOC
SELECT * FROM DICHVU
SELECT * FROM DSCTDV
SELECT * FROM DSCTMENU
SELECT * FROM HOPDONG
SELECT * FROM KHACHHANG
SELECT * FROM KHUYENMAI
SELECT * FROM MENU
SELECT * FROM NHANVIEN
SELECT * FROM PHIEUPHAT
SELECT * FROM SANH
SELECT * FROM THANHTOANHD

delete From DSCTMenu Where MACTHD='CTHD02'
