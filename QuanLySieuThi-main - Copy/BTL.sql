create database QuanLysieuthi
USE QuanLysieuthi
GO
/****** Object:  Table [dbo].[chitietdonhang]    Script Date: 11/7/2022 1:52:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietdonhang](
	[maphieuxuat] [int] IDENTITY(1,1) NOT NULL,
	[sanphamban] [nvarchar](500) NULL,
	[ngayban] [nvarchar](30) NULL,
	[thanhtien] [int] NULL,
	[nguoiban] [nvarchar](50) NULL,
 CONSTRAINT [PK_chitietdonhang] PRIMARY KEY CLUSTERED 
(
	[maphieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhacungcap]    Script Date: 11/7/2022 1:52:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhacungcap](
	[mancc] [int] IDENTITY(1,1) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[congno] [int] NULL,
 CONSTRAINT [PK_nhacungcap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 11/7/2022 1:52:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanpham](
	[masp] [int] IDENTITY(1000,1) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[mancc] [int] NULL,
	[gianhap] [int] NULL,
	[giaban] [int] NULL,
	[solg] [int] NULL,
	[hsd] [date] NULL,
	[noisx] [nvarchar](50) NOT NULL,
	[donvitinh] [nvarchar](50) NULL,
	[nguoinhap] [nvarchar](50) NULL,
 CONSTRAINT [PK_sanpham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 11/7/2022 1:52:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[datecreate] [nvarchar](25) NULL,
	[isAdmin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[chitietdonhang] ON 

INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (9, N'Tương ớt : 1, Dầu ăn : 2, Bột Ngọt : 2, ', N'2022-08-23 10:44:05 PM', 175000, N'Nguyễn Văn Chiến(Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (10, N'Dầu ăn : 2,  Bột Ngọt : 1,  Cocacola : 5,  ', N'2022-01-24 08:22:31 PM', 970000, N'Nguyễn Trường Sơn(Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (11, N'Dầu ăn : 5,  Sữa : 4,  kim chi : 3,  ', N'2022-05-26 10:18:08 AM', 642600, N'Nguyễn Thế Khải(Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (12, N'Cocacola : 1,  Kim Chi : 1,  Cocacola : 1,  ', N'2022-05-30 09:05:14 PM', 570000, N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (13, N'Tương ớt : 1,  Cocacola : 1,  Tương ớt : 1,  ', N'2022-08-30 09:08:18 PM', 340000, N'Nguyễn Văn Chiến(Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (14, N'Bột Giặt : 5,  Tương ót : 1,  Nước Tương : 3,  Bột Ngọt : 2,  ', N'2022-07-30 09:17:57 PM', 315000, N'Phạm Văn Anh(Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (15, N'Cocacola : 3,  Kim Chi : 2,  Kem Đánh Răng : 5,  ', N'2022-08-30 11:08:17 PM', 1240000, N'Phạm Văn Anh(Quản trị)')
INSERT [dbo].[chitietdonhang] ([maphieuxuat], [sanphamban], [ngayban], [thanhtien], [nguoiban]) VALUES (16, N'Kim Chi : 1,  D?u an : 2,  ', N'2022-46-07 01:46:51 PM', 190000, N'Xin Chào : Nguyễn Thế Khải (Nhân viên)')
SET IDENTITY_INSERT [dbo].[chitietdonhang] OFF
GO
SET IDENTITY_INSERT [dbo].[nhacungcap] ON 

INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (1, N'Vinamilk', N'Hà Nội', N'01655888622', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (2, N'GoFood', N'Hà Nội', N'00001356565', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (3, N'ThuanAn', N'Hải Phòng', N'05985231023', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (4, N'Sun', N'hcm', N'123456789', 0)
INSERT [dbo].[nhacungcap] ([mancc], [tenncc], [diachi], [sdt], [congno]) VALUES (5, N'Now', N'HCM', N'0934545', 0)
SET IDENTITY_INSERT [dbo].[nhacungcap] OFF
GO
SET IDENTITY_INSERT [dbo].[sanpham] ON 

INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1000, N'Rau', 1, 300000, 400000, 60, CAST(N'2025-01-01' AS Date), N'Hải Phòng', N'Chiếc', N'Nguyễn Trường Sơn(Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1001, N'Bột giặt', 2, 150000, 20000, 26, CAST(N'2022-07-21' AS Date), N'Bình Phước', N'Bịch', N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1002, N'Dầu ăn', 2, 50000, 60000, 33, CAST(N'2022-08-20' AS Date), N'HCM', N'Chai', N' Nguyễn Thế Khải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1003, N'Bột ngọt', 1, 20000, 25000, 41, CAST(N'2022-08-20' AS Date), N'HCM', N'Bịch', N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1004, N'Tương ớt', 1, 35000, 45000, 59, CAST(N'2023-11-23' AS Date), N'Hải Phòng', N'Chai', N'Nguyen Van Admin(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1005, N'Cocacola', 1, 170000, 250000, 50, CAST(N'2022-08-20' AS Date), N'HCM', N'Thùng', N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1007, N'Kim Chi', 2, 50000, 70000, 93, CAST(N'2022-08-26' AS Date), N'Seoul', N'Bịch', N'Nguyễn Văn Chiến(Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1008, N'Sữa', 3, 20000, 30000, 36, CAST(N'2022-09-28' AS Date), N'HCM', N'Hộp', N'Phạm Văn Anh(Quản trị)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1009, N'Nước tương', 1, 30000, 40000, 87, CAST(N'2022-09-29' AS Date), N'HCM', N'Chai', N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1010, N'Kem đánh răng', 5, 50000, 70000, 85, CAST(N'2022-08-30' AS Date), N'Bình Phước', N'Típ', N'Đặng Xuân Hải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1011, N'Kẹo', 4, 50000, 60000, 100, CAST(N'2022-08-30' AS Date), N'Hà Nội', N'Gói', N'Nguyễn Thế Khải(Nhân viên)')
INSERT [dbo].[sanpham] ([masp], [tensp], [mancc], [gianhap], [giaban], [solg], [hsd], [noisx], [donvitinh], [nguoinhap]) VALUES (1012, N'Bánh', 5, 60000, 70000, 200, CAST(N'2022-08-30' AS Date), N'USA', N'Gói', N'Nguyễn Trường Sơn(Quản trị)')
SET IDENTITY_INSERT [dbo].[sanpham] OFF
GO
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'admin', N'123', N'Nguyen Van Admin', N'2022-11-30 10:55:52 PM', 1)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'anh', N'123', N'Phạm Văn Anh', N'2022-08-21 20:54:33.15000', 0)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'chien', N'123', N'Nguyễn Văn Chiến', N'2022-08-21 20:16:04.51000', 0)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'hai', N'123', N'Đặng Xuân Hải', N'2022-12-30 09:12:14 PM', 1)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'khai', N'123', N'Nguyễn Thế Khải', N'2022-08-21 20:16:36.94700', 1)
INSERT [dbo].[taikhoan] ([username], [password], [fullname], [datecreate], [isAdmin]) VALUES (N'son', N'123', N'Nguyễn Trường Sơn', N'2022-08-26 09:08:14.00000', 0)
GO
