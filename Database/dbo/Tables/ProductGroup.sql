CREATE TABLE [dbo].[ProductGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GroupDescription] [varchar](250) NOT NULL,
	[GroupCode] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[WhenEntered] [datetime] NOT NULL,
	[WhenModified] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_ProductGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO