CREATE TABLE SinhVien (
    MaSV   NVARCHAR(20)  NOT NULL PRIMARY KEY,
    TenSV  NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,   -- "Nam"/"Nữ"
    NgaySinh DATE        NOT NULL,
    QueQuan NVARCHAR(100) NULL,
    MaLop  NVARCHAR(20)  NULL
);

CREATE TABLE Lop (
    MaLop NVARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(100)
);

ALTER TABLE SinhVien
ADD CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop)
REFERENCES Lop(MaLop);


INSERT INTO Lop (MaLop, TenLop)
VALUES
('CT1', N'Công nghệ thông tin 1'),
('CT2', N'Công nghệ thông tin 2'),
('KT1', N'Kế toán 1'),
('QT1', N'Quản trị 1');

