/****** Object:  Table [dbo].[userinfo]    Script Date: 06/10/2015 15:18:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[userinfo]') AND type in (N'U'))
DROP TABLE [dbo].[userinfo]
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 06/10/2015 15:18:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[userinfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[userinfo](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[lname] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_userinfo] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[userinfo] ON
INSERT [dbo].[userinfo] ([userid], [fname], [lname]) VALUES (1, N'Brijesh', N'Patil')
INSERT [dbo].[userinfo] ([userid], [fname], [lname]) VALUES (2, N'Yogesh', N'PAnde')
INSERT [dbo].[userinfo] ([userid], [fname], [lname]) VALUES (3, N'Kailash', N'Solanki')
SET IDENTITY_INSERT [dbo].[userinfo] OFF
