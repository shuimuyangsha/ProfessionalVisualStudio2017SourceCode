-- <Migration ID="63c2f1c0-da59-4cd3-a573-6094f4381589" />
GO

PRINT N'Altering [dbo].[Customer]'
GO
ALTER TABLE [dbo].[Customer] ADD
[Address] [nvarchar] (255) NULL
GO
