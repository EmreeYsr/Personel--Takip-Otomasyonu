USE [Personel]
GO

/****** Object:  Table [dbo].[Personel]    Script Date: 2.01.2025 09:50:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Personel](
	[p_no] [int] IDENTITY(1,1) NOT NULL,
	[p_ad] [nvarchar](50) NOT NULL,
	[p_soyad] [nvarchar](50) NOT NULL,
	[cinsiyet] [nvarchar](10) NOT NULL,
	[dogum_tarihi] [date] NOT NULL,
	[dogum_yeri] [nvarchar](50) NOT NULL,
	[ise_baslama_tarihi] [datetime] NOT NULL,
	[birim] [nvarchar](50) NOT NULL,
	[unvan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[p_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

