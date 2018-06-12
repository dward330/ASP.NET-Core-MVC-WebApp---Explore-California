USE [DerrickBlog_Special]
GO
DELETE FROM [dbo].[Specials]
GO
SET IDENTITY_INSERT [dbo].[Specials] ON 

INSERT [dbo].[Specials] ([Id], [Key], [Name], [Price], [Type]) VALUES (1, N'calm', N'California Calm', 250, N'Day Spa Package')
INSERT [dbo].[Specials] ([Id], [Key], [Name], [Price], [Type]) VALUES (2, N'desert', N'From Desert to Sea', 350, N'Day Salton Sea')
INSERT [dbo].[Specials] ([Id], [Key], [Name], [Price], [Type]) VALUES (3, N'backpack', N'Backpack Cali', 620, N'Big Sur Retreat')
INSERT [dbo].[Specials] ([Id], [Key], [Name], [Price], [Type]) VALUES (4, N'taste', N'Taste of California', 150, N'Tapas & Groves')
SET IDENTITY_INSERT [dbo].[Specials] OFF
