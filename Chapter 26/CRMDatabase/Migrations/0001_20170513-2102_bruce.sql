-- <Migration ID="dbb3ba38-e7e9-4f4d-9130-95d792466e3f" />
GO

PRINT N'Creating [dbo].[Customer]'
GO
CREATE TABLE [dbo].[Customer]
(
[CustomerId] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (200) NOT NULL,
[Email] [nvarchar] (100) NULL,
[Phone] [nvarchar] (50) NULL
)
GO
PRINT N'Creating primary key [PK__tmp_ms_x__A4AE64D821F76805] on [dbo].[Customer]'
GO
ALTER TABLE [dbo].[Customer] ADD CONSTRAINT [PK__tmp_ms_x__A4AE64D821F76805] PRIMARY KEY CLUSTERED  ([CustomerId])
GO
