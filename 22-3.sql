﻿--CREATE DATABASE SieuThi
USE SieuThi
Go
create table USERS(
	USERNAME varchar(40) primary key,
	PASS varchar(30),
	HOTEN NVARCHAR(50),
	GIOITINH NVARCHAR(6), 
	EMAIL varchar(50),
	QUYEN int check(QUYEN=1 or QUYEN=0 OR QUYEN=2),--PHÂN QUYỀN VỚI ADMIN VÀ KHÁCH HÀNG
	Del BIT
)
GO
CREATE TABLE HANGHOA(
	MASANPHAM VARCHAR(8) PRIMARY KEY,
	TENSANPHAM NVARCHAR(50),
	SOLUONG INT,
	GIANHAPVAO INT,
	GIABANRA INT,
	NGAYNHAP DATE,
	Del BIT
)
GO
CREATE TABLE KHUYENMAI(
	MAKHUYENMAI VARCHAR(8) PRIMARY KEY,
	TENKHUYENMAI NVARCHAR(30),
	PHANTRAM INT CHECK (PHANTRAM>=0 AND PHANTRAM<=100),
	NGAYBATDAU DATE,
	NGAYKETTHUC DATE,
	Del BIT
)
GO
CREATE TABLE KHACHHANG(
	MAKHACH VARCHAR(8) NOT NULL,
	HOTEN NVARCHAR(50),
	GT NVARCHAR(6),
	NGAYSINH DATE,
	SDT VARCHAR(11),
	DIACHI NVARCHAR(50),
	Del BIT,
	PRIMARY KEY(MAKHACH)
)
GO
CREATE TABLE DONHANG(
	MADONHANG VARCHAR(8) NOT NULL,
	MASANPHAM VARCHAR(8) references HANGHOA(MASANPHAM) NOT NULL,
	NGUOIMUA VARCHAR(8) REFERENCES dbo.KHACHHANG(MAKHACH),
	SOLUONG INT,
	MAKHUYENMAI VARCHAR(8) REFERENCES KHUYENMAI(MAKHUYENMAI),
	NGAYDAT DATE,
	NGAYGIAOHANG DATE,
	NHANVIENGIAODICH VARCHAR(40) REFERENCES dbo.USERS(USERNAME)
	PRIMARY KEY(MADONHANG,MASANPHAM)
)
GO
CREATE VIEW VIEW_DONHANG AS(
SELECT a.MADONHANG,c.HOTEN,b.TENSANPHAM,a.SOLUONG,b.GIABANRA,a.MAKHUYENMAI,a.NGAYDAT,a.NGAYGIAOHANG, a.NHANVIENGIAODICH
FROM dbo.DONHANG AS a, dbo.HANGHOA AS b, dbo.KHACHHANG AS c
WHERE a.MASANPHAM=b.MASANPHAM AND a.NGUOIMUA=c.MAKHACH)
GO
-----------------------------Data-------------------------

INSERT INTO USERS VALUES('admin','1',N'admin','Nam','admin@support.com','2',0)
INSERT INTO USERS VALUES('quanghai142','1',N'Trương Quang Hải','Nam','quanghai14@gmail.com','1',0)
INSERT INTO USERS VALUES('gianghai','1',N'Giang Văn Hải','Nam','gianghai@gmail.com','1',0)
INSERT INTO USERS VALUES('lehiep','1',N'Lê Hoàng Hiệp','Nam','lehiep@gmail.com','1',0)

insert into HANGHOA VALUES('SP151400','TIVI SAMSUNG',6,'20000','50000','20180207',0)
insert into HANGHOA VALUES('SP151401','TIVI LG',6,'20000','50000','20180207',0)
insert into HANGHOA VALUES('SP151402','NOI COM COOKU',6,'10000','12000','20180402',0)
insert into HANGHOA VALUES('SP151403','DIEU HOA PANASONIC',6,'15000','18000','20180402',0)
insert into HANGHOA VALUES('SP151404','TU LANH SAMSUNG',6,'20000','25000','20180402',0)
insert into HANGHOA VALUES('SP151405','LAPTOP SAMSUNG',6,'20000','25000','20180402',0)
insert into HANGHOA VALUES('SP151406','IPX',6,'22000','25000','20180402',0)

INSERT INTO KHUYENMAI VALUES('KM151500','NGÀY 8-3','30','20180308','20180308',0)
INSERT INTO KHUYENMAI VALUES('KM151501','NGÀY 1-5','20','20180501','20180501',0)

