USE [master]
GO
/****** Object:  Database [QLDPKS]    Script Date: 17-Jun-21 8:43:48 PM ******/
CREATE DATABASE [QLDPKS]

ALTER DATABASE [QLDPKS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDPKS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDPKS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDPKS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDPKS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDPKS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDPKS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDPKS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDPKS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDPKS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDPKS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDPKS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDPKS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDPKS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDPKS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDPKS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDPKS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDPKS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDPKS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDPKS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDPKS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDPKS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDPKS] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDPKS] SET  MULTI_USER 
GO
ALTER DATABASE [QLDPKS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDPKS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDPKS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDPKS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
--ALTER DATABASE [QLDPKS] SET DELAYED_DURABILITY = DISABLED 

/****** Object:  Table [dbo].[BANGLOC]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGLOC](
	[IDBANG] [nchar](10) NOT NULL,
	[TENBANG] [nvarchar](50) NULL,
 CONSTRAINT [PK_BANGLOC] PRIMARY KEY CLUSTERED 
(
	[IDBANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOOKING]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOOKING](
	[MABOOK] [int] NOT NULL,
	[MAPHONG] [char](10) NULL,
	[MAKH] [int] NULL,
	[NGAYVAO] [date] NULL,
	[NGAYDI] [date] NULL,
	[YEUCAU] [nvarchar](100) NULL,
 CONSTRAINT [PK_BOOKING] PRIMARY KEY CLUSTERED 
(
	[MABOOK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MADV] [char](10) NOT NULL,
	[TENDV] [nvarchar](100) NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MADV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [int] NOT NULL,
	[MABOOK] [int] NOT NULL,
	[TONGTIEN] [int] NULL,
	[HOTEN] [nvarchar](100) NULL,
	[SDT] [nvarchar](100) NULL,
	[EMAIL] [nvarchar](100) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOME_DDNB]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOME_DDNB](
	[IDDIADIEM] [nchar](10) NOT NULL,
	[TENDIADIEM] [nvarchar](max) NULL,
	[img] [nvarchar](max) NULL,
 CONSTRAINT [PK_HOME_DDNB] PRIMARY KEY CLUSTERED 
(
	[IDDIADIEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOME_SLIDE]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOME_SLIDE](
	[IDSLIDE] [nchar](10) NOT NULL,
	[SLIDECONTENT] [nvarchar](max) NULL,
	[IMG] [nvarchar](max) NULL,
 CONSTRAINT [PK_HOME_SLIDE] PRIMARY KEY CLUSTERED 
(
	[IDSLIDE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHSAN]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHSAN](
	[MAKHACHSAN] [char](10) NOT NULL,
	[MANCC] [char](10) NOT NULL,
	[TENKHACHSAN] [nvarchar](100) NULL,
	[SOLUONGPHONG] [int] NULL,
	[SOSAO] [int] NULL,
	[TINH] [nvarchar](100) NULL,
	[QUAN] [nvarchar](100) NULL,
	[PHUONG] [nvarchar](100) NULL,
	[DUONG] [nvarchar](100) NULL,
	[DIACHICUTHE] [nvarchar](100) NULL,
	[ANHKS1] [nchar](100) NULL,
	[ANHKS2] [nchar](100) NULL,
	[ANHKS3] [nchar](100) NULL,
	[ANHKS4] [nchar](100) NULL,
	[ANHKS5] [nchar](100) NULL,
	[MOTA] [nvarchar](100) NULL,
	[DIADANH] [nvarchar](100) NULL,
	[DANHGIA] [nvarchar](100) NULL,
	[DIEM] [float] NULL,
	[IDDIADIEM] [nchar](10) NULL,
 CONSTRAINT [PK_KHACHSAN] PRIMARY KEY CLUSTERED 
(
	[MAKHACHSAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KSTIENICH]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KSTIENICH](
	[MAKHACHSAN] [char](10) NOT NULL,
	[IDTIENICH] [int] NOT NULL,
	[GHICHU] [nvarchar](50) NULL,
 CONSTRAINT [PK_KSTIENICH] PRIMARY KEY CLUSTERED 
(
	[MAKHACHSAN] ASC,
	[IDTIENICH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MALOAI] [char](10) NOT NULL,
	[TENLOAIPHONG] [nvarchar](100) NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MANCC] [char](10) NOT NULL,
	[TENNCC] [nvarchar](100) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OPTIONLOC]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OPTIONLOC](
	[IDKIEULOC] [nchar](10) NOT NULL,
	[TENKIEULOC] [nvarchar](50) NULL,
	[IDBANG] [nchar](10) NOT NULL,
 CONSTRAINT [PK_OPTIONLOC] PRIMARY KEY CLUSTERED 
(
	[IDKIEULOC] ASC,
	[IDBANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAKHACHSAN] [char](10) NOT NULL,
	[MALOAI] [char](10) NOT NULL,
	[MAPHONG] [char](10) NOT NULL,
	[TENPHONG] [nvarchar](100) NULL,
	[DIENTICH] [int] NULL,
	[QUANGCANH] [nvarchar](100) NULL,
	[GIA] [int] NULL,
	[GIAM] [float] NULL,
	[ANH1] [nvarchar](100) NULL,
	[ANH2] [nvarchar](100) NULL,
	[ANH3] [nvarchar](100) NULL,
	[ANH4] [nvarchar](100) NULL,
	[ANH5] [nvarchar](100) NULL,
	[SOGIUONG] [int] NULL,
	[LOAIGIUONG] [nvarchar](100) NULL,
	[SOLUONG] [int] NULL,
	[SOKHACH] [int] NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGDV_FEE]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGDV_FEE](
	[MAPHONG] [char](10) NULL,
	[MADV] [char](10) NULL,
	[GIA] [int] NULL,
	[MADVFEE] [char](10) NOT NULL,
 CONSTRAINT [PK_PHONGDV_FEE] PRIMARY KEY CLUSTERED 
(
	[MADVFEE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGDV_FREE]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGDV_FREE](
	[MAPHONG] [char](10) NULL,
	[MADV] [char](10) NULL,
	[GHICHU] [nvarchar](100) NULL,
	[MADVFREE] [char](10) NOT NULL,
 CONSTRAINT [PK_PHONGDV_FREE] PRIMARY KEY CLUSTERED 
(
	[MADVFREE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENDN] [nchar](50) NULL,
	[MATKHAU] [nchar](50) NULL,
	[EMAIL] [nchar](50) NULL,
	[SDT] [nchar](11) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIENICH]    Script Date: 17-Jun-21 8:43:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIENICH](
	[IDTIENICH] [int] IDENTITY(1,1) NOT NULL,
	[TENTIENICH] [nvarchar](100) NULL,
	[ICON] [nvarchar](50) NULL,
 CONSTRAINT [PK_TIENICH] PRIMARY KEY CLUSTERED 
(
	[IDTIENICH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON  ) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Air       ', N'Đưa đón sân bay')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'AS        ', N'Ăn sáng')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Bar       ', N'Quầy bar')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Cas       ', N'Casino')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Child     ', N'Trông trẻ')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'DT        ', N'Thu đổi ngoại tệ')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'DV        ', N'Đặt vé máy bay, tour')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'GU        ', N'Giặt ủi')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Gym       ', N'Fitness center')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Kar       ', N'Karaoke')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'NH        ', N'Nhà hàng')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'PV        ', N'Phục vụ 24/24')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Sp        ', N'Spa')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'Sw        ', N'Bơi')
INSERT [dbo].[DICHVU] ([MADV], [TENDV]) VALUES (N'TX        ', N'Cho thuê xe tự lái')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'1         ', N'Đà Nẵng', N'danang.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'10        ', N'TP. Hồ Chí Minh', N'saigon.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'11        ', N'Phú Quốc', N'phuquoc.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'12        ', N'Huế', N'hue.png')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'2         ', N'Nha Trang', N'nhatrang.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'3         ', N'Sapa', N'sapa.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'4         ', N'Bà Rịa - Vũng Tàu', N'vungtau.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'5         ', N'Phan Thiết', N'phanthiet.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'6         ', N'Hội An', N'hoian.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'7         ', N'Đà Lạt', N'dalat.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'8         ', N'Hà Nội', N'hanoi.jpg')
INSERT [dbo].[HOME_DDNB] ([IDDIADIEM], [TENDIADIEM], [img]) VALUES (N'9         ', N'Hạ Long', N'halong.jpg')
INSERT [dbo].[HOME_SLIDE] ([IDSLIDE], [SLIDECONTENT], [IMG]) VALUES (N'2         ', N'DSQ', N'bach-luyen-thanh-tien.jpg')
INSERT [dbo].[HOME_SLIDE] ([IDSLIDE], [SLIDECONTENT], [IMG]) VALUES (N'3         ', N'AJ', N'tienhiep7.png')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'CAM       ', N'QWE       ', N'Khách sạn Camellia 5', 100, 2, N'Hà Nội', N'Hoàn Kiếm', N'abc', N'34 Lãn Ông ', N'34, Lãn Ông, Quận Hoàn Kiếm, Hà Nội', N'camellia.jpg                                                                                        ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt', 8.2, N'8         ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'ICWHN     ', N'QWE       ', N'Khách sạn InterContinental Westlake Hà Nội', 100, 5, N'Hà Nội ', N'Tây Hồ', N'abc', N'05 Từ Hoa Công Chúa,', N'05 Từ Hoa Công Chúa, Quận Tây Hồ, Hà Nội', N'intercontinental.jpg                                                                                ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt', 8.6, N'8         ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'IMPVT     ', N'XYZ       ', N'Khách sạn Imperial Vũng Tàu', 100, 5, N'Bà Rịa - Vũng Tàu', N'Thùy Vân', N'Thắng Tam', N'159 Thùy Vân', N'159 Thùy Vân, Phường Thắng Tam, Bà Rịa Vũng Tàu, Thuỳ Vân, Thành Phố Vũng Tàu, Bà Rịa - Vũng Tàu', N'imperial1.jpg                                                                                       ', N'imperial2.jpg                                                                                       ', N'imperial3.jpg                                                                                       ', N'imperial4.jpeg                                                                                      ', N'imperial5.jpg                                                                                       ', NULL, NULL, N'Rất tốt', 8.6, N'4         ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'LMS       ', N'ABC       ', N'Khách sạn Le Méridien Saigon', 100, 5, N'TP.Hồ Chí Minh', N'1', N'abc', N'3c, Tôn Đức Thắng', N'3c, Tôn Đức Thắng, Quận 1, Hồ Chí Minh', N'lemeridiensaigon.jpg                                                                                ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt', 8.6, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'LSPHN     ', N'QWE       ', N'Khách sạn La Sieste Premium Hàng Bè Hà Nội', 100, 4, N'Hà Nội ', N'Hoàn Kiếm ', N'abc', N'27, Hàng Bè, Quận Hoàn Kiếm, Hà Nội', N'27 Hàng Bè, Quận Hoàn Kiếm, Hà Nội', N'laisiestahn.jpg                                                                                     ', NULL, NULL, NULL, NULL, NULL, NULL, N'Tuyệt vời', 9.4, N'8         ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'MHSG      ', N'ABC       ', N'Khách sạn Mai House Sài Gòn', 100, 5, N'TP.Hồ Chí Minh', N'3', N'abc', N'01 Ngô Thời Nhiệm', N'01 Ngô Thời Nhiệm, Quận 3, Hồ Chí Minh', N'maihouse1.jpg                                                                                       ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt', 8, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'MTSG      ', N'ABC       ', N'Khách sạn Mường Thanh Luxury Sài Gòn', 100, 5, N'TP.Hồ Chí Minh', N'Phú Nhuận', N'abc', N'261c, Nguyễn Văn Trỗi', N'261c, Nguyễn Văn Trỗi, Quận Phú Nhuận, Hồ Chí Minh', N'muongthanh1.jpg                                                                                     ', NULL, NULL, NULL, NULL, NULL, NULL, N'Tốt', 7, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'PH        ', N'QWE       ', N'Khách sạn Park Hyatt Sài Gòn', 100, 5, N'TP.Hồ Chí Minh', N'1', N'abc', N'2, Công Trường Lam Sơn', N'2, Công Trường Lam Sơn, Quận 1, Hồ Chí Minh', N'parkhyatt.jpg                                                                                       ', NULL, NULL, NULL, NULL, NULL, NULL, N'Tuyệt vời', 9, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'RRSG      ', N'ABC       ', N'Khách sạn Renaissance Riverside Sài Gòn', 100, 5, N'TP.Hồ Chí Minh', N'1', N'abc', N'8-15 Tôn Đức Thắng', N'8-15 Tôn Đức Thắng, Quận 1, Hồ Chí Minh', N'renaissancerriverside1.jpg                                                                          ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt', 8.4, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'SPSG      ', N'XYZ       ', N'Khách sạn Sofitel Plaza Sài Gòn', 100, 5, N'TP.Hồ Chí Minh', N'1', N'abc', N'17 Lê Duẩn', N'17 Lê Duẩn, Quận 1, Hồ Chí Minh', N'sofitel1.jpg                                                                                        ', NULL, NULL, NULL, NULL, NULL, NULL, N'Rất tốt ', 8.4, N'10        ')
INSERT [dbo].[KHACHSAN] ([MAKHACHSAN], [MANCC], [TENKHACHSAN], [SOLUONGPHONG], [SOSAO], [TINH], [QUAN], [PHUONG], [DUONG], [DIACHICUTHE], [ANHKS1], [ANHKS2], [ANHKS3], [ANHKS4], [ANHKS5], [MOTA], [DIADANH], [DANHGIA], [DIEM], [IDDIADIEM]) VALUES (N'VILLASG   ', N'XYZ       ', N'Khách sạn Villa Sông Sài Gòn', 100, 4, N'TP.Hồ Chí Minh', N'2', N'ABC', N'197/2, Nguyễn Văn Hưởng', N'197/2 Nguyễn Văn Hưởng, Quận 2, Hồ Chí Minh', N'villasg.jpg                                                                                         ', NULL, NULL, NULL, NULL, NULL, NULL, N'Tuyệt vời ', 9.4, N'10        ')
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 1, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 2, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 3, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 4, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 5, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 6, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 7, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 8, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 9, NULL)
INSERT [dbo].[KSTIENICH] ([MAKHACHSAN], [IDTIENICH], [GHICHU]) VALUES (N'IMPVT     ', 10, NULL)
INSERT [dbo].[LOAIPHONG] ([MALOAI], [TENLOAIPHONG]) VALUES (N'DLX       ', N'Phòng Deluxe')
INSERT [dbo].[LOAIPHONG] ([MALOAI], [TENLOAIPHONG]) VALUES (N'GRA       ', N'Phòng Grand')
INSERT [dbo].[LOAIPHONG] ([MALOAI], [TENLOAIPHONG]) VALUES (N'STD       ', N'Phòng Standard')
INSERT [dbo].[LOAIPHONG] ([MALOAI], [TENLOAIPHONG]) VALUES (N'SUP       ', N'Phòng Superior')
INSERT [dbo].[LOAIPHONG] ([MALOAI], [TENLOAIPHONG]) VALUES (N'SUT       ', N'Phòng Suite')
INSERT [dbo].[NCC] ([MANCC], [TENNCC]) VALUES (N'ABC       ', N'Công ty abc')
INSERT [dbo].[NCC] ([MANCC], [TENNCC]) VALUES (N'QWE       ', N'Công ty qwe')
INSERT [dbo].[NCC] ([MANCC], [TENNCC]) VALUES (N'XYZ       ', N'Công ty xyz')
INSERT [dbo].[PHONG] ([MAKHACHSAN], [MALOAI], [MAPHONG], [TENPHONG], [DIENTICH], [QUANGCANH], [GIA], [GIAM], [ANH1], [ANH2], [ANH3], [ANH4], [ANH5], [SOGIUONG], [LOAIGIUONG], [SOLUONG], [SOKHACH]) VALUES (N'IMPVT     ', N'DLX       ', N'IMPVT01   ', N'Phòng đôi Deluxe', 43, N'Quang cảnh vườn', 2184347, 8, N'impdlxvt1.png', N'impdlxvt2.png', N'impdlxvt3.png', N'impdlxvt4.png', NULL, 1, N'Đôi', 10, 2)
INSERT [dbo].[PHONG] ([MAKHACHSAN], [MALOAI], [MAPHONG], [TENPHONG], [DIENTICH], [QUANGCANH], [GIA], [GIAM], [ANH1], [ANH2], [ANH3], [ANH4], [ANH5], [SOGIUONG], [LOAIGIUONG], [SOLUONG], [SOKHACH]) VALUES (N'IMPVT     ', N'DLX       ', N'IMPVT02   ', N'Phòng 2 giường đơn Deluxe', 43, N'Quang cảnh vườn', 2564753, 8, N'impdlxvt5.png', N'impdlxvt6.png', N'impdlxvt7.png', N'impdlxvt8.png', NULL, 2, N'Đơn', 10, 2)
INSERT [dbo].[PHONG] ([MAKHACHSAN], [MALOAI], [MAPHONG], [TENPHONG], [DIENTICH], [QUANGCANH], [GIA], [GIAM], [ANH1], [ANH2], [ANH3], [ANH4], [ANH5], [SOGIUONG], [LOAIGIUONG], [SOLUONG], [SOKHACH]) VALUES (N'IMPVT     ', N'DLX       ', N'IMPVT03   ', N'Deluxe King', 40, N'Hướng một phần', 2866117, 17, N'impdlxvt9.png', N'impdlxvt10.png', N'impdlxvt11.png', N'impdlxvt9.png', NULL, 1, N'Đôi', 10, 2)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([MAKH], [TENDN], [MATKHAU], [EMAIL], [SDT]) VALUES (7, N'admin                                             ', N'111                                               ', N'abc@gmail.com                                     ', N'0943655763 ')
INSERT [dbo].[TAIKHOAN] ([MAKH], [TENDN], [MATKHAU], [EMAIL], [SDT]) VALUES (8, N'test                                              ', N'000                                               ', N'abc@gmail.com                                     ', N'0909090909 ')
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
SET IDENTITY_INSERT [dbo].[TIENICH] ON 

INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (1, N'Lễ Tân 24h', N'fas fa-concierge-bell')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (2, N'Sân tennis', N'fas fa-table-tennis')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (3, N'Phòng gym', N'fas fa-dumbbell')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (4, N'Wifi', N'fas fa-wifi')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (5, N'Thang máy', N'fas fa-tram')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (6, N'Hồ bơi', N'fas fa-swimming-pool')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (7, N'Khu vui chơi trẻ em', N'fas fa-child')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (8, N'Quầy bar', N'fas fa-glass-martini-alt')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (9, N'Nhà hàng', N'fas fa-utensils')
INSERT [dbo].[TIENICH] ([IDTIENICH], [TENTIENICH], [ICON]) VALUES (10, N'Sân thượng', N'fas fa-road')
SET IDENTITY_INSERT [dbo].[TIENICH] OFF
ALTER TABLE [dbo].[BOOKING]  WITH CHECK ADD  CONSTRAINT [FK_BOOKING_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[BOOKING] CHECK CONSTRAINT [FK_BOOKING_PHONG]
GO
ALTER TABLE [dbo].[BOOKING]  WITH CHECK ADD  CONSTRAINT [FK_BOOKING_TAIKHOAN] FOREIGN KEY([MAKH])
REFERENCES [dbo].[TAIKHOAN] ([MAKH])
GO
ALTER TABLE [dbo].[BOOKING] CHECK CONSTRAINT [FK_BOOKING_TAIKHOAN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_BOOKING] FOREIGN KEY([MABOOK])
REFERENCES [dbo].[BOOKING] ([MABOOK])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_BOOKING]
GO
ALTER TABLE [dbo].[KHACHSAN]  WITH CHECK ADD  CONSTRAINT [FK_KHACHSAN_HOME_DDNB] FOREIGN KEY([IDDIADIEM])
REFERENCES [dbo].[HOME_DDNB] ([IDDIADIEM])
GO
ALTER TABLE [dbo].[KHACHSAN] CHECK CONSTRAINT [FK_KHACHSAN_HOME_DDNB]
GO
ALTER TABLE [dbo].[KHACHSAN]  WITH CHECK ADD  CONSTRAINT [FK_KHACHSAN_NCC] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NCC] ([MANCC])
GO
ALTER TABLE [dbo].[KHACHSAN] CHECK CONSTRAINT [FK_KHACHSAN_NCC]
GO
ALTER TABLE [dbo].[KSTIENICH]  WITH CHECK ADD  CONSTRAINT [FK_KSTIENICH_KHACHSAN] FOREIGN KEY([MAKHACHSAN])
REFERENCES [dbo].[KHACHSAN] ([MAKHACHSAN])
GO
ALTER TABLE [dbo].[KSTIENICH] CHECK CONSTRAINT [FK_KSTIENICH_KHACHSAN]
GO
ALTER TABLE [dbo].[KSTIENICH]  WITH CHECK ADD  CONSTRAINT [FK_KSTIENICH_TIENICH] FOREIGN KEY([IDTIENICH])
REFERENCES [dbo].[TIENICH] ([IDTIENICH])
GO
ALTER TABLE [dbo].[KSTIENICH] CHECK CONSTRAINT [FK_KSTIENICH_TIENICH]
GO
ALTER TABLE [dbo].[OPTIONLOC]  WITH CHECK ADD  CONSTRAINT [FK_OPTIONLOC_BANGLOC] FOREIGN KEY([IDBANG])
REFERENCES [dbo].[BANGLOC] ([IDBANG])
GO
ALTER TABLE [dbo].[OPTIONLOC] CHECK CONSTRAINT [FK_OPTIONLOC_BANGLOC]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_QLPHONGKS_KHACHSAN] FOREIGN KEY([MAKHACHSAN])
REFERENCES [dbo].[KHACHSAN] ([MAKHACHSAN])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_QLPHONGKS_KHACHSAN]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_QLPHONGKS_LOAIPHONG] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIPHONG] ([MALOAI])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_QLPHONGKS_LOAIPHONG]
GO
ALTER TABLE [dbo].[PHONGDV_FEE]  WITH CHECK ADD  CONSTRAINT [FK_PHONGDV_FEE_DICHVU] FOREIGN KEY([MADV])
REFERENCES [dbo].[DICHVU] ([MADV])
GO
ALTER TABLE [dbo].[PHONGDV_FEE] CHECK CONSTRAINT [FK_PHONGDV_FEE_DICHVU]
GO
ALTER TABLE [dbo].[PHONGDV_FEE]  WITH CHECK ADD  CONSTRAINT [FK_PHONGDV_FEE_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[PHONGDV_FEE] CHECK CONSTRAINT [FK_PHONGDV_FEE_PHONG]
GO
ALTER TABLE [dbo].[PHONGDV_FREE]  WITH CHECK ADD  CONSTRAINT [FK_PHONGDV_FREE_DICHVU] FOREIGN KEY([MADV])
REFERENCES [dbo].[DICHVU] ([MADV])
GO
ALTER TABLE [dbo].[PHONGDV_FREE] CHECK CONSTRAINT [FK_PHONGDV_FREE_DICHVU]
GO
ALTER TABLE [dbo].[PHONGDV_FREE]  WITH CHECK ADD  CONSTRAINT [FK_PHONGDV_FREE_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[PHONGDV_FREE] CHECK CONSTRAINT [FK_PHONGDV_FREE_PHONG]
GO
USE [master]
GO
ALTER DATABASE [QLDPKS] SET  READ_WRITE 
GO
