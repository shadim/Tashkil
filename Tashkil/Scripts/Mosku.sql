USE [Tashkil]
GO

ALTER TABLE [dbo].[Mosku] DROP CONSTRAINT [FK_Masjed_Markaz]
GO

ALTER TABLE [dbo].[Mosku] DROP CONSTRAINT [FK_Masjed_Halaka]
GO

/****** Object:  Table [dbo].[Mosku]    Script Date: 10/16/2015 5:39:53 PM ******/
DROP TABLE [dbo].[Mosku]
GO

/****** Object:  Table [dbo].[Mosku]    Script Date: 10/16/2015 5:39:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Mosku](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[HalakaID] [int] NOT NULL,
	[MarkazID] [int] NOT NULL,
	[MuslimCount] [int] NOT NULL,
	[PrayerCount] [int] NOT NULL,
	[MemberCount] [int] NOT NULL,
 CONSTRAINT [PK_Masjed] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Mosku]  WITH CHECK ADD  CONSTRAINT [FK_Masjed_Halaka] FOREIGN KEY([HalakaID])
REFERENCES [dbo].[Halaka] ([ID])
GO

ALTER TABLE [dbo].[Mosku] CHECK CONSTRAINT [FK_Masjed_Halaka]
GO

ALTER TABLE [dbo].[Mosku]  WITH CHECK ADD  CONSTRAINT [FK_Masjed_Markaz] FOREIGN KEY([MarkazID])
REFERENCES [dbo].[Markaz] ([ID])
GO

ALTER TABLE [dbo].[Mosku] CHECK CONSTRAINT [FK_Masjed_Markaz]
GO