INSERT INTO dbo.KHACHHANG VALUES ('KH151600','Quang Hải','Nam','1997-02-14','0989142234','Hà Nội','0')
INSERT INTO dbo.KHACHHANG VALUES ('KH151601','Giang Hải','Nam','1997-06-17','0965196738','Hà Nội','0')
INSERT INTO dbo.KHACHHANG VALUES ('KH151602','Lê Hiệp','Nam','1997-10-17','0127489204','Hà Nội','0')
INSERT INTO dbo.KHACHHANG VALUES ('KH151603','Quỳnh Anh','Nữ','1997-07-30','01665091144','Hà Nội','0')

INSERT INTO DONHANG VALUES('DH151700','SP151462','KH151600','1','KM151500','20180507','20180507','gianghai')
INSERT INTO DONHANG VALUES('DH151701','SP151463','KH151601','1','KM151500','20180507','20180507','gianghai')

--------------PROC------------------
GO
CREATE PROCEDURE UID_DONHANG(
@MADON VARCHAR(8),
@MASP VARCHAR(8),
@KhachHang VARCHAR(8),
@SoLuong INT,
@MAKM VARCHAR(8),
@DATHANG DATE,
@GIAOHANG DATE,
@NVGD VARCHAR(40),
@Statement VARCHAR(10)=''
) AS 
BEGIN
	IF @Statement = 'Selecct'
	BEGIN
		SELECT * FROM dbo.DONHANG WHERE MADONHANG=@MADON AND MASANPHAM=@MASP
	END
	IF @Statement = 'Insert'
	BEGIN
		INSERT INTO dbo.DONHANG
		VALUES  ( @MADON , -- MADONHANG - varchar(8)
		          @MASP , -- MASANPHAM - varchar(8)
				  @KhachHang,
				  @SoLuong,
		          @MAKM , -- MAKHUYENMAI - varchar(8)
		          @DATHANG , -- NGAYDAT - date
		          @GIAOHANG,  -- NGAYGIAOHANG - date
				  @NVGD
		        )
	END
	IF @Statement = 'Delete'
	BEGIN
		DELETE FROM dbo.DONHANG WHERE MADONHANG=@MADON AND MASANPHAM=@MASP
	END
