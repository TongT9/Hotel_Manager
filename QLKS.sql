CREATE Database QLKS
GO
USE QLKS
go

CREATE TABLE CHUCVU (MaCV varChar(10) primary key, TenCV nVarChar(50),
);
go
CREATE TABLE TAIKHOAN (MaTK Varchar(10) primary key, TenDangNhap nVarchar(50),  MatKhau nVarchar(50), 
);
go
CREATE TABLE KHACHHANG (MaKH varChar(10) primary key, HoTenKH nVarChar(50), DiaChi nVarChar(50), GioiTinh bit, CMND varChar(10), SDT nvarchar(10), QuocTich nvarchar(50),
);
go
CREATE TABLE LOAIPHONG (MaLP varChar(10) primary key, TenLP nVarChar(50), TrangThietBi nVarChar(50),
);
go
CREATE TABLE NHANVIEN (MaNV varchar(10) primary key, HoTenNV nvarchar(50),  GioiTinh bit, NgaySinh date, SDT nvarchar(10), DiaChi nvarchar(50), MaCV varchar(10), MaTK Varchar(10),
);
go
CREATE TABLE PHONG (MaPhong varchar(10) primary key, TenPhong varchar(10), MaLP varchar(10), TinhTrang bit, GiaPhong int, DonVi varchar(10),
);
go
CREATE TABLE HOADON (MaHD varchar(10) primary key, NgayThanhToan date,  SoTienDatTruoc varchar(20), DonVi varchar(10), MaNV varchar(10), MaKH VARCHAR(10), MaPhong VARCHAR(10), MaLP VARCHAR(10), MaBooking VARCHAR(10), tongtien INT,
);
go
CREATE TABLE PHIEUDICHVU (MaPDV varchar(10) primary key, TenDV nvarchar(50), GiaDV int, 
);
go
CREATE TABLE PHIEUDANGKY (MaPDK varchar(10) primary key , MaKH varchar(10), MaNV varchar(10), NgayLap date, NgayDi date, MaPhong varchar(10), TraTruoc int, DonVi varchar(10), MaPDV varchar(10),
);
GO
CREATE TABLE Booking(Mabooking VARCHAR(10) PRIMARY KEY, Tenbooking NVARCHAR(50),
);
GO
CREATE TABLE CHITIETPHIEU(maphieu VARCHAR(10) primary key, MaPDV VARCHAR(10),soluong int, giadv int, thanhtiendv int, MaLP VARCHAR(10), Mabooking VARCHAR(10), sokhach INT, ngayvao DATETIME, GiaPhong INT, MaPhong VARCHAR(10), MaKH VARCHAR(10), QuocTich NVARCHAR(50),ngaydi DATETIME, sodem INT, thanhtien INT,  TinhTrang NVARCHAR(50));
GO
CREATE TABLE NOIQUY(NQ1 NVARCHAR(500), NQ2 NVARCHAR(500), NQ3 NVARCHAR(500), NQ4 NVARCHAR(500), NQ5 NVARCHAR(500),
);
GO




ALTER TABLE NHANVIEN ADD CONSTRAINT FK_NHANVIENCV FOREIGN KEY (MaCV) REFERENCES CHUCVU(MaCV)
ALTER TABLE PHONG ADD CONSTRAINT FK_PHONGLOAIPHONG FOREIGN KEY (MaLP) REFERENCES LOAIPHONG(MaLP)
ALTER TABLE HOADON ADD CONSTRAINT FK_HOADONNHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_HOADONKH FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH)
ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_HOADONPHONG FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_HOADONLOAIPHONG FOREIGN KEY (MaLP) REFERENCES dbo.LOAIPHONG(MaLP)
ALTER TABLE dbo.HOADON ADD CONSTRAINT FK_HOADONBOOKING FOREIGN KEY (Mabooking) REFERENCES dbo.Booking(Mabooking)
ALTER TABLE PHIEUDANGKY ADD CONSTRAINT FK_PHIEUDANGKYKHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
ALTER TABLE PHIEUDANGKY ADD CONSTRAINT FK_PHIEUDANGKYNHANVIEN FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
ALTER TABLE PHIEUDANGKY ADD CONSTRAINT FK_PHIEUDANGPHONG FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong)
ALTER TABLE PHIEUDANGKY ADD CONSTRAINT FK_PHIEUDANGKYDV FOREIGN KEY (MaPDV) REFERENCES PHIEUDICHVU(MaPDV)
ALTER TABLE CHITIETPHIEU ADD CONSTRAINT FK_CHITIETPHIEUDV FOREIGN KEY (MaPDV) REFERENCES PHIEUDICHVU(MaPDV)
ALTER TABLE CHITIETPHIEU ADD CONSTRAINT FK_CHITIETPHIEUPHONG FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong)
ALTER TABLE CHITIETPHIEU ADD CONSTRAINT FK_CHITIETPHIEULOAIPHONG FOREIGN KEY (MaLP) REFERENCES LOAIPHONG(MaLP)
ALTER TABLE CHITIETPHIEU ADD CONSTRAINT FK_CHITIETPHIEUKHACHHANG FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)
go

INSERT INTO TAIKHOAN(MaTK, TenDangNhap, MatKhau) VALUES('TK001',N'Admin', 'Admin')
INSERT INTO TAIKHOAN(MaTK, TenDangNhap, MatKhau) VALUES('TK002',N'Quanly', 'Quanly')
INSERT INTO TAIKHOAN(MaTK, TenDangNhap, MatKhau) VALUES('TK003',N'Nhanvien', 'Nhanvien')
go

INSERT INTO CHUCVU (MaCV, TenCV)VALUES('CV001',N'Admin')
INSERT INTO CHUCVU (MaCV, TenCV)VALUES('CV002',N'Quản lý')
INSERT INTO CHUCVU (MaCV, TenCV)VALUES('CV003',N'Nhân Viên')
go

INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH001', N'Nguyễn Phi Sơn', '1', N'Mỹ Tho', '321456486', '0989000006', N'Việt Nam')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH005', N'Võ Phi Hùng', '1', N'Cái Bè','321316486', '0912345678', N'Việt Nam')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH002', N'Trương Vô Kỵ', '0', N'Cai Lậy', '321456486', '0678903333', N'Mỹ')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH004', N'Trần Tiến Minh', '0', N'Sóc Trăng', '321456431', '0678345124', N'Mỹ')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH006', N'Bùi Anh Tuấn Huy', '1', N'Gò Công', '331456486', '0678345121', N'Lào')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH003', N'Lệ Kim Chi', '0', N'Mỹ Tho', '321326486', '0345678903', N'Lào')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH008', N'Lê Đan Bình', '1', N'Vũng Tàu', '321456000', '0078225121', N'Thái Lan')
INSERT INTO KHACHHANG(MaKH, HoTenKH, GioiTinh, DiaChi, CMND, SDT, QuocTich) VALUES('KH007', N'Huỳnh Thanh Linh', '0', N'Đà Lạt', '32145631', '0945108903', N'Thái Lan')
go

INSERT INTO LOAIPHONG (MaLP, TenLP, TrangThietBi)VALUES('LP001',N'Phòng VIP', N'Tivi')
INSERT INTO LOAIPHONG (MaLP, TenLP, TrangThietBi)VALUES('LP002',N'Phòng Thường', N'Quạt Máy')
INSERT INTO LOAIPHONG (MaLP, TenLP, TrangThietBi)VALUES('LP003',N'PHÒNG Đôi', N'Ghế Tình Yêu')
INSERT INTO LOAIPHONG (MaLP, TenLP, TrangThietBi)VALUES('LP004',N'Phòng Gia Đình', N'Máy Nước Nóng')
go

INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV001', N'Bùi Anh Tuấn', '1', '2/12/1979', '0805038905', N'Mỹ Tho', 'CV001','TK001')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV002', N'Hồ Ngọc Hà', '0', '1/1/1980', '0215678910', N'Sài Gòn', 'CV002','TK002')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV003', N'Nguyễn Thanh Tùng', '1', '9/9/1971', '0305971924', N'Cần Thơ', 'CV003','TK003')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV004', N'Hồ Quang Hiếu', '1', '1/2/1986', '0115608944', N'Ninh Thuận', 'CV001','TK001')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV005', N'Mai Kim Trí', '0', '9/10/1979', '0225608933', N'Mỹ Tho', 'CV003','TK003')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV006', N'Kim Tử Long', '1', '5/2/1978', '0015665922', N'Vũng Tàu', 'CV002','TK002')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV007', N'Võ Hoài Linh', '1', '1/11/1979', '0995268933', N'Đà Lạt', 'CV003','TK003')
INSERT INTO NHANVIEN(MaNV, HoTenNV, GioiTinh, NgaySinh, SDT, DiaChi, MaCV, MaTK) VALUES('NV008', N'Hồ Văn Cường', '1', '7/6/1978', '0889276641', N'SaPa', 'CV002','TK002')
go

INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP001', N'Phòng 001', 'LP001', '200000', '1', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP005', N'Phòng 003', 'LP003', '300000', '0', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP002', N'Phòng 004', 'LP002', '200000', '0', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP003', N'Phòng 002', 'LP004', '600000', '0', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP004', N'Phòng 005', 'LP004', '400000', '1', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP006', N'Phòng 006', 'LP001', '300000', '0', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP007', N'Phòng 007', 'LP002', '600000', '1', 'VND')
INSERT INTO PHONG(MaPhong, TenPhong, MaLP, GiaPhong, TinhTrang, DonVi) VALUES('MP008', N'Phòng 008', 'LP002', '600000', '1', 'VND')
go

INSERT INTO Booking(Mabooking, Tenbooking)VALUES('BK001',N'Khách Tự Đến')
INSERT INTO Booking(Mabooking, Tenbooking)VALUES('BK002',N'Khách Online')
INSERT INTO Booking(Mabooking, Tenbooking)VALUES('BK003',N'Khách Đối Tác')
GO

INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD001','NV001','KH001', 'MP001', 'LP001', 'BK001', '07/15/2020', '100000', '100000','VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD002','NV002','KH002', 'MP002', 'LP002', 'BK002', '08/16/2020', '200000','122220', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD003','NV003','KH003', 'MP003', 'LP003', 'BK001', '09/17/2020', '100000','500000', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD004','NV004','KH004', 'MP004', 'LP004', 'BK001', '10/18/2020', '300000','100000', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD005','NV005','KH005', 'MP005', 'LP002', 'BK003', '11/19/2020', '50000','250000', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD006','NV006','KH006', 'MP006', 'LP003', 'BK002', '12/20/2020', '90000','210000', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD007','NV007','KH007', 'MP007', 'LP004', 'BK003', '11/19/2020', '100000','200000', 'VND') 
INSERT INTO HOADON(MaHD, MaNV, MaKH, MaPhong, MaLP, MaBooking, NgayThanhToan, SoTienDatTruoc, tongtien, DonVi) VALUES('HD008','NV008','KH008', 'MP008', 'LP001', 'BK002', '12/20/2020', '150000','450000', 'VND') 
go


INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV001', N'Massage', '500000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV003', N'Gội Đầu', '100000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV002', N'Quét Dọn', '50000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV004', N'Giặt Đồ', '80000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV005', N'Mì Gói', '10000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV006', N'Nước Giải Khát', '15000') 
INSERT INTO PHIEUDICHVU(MaPDV , TenDV , GiaDV) VALUES('PDV007', N'Karaoke', '200000')
go

INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK001','PDV001', 'KH001', 'NV001', '11/16/2020', '11/22/2020', 'MP001', '100000', 'VND' )
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK002','PDV002', 'KH002', 'NV002', '11/17/2020', '11/23/2020', 'MP002', '200000', 'VND')
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK003','PDV003', 'KH003', 'NV003', '11/18/2020', '11/24/2020', 'MP003', '100000', 'VND')
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK004','PDV004', 'KH004', 'NV004', '11/19/2020', '11/25/2020', 'MP004', '300000', 'VND')
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK005','PDV005', 'KH005', 'NV005', '11/20/2020', '11/26/2020', 'MP005', '50000', 'VND')
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK006','PDV006', 'KH006', 'NV006', '11/21/2020', '11/27/2020', 'MP006', '90000', 'VND')
INSERT INTO PHIEUDANGKY(MaPDK , MaPDV , MaKH , MaNV , NgayLap , NgayDi , MaPhong , TraTruoc, DonVi ) VALUES('PDK007','PDV007', 'KH007', 'NV007', '11/20/2020', '11/26/2020', 'MP007', '100000', 'VND')
GO

INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP001','PDV001','2','800000','100000','LP004','BK001','2','06/08/2021','200000','MP001','KH001',N'Việt Nam','06/10/2021','2','400000', N'Phòng Đang Dọn')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP002','PDV002','3','200000','200000','LP003','BK002','2','06/08/2021','300000','MP002','KH002',N'Thái Lan','07/08/2021','2','800000', N'Phòng Trống')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP003','PDV003','2','500000','400000','LP004','BK001','2','06/08/2021','200000','MP007','KH003',N'Mỹ','06/10/2021','2','6000000', N'Phòng Trả')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP004','PDV004','4','300000','300000','LP001','BK003','2','06/08/2021','300000','MP006','KH004',N'Mỹ','07/08/2021','2','200000', N'Phòng Ở')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP005','PDV005','5','200000','100000','LP002','BK001','2','06/08/2021','200000','MP005','KH005',N'Thái Lan','06/10/2021','2','1000000', N'Phòng Đang Dọn')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP006','PDV006','1','200000','100000','LP001','BK002','2','06/08/2021','300000','MP004','KH006',N'Lào','07/08/2021','2','6000000', N'Phòng Trống')
INSERT INTO CHITIETPHIEU(maphieu,MaPDV,soluong,giadv,thanhtiendv,MaLP,Mabooking,sokhach,ngayvao,GiaPhong,MaPhong,MaKH,QuocTich,ngaydi,sodem,thanhtien,TinhTrang)VALUES('CTP007','PDV007','8','700000','700000','LP003','BK003','2','06/08/2021','200000','MP003','KH007',N'Việt Nam','06/10/2021','2','8000000', N'Phòng Trả')
GO

INSERT INTO NOIQUY(NQ1, NQ2, NQ3, NQ4, NQ5)VALUES(N'Quý khách vui lòng xuất trình hộ chiếu hoặc chứng minh nhân dân để làm thủ tục nhận phòng tại Lễ tân.',N'Khách sạn chỉ chịu trách nhiệm với những tài sản hoặc tiền được gửi tại quầy Lễ tân.',N'Xin vui lòng không thay đổi phòng hoặc đưa thêm người vào phòng khi chưa đăng ký trước với Lễ tân.',N'Nếu có người thân đến thăm, xin quý khách vui lòng liên hệ với Lễ tân để bổ trí nơi tiếp đón.',N'Trước khi rời khỏi khách sạn, xin Quý khách vui lòng thanh toán toàn bộ các hoá đơn và trả lại chìa khoá phòng cho Lễ tân.')
GO




select MaHD, HoTenNV, NgayThanhToan, SoTienDatTruoc, DonVi from NHANVIEN nv, HOADON hd where nv.MaNV = hd.MaNV 


select MaPDK, MaPDV, NgayLap, NgayDi, MaPhong, TraTruoc, DonVi from PHIEUDANGKY

select * from PHIEUDICHVU where MaPDV ='PDV007'

select * from KHACHHANG kh,PHONG p, NHANVIEN n, PHIEUDICHVU dv, PHIEUDANGKY dk where n.MaNV=dk.MaNV and p.MaPhong=dk.MaPhong and kh.MaKH=dk.MaKH and dv.MaPDV=dk.MaPDV and dk.MaPDK = 'PDK001'

SELECT * FROM dbo.TAIKHOAN WHERE TenDangNhap = N'Admin' AND MatKhau ='Admin'

Select * from CHITIETPHIEU where TinhTrang = N'Phòng Đang Dọn'

Select * from Booking

select* from PHIEUDICHVU

select* from CHITIETPHIEU a, PHIEUDICHVU b, PHONG c, LOAIPHONG d, Booking e where a.MaPhong = c.MaPhong and b.MaPDV = b.MaPDV and d.MaLP = c.MaLP and e.Mabooking = a.Mabooking and maphieu = 'CTP001'

select* from PHONG , PHIEUDICHVU , CHITIETPHIEU , LOAIPHONG , Booking

select* from PHONG a, PHIEUDICHVU b, CHITIETPHIEU c, LOAIPHONG d, Booking e where a.MaPhong = c.MaPhong and b.MaPDV = c.MaPDV and d.MaLP = c.MaLP and e.Mabooking = c.Mabooking and maphieu = 'CTP001'


select MaPDK, HoTenKH, TenPhong,  NgayLap , NgayDi ,HoTenNV, TraTruoc, TenDV , pdk.DonVi, TraTruoc from PHIEUDANGKY pdk, KHACHHANG kh, PHIEUDICHVU dv, NHANVIEN nv, PHONG p where kh.MaKH=pdk.MaKH and p.MaPhong=pdk.MaPhong and nv.MaNV=pdk.MaNV and dv.MaPDV=pdk.MaPDV


select c.maphieu, TenDV,  soluong, c.giadv, thanhtien, TenPhong,  Tenbooking, sokhach, ngayvao, c.GiaPhong, TenLP, f.MaKH, f.QuocTich, ngaydi, sodem, thanhtiendv, c.TinhTrang   from PHONG a , PHIEUDICHVU b , CHITIETPHIEU c, Booking d, LOAIPHONG e, KHACHHANG f   where f.MaKH=c.MaKH and  a.MaPhong=c.MaPhong and b.MaPDV=c.MaPDV and e.MaLP=c.MaLP and d.Mabooking=c.Mabooking
          
select c.maphieu, TenDV,  soluong, c.giadv, thanhtien, TenPhong,  Tenbooking, sokhach, ngayvao, c.GiaPhong, TenLP, HoTenKH, f.QuocTich, ngaydi, sodem, thanhtiendv, c.TinhTrang   from PHONG a , PHIEUDICHVU b , CHITIETPHIEU c, Booking d, LOAIPHONG e, KHACHHANG f   where f.MaKH=c.MaKH and  a.MaPhong=c.MaPhong and b.MaPDV=c.MaPDV and e.MaLP=c.MaLP and d.Mabooking=c.Mabooking


select MaHD, TenBooking, HoTenKH, TenPhong, TenLP, NgayThanhToan, SoTienDatTruoc, tongtien, hd.DonVi from HOADON hd, Booking bk, KHACHHANG kh, PHONG p, LOAIPHONG lp where hd.MaBooking=bk.Mabooking and hd.MaKH=kh.MaKH and hd.MaPhong = p.MaPhong and lp.MaLP=hd.MaLP and MaHD = 'HD001'