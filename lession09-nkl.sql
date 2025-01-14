USE [K22CNT3-NguyenKhanhLinh]
GO
/****** Object:  Table [dbo].[nklKhoa]    Script Date: 12/06/2024 10:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nklKhoa](
	[NklMaKH] [nchar](10) NOT NULL,
	[NklTenKH] [varchar](50) NULL,
	[NklTrangThai] [bit] NULL,
 CONSTRAINT [PK_nklKhoa] PRIMARY KEY CLUSTERED 
(
	[NklMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nklSinhVien]    Script Date: 12/06/2024 10:41:50 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nklSinhVien](
	[NklMaSV] [nvarchar](50) NOT NULL,
	[NklHoSV] [nvarchar](50) NULL,
	[NklNgaySinh] [date] NULL,
	[NklPhai] [bit] NULL,
	[NklPhone] [nchar](10) NULL,
	[NkllEmail] [nvarchar](50) NULL,
	[NklMaKH] [nchar](10) NULL,
 CONSTRAINT [PK_nklSinhVien] PRIMARY KEY CLUSTERED 
(
	[NklMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[nklSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_nklSinhVien_nklKhoa] FOREIGN KEY([NklMaKH])
REFERENCES [dbo].[nklKhoa] ([NklMaKH])
GO
ALTER TABLE [dbo].[nklSinhVien] CHECK CONSTRAINT [FK_nklSinhVien_nklKhoa]
GO