END
GO
CREATE PROCEDURE UID_HANGHOA(
@maSP VARCHAR(8),
@tenSP NVARCHAR(50),
@soluong INT,
@giaNhap INT,
@giaBan INT,
@ngayNhap DATE,
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement ='Select'
	BEGIN
		SELECT * FROM dbo.HANGHOA WHERE MASANPHAM=@maSP
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.HANGHOA VALUES  (
				@maSP , -- MASANPHAM - varchar(8)
		        @tenSP , -- TENSANPHAM - nvarchar(50)
		        @soluong , -- SOLUONG - int
		        @giaNhap , -- GIANHAPVAO - int
		        @giaBan , -- GIABANRA - int
		        @ngayNhap , -- NGAYNHAP - date
		        0  -- Del - bit
				)
	END
	IF @Statement='Update'
	BEGIN
		UPDATE dbo.HANGHOA 
			SET TENSANPHAM=@tenSP,
			SOLUONG=@soluong,
			GIANHAPVAO=@giaNhap,
			GIABANRA=GIABANRA,
			NGAYNHAP=@ngayNhap
		WHERE MASANPHAM=@maSP
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.HANGHOA SET Del=1 WHERE MASANPHAM=@maSP
	END
	IF @Statement = 'Show'
	BEGIN
		UPDATE dbo.HANGHOA SET Del = 0 WHERE MASANPHAM=@maSP
	END
	IF @Statement = 'Delete'
	BEGIN
		DELETE FROM dbo.DONHANG WHERE MASANPHAM=@maSP
		DELETE FROM dbo.HANGHOA WHERE MASANPHAM=@maSP
	END
END
GO
CREATE PROCEDURE UID_KHACHHANG(
@maKH VARCHAR(8),
@HoTen NVARCHAR(50),
@GT NVARCHAR(6),
@NS DATE,
@SDT VARCHAR(11),
@DiaChi NVARCHAR(50),
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT * FROM dbo.KHACHHANG WHERE MAKHACH=@maKH
	END
	IF @Statement='Insert'
	BEGIN
		INSERT INTO dbo.KHACHHANG VALUES  
				( @maKH , -- MAKHACH - varchar(8)
		          @HoTen , -- HOTEN - nvarchar(50)
		          @GT , -- GT - nvarchar(6)
		          @NS , -- NGAYSINH - date
		          @SDT , -- SDT - varchar(11)
		          @DiaChi , -- DIACHI - nvarchar(50)
		          0  -- Del - bit
		        )
	END
	IF @Statement='Hide'
	BEGIN
		UPDATE dbo.KHACHHANG SET Del=1 WHERE MAKHACH=@maKH
	END
	IF @Statement='Show'
	BEGIN
		UPDATE dbo.KHACHHANG SET Del=0 WHERE MAKHACH=@maKH
	END
	IF @Statement='Update'
	BEGIN
		UPDATE dbo.KHACHHANG 
			SET HOTEN=@HoTen,
			GT=@GT,
			NGAYSINH=@NS,
			SDT=@SDT,
			DIACHI=@DiaChi
		WHERE MAKHACH=@maKH	
	END
	IF @Statement ='Delete'
	BEGIN
		DELETE FROM dbo.DONHANG WHERE NGUOIMUA=@maKH
		DELETE FROM dbo.KHACHHANG WHERE MAKHACH=@maKH
	END
END
GO
CREATE PROCEDURE UID_USER(
@userName VARCHAR(40),
@pass VARCHAR(30),
@hoTen NVARCHAR(50),
@gt NVARCHAR(6),
@email VARCHAR(50),
@quyen INT,
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement='Select'
	BEGIN
		SELECT USERNAME,HOTEN,GIOITINH,EMAIL,QUYEN FROM dbo.USERS WHERE USERNAME=@userName
	END
	IF @Statement = 'Insert'
	BEGIN
		INSERT INTO dbo.USERS 
		VALUES  ( @userName , -- USERNAME - varchar(40)
		          @pass , -- PASS - varchar(30)
		          @hoTen , -- HOTEN - nvarchar(50)
		          @gt , -- GIOITINH - nvarchar(6)
		          @email , -- EMAIL - varchar(50)
		          @quyen,  -- QUYEN - int
				  0 -- Del - bit
		        )
	END
	IF @Statement = 'Hide'
	BEGIN
		UPDATE dbo.USERS SET Del = 1 WHERE USERNAME = @userName
	END
	IF @Statement = 'Show'
	BEGIN
		UPDATE dbo.USERS SET Del = 0 WHERE USERNAME = @userName
	END
	IF @Statement = 'Update'
	BEGIN
		UPDATE dbo.USERS 
		SET PASS=@pass,
			HOTEN=@hoTen,
			GIOITINH=@gt,
			EMAIL=@email,
			QUYEN=@quyen
		WHERE USERNAME=@userName
	END
	IF @Statement='Delete'
	BEGIN
		DELETE FROM dbo.DONHANG WHERE NHANVIENGIAODICH=@userName
		DELETE FROM dbo.USERS WHERE USERNAME=@userName
	END
END
GO
CREATE PROCEDURE UID_KHUYENMAI(
@maKM VARCHAR(8),
@tenKM NVARCHAR(30),
@phanTram INT,
@ngayBD DATE,
@ngayKT DATE,
@Statement NVARCHAR(20)=''
) AS
BEGIN
	IF @Statement = 'Select'
	BEGIN
		SELECT * FROM dbo.KHUYENMAI WHERE MAKHUYENMAI=@maKM
	END
	IF @Statement = 'Insert'
	BEGIN
		INSERT INTO dbo.KHUYENMAI
		VALUES  ( @maKM , -- MAKHUYENMAI - varchar(8)
		          @tenKM , -- TENKHUYENMAI - nvarchar(30)
		          @phanTram , -- PHANTRAM - int
		          @ngayBD , -- NGAYKHUYENMAI - date
				  @ngayKT,
		          0  -- Del - bit
		        )
	END
	IF @Statement = 'Hide'
	BEGIN
		UPDATE dbo.KHUYENMAI SET Del = 1 WHERE MAKHUYENMAI=@maKM
	END
	IF @Statement = 'Show'
	BEGIN
		UPDATE dbo.KHUYENMAI SET Del = 0 WHERE MAKHUYENMAI = @maKM
	END
	IF @Statement = 'Update'
	BEGIN
		UPDATE dbo.KHUYENMAI 
		SET TENKHUYENMAI=@tenKM,
			PHANTRAM=@phanTram,
			NGAYBATDAU=@ngayBD,
			NGAYKETTHUC=@ngayKT
		WHERE MAKHUYENMAI=@maKM
	END
	IF @Statement = 'Delete'
	BEGIN
		DELETE FROM dbo.DONHANG WHERE MAKHUYENMAI=@maKM
		DELETE FROM dbo.KHUYENMAI WHERE MAKHUYENMAI=@maKM
	END
END
GO
-------------------VIEW---------------