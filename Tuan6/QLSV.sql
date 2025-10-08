/*  Tạo Database */
CREATE DATABASE QuanLySinhVien_Lab4;
GO

/*  Sử dụng Database */
USE QuanLySinhVien_Lab4;
GO

/*  Tạo bảng KHOA */
CREATE TABLE KHOA (
    MaKhoa  CHAR(4)       NOT NULL PRIMARY KEY,         
    TenKhoa NVARCHAR(100) NOT NULL UNIQUE
);
GO

/*  Tạo bảng LOP (thuộc KHOA) */
CREATE TABLE LOP (
    MaLop   CHAR(10)       NOT NULL PRIMARY KEY,         
    TenLop  NVARCHAR(100)  NOT NULL,
    MaKhoa  CHAR(4)        NOT NULL
        CONSTRAINT FK_LOP_KHOA REFERENCES KHOA(MaKhoa)
        ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

/*  Tạo bảng SINHVIEN (thuộc LOP) */
CREATE TABLE SINHVIEN (
    MaSV     CHAR(10)       NOT NULL PRIMARY KEY,        
    TenSV    NVARCHAR(100)  NOT NULL,
    GioiTinh NVARCHAR(3)    NOT NULL 
        CONSTRAINT CK_SV_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    NgaySinh DATE           NOT NULL,
    QueQuan  NVARCHAR(100)  NULL,
    MaLop    CHAR(10)       NOT NULL
        CONSTRAINT FK_SV_LOP REFERENCES LOP(MaLop)
        ON UPDATE CASCADE ON DELETE NO ACTION
);
GO

/*  Index hỗ trợ truy vấn theo khóa ngoại */
CREATE INDEX IX_LOP_MaKhoa ON LOP(MaKhoa);
CREATE INDEX IX_SINHVIEN_MaLop ON SINHVIEN(MaLop);
GO

/*  Dữ liệu mẫu – KHOA */
INSERT INTO KHOA (MaKhoa, TenKhoa) VALUES
('CNTT', N'Công nghệ thông tin'),
('CK'  , N'Cơ khí'),
('DT'  , N'Điện tử'),
('KT'  , N'Kinh tế');
GO

/*  Dữ liệu mẫu – LOP */
INSERT INTO LOP (MaLop, TenLop, MaKhoa) VALUES
('CNTT1', N'Công nghệ thông tin 1', 'CNTT'),
('CNTT2', N'Công nghệ thông tin 2', 'CNTT'),
('CK1'  , N'Cơ khí 1',               'CK'),
('DT1'  , N'Điện tử 1',              'DT'),
('KT1'  , N'Kinh tế 1',              'KT');
GO

/*Dữ liệu mẫu – SINHVIEN */

INSERT INTO SINHVIEN (MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop) VALUES
('0200000001', N'Nguyễn An',   N'Nữ', '2003-02-12', N'TP.HCM', 'CNTT1'),
('0200000002', N'Trần Bình',   N'Nam','2003-05-20', N'Hà Nội', 'CNTT1'),
('0200000003', N'Lê Châu',     N'Nữ', '2002-11-02', N'Đà Nẵng','CK1'),
('0200000004', N'Phạm Dũng',   N'Nam','2003-07-15', N'Cần Thơ','CNTT2'), 
('0200000005', N'Võ Em',       N'Nam','2001-12-01', N'Long An','DT1'),
('0200000006', N'Huỳnh Giang', N'Nữ', '2003-09-09', N'Bình Dương','KT1');
GO
