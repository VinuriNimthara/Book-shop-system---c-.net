# [dbo].[USERS]

USE [BOOK_STORE]
GO

/****** Object:  Table [dbo].[USERS]    Script Date: 2/16/2024 7:06:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERS](
    [Customer_Name] [varchar](20) NULL,
    [NIC_NO] [varchar](15) NULL,
    [Contact_No] [int] NULL,
    [Email] [varchar](30) NULL,
    [Book_Name] [varchar](20) NULL,
    [ISBN_No] [int] NULL,
    [Book_No] [int] NULL,
    [Book_Type] [varchar](20) NULL
) ON [PRIMARY]
GO
