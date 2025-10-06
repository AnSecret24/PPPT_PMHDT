CREATE DATABASE QuanLySach
CREATE TABLE TAC_GIA (
    MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL,
    QuocTich NVARCHAR(50)
);

CREATE TABLE THE_LOAI (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL
);

CREATE TABLE SACH (
    MaSach INT IDENTITY(1,1) PRIMARY KEY,
    TenSach NVARCHAR(150) NOT NULL,
    NamXuatBan INT,
    MaTacGia INT FOREIGN KEY REFERENCES TAC_GIA(MaTacGia),
    MaTheLoai INT FOREIGN KEY REFERENCES THE_LOAI(MaTheLoai),
    SoLuong INT DEFAULT 1
);

CREATE TABLE DOC_GIA (
    MaDocGia INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(200),
    SoDienThoai VARCHAR(20)
);

CREATE TABLE PHIEU_MUON (
    MaPhieu INT IDENTITY(1,1) PRIMARY KEY,
    MaDocGia INT FOREIGN KEY REFERENCES DOC_GIA(MaDocGia),
    MaSach INT FOREIGN KEY REFERENCES SACH(MaSach),
    NgayMuon DATE,
    NgayTra DATE,
    TrangThai NVARCHAR(20) CHECK (TrangThai IN (N'Đang mượn', N'Đã trả')) DEFAULT N'Đang mượn'
);
GO


-- ========== TÁC GIẢ ==========
INSERT INTO TAC_GIA (TenTacGia, QuocTich) VALUES
(N'Nguyễn Nhật Ánh', N'Việt Nam'),
(N'Robert C. Martin', N'Mỹ'),
(N'Martin Kleppmann', N'Anh'),
(N'J.K. Rowling', N'Anh'),
(N'George R.R. Martin', N'Mỹ'),
(N'Haruki Murakami', N'Nhật Bản'),
(N'Nguyễn Ngọc Tư', N'Việt Nam'),
(N'Erich Gamma', N'Thụy Sĩ'),
(N'Yuval Noah Harari', N'Israel'),
(N'Nguyễn Văn A', N'Việt Nam');
GO

-- ========== THỂ LOẠI ==========
INSERT INTO THE_LOAI (TenTheLoai) VALUES
(N'Văn học'),
(N'Lập trình'),
(N'Khoa học viễn tưởng'),
(N'Tâm lý học'),
(N'Lịch sử'),
(N'Thiếu nhi'),
(N'Kinh tế'),
(N'Triết học'),
(N'Kỹ năng sống'),
(N'Tiểu thuyết');
GO

-- ========== SÁCH ==========
INSERT INTO SACH (TenSach, NamXuatBan, MaTacGia, MaTheLoai, SoLuong) VALUES
(N'Mắt Biếc', 1990, 1, 1, 5),
(N'Clean Code', 2008, 2, 2, 3),
(N'Designing Data-Intensive Applications', 2017, 3, 2, 4),
(N'Harry Potter và Hòn đá Phù thủy', 1997, 4, 6, 6),
(N'Trò chơi vương quyền', 1996, 5, 10, 2),
(N'Rừng Na Uy', 1987, 6, 10, 5),
(N'Cánh đồng bất tận', 2005, 7, 1, 3),
(N'Design Patterns', 1994, 8, 2, 2),
(N'Sapiens: Lược sử loài người', 2011, 9, 5, 4),
(N'Lập trình C cơ bản', 2020, 10, 2, 10);
GO

-- ========== ĐỘC GIẢ ==========
INSERT INTO DOC_GIA (HoTen, NgaySinh, DiaChi, SoDienThoai) VALUES
(N'Đinh Thị Thảo An', '2003-06-15', N'TP.HCM', '0909000000'),
(N'Nguyễn Lê Anh Trúc', '2002-09-25', N'TP.Thủ Đức', '0909123456'),
(N'Phạm Minh Khang', '2001-01-20', N'Cần Thơ', '0911222333'),
(N'Trần Thị Kim Ngân', '2004-05-11', N'Đà Nẵng', '0988776655'),
(N'Lê Văn Nam', '2000-07-01', N'Huế', '0909333444'),
(N'Phan Hoàng Duy', '2003-02-28', N'TP.HCM', '0933445566'),
(N'Nguyễn Hoàng Minh', '2002-12-22', N'Bình Dương', '0909555666'),
(N'Võ Nhật Hào', '2003-03-30', N'TP.HCM', '0911777888'),
(N'Trương Bảo Anh', '2004-08-17', N'Long An', '0977888999'),
(N'Lê Thị Mỹ Duyên', '2003-10-10', N'Đồng Nai', '0909777666');
GO

-- ========== PHIẾU MƯỢN ==========
INSERT INTO PHIEU_MUON (MaDocGia, MaSach, NgayMuon, NgayTra, TrangThai) VALUES
(1, 1, '2025-09-25', '2025-10-05', N'Đã trả'),
(2, 2, '2025-09-28', '2025-10-08', N'Đang mượn'),
(3, 4, '2025-09-29', '2025-10-09', N'Đang mượn'),
(4, 5, '2025-09-20', '2025-09-30', N'Đã trả'),
(5, 3, '2025-09-18', '2025-09-28', N'Đã trả'),
(6, 6, '2025-09-25', '2025-10-05', N'Đang mượn'),
(7, 7, '2025-09-26', '2025-10-06', N'Đang mượn'),
(8, 8, '2025-09-15', '2025-09-25', N'Đã trả'),
(9, 9, '2025-09-27', '2025-10-07', N'Đang mượn'),
(10,10,'2025-09-30', '2025-10-10', N'Đang mượn');
GO