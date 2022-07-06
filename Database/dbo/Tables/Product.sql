CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductGroupId] [int] NOT NULL,
	[ProductDescription] [varchar](250) NULL,
	[ProductNumber] [varchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[WhenEntered] [datetime] NOT NULL,
	[WhenModified] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO