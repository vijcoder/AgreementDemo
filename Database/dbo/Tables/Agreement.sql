
CREATE TABLE [dbo].[Agreement](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](50) NOT NULL,
	[ProductGroupId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[EffectiveDate] [datetime] NOT NULL,
	[ExpirationDate] [datetime] NOT NULL,
	[ProductPrice] [decimal](18, 2) NULL,
	[NewPrice] [decimal](18, 2) NULL,
	[IsActive] [bit] NOT NULL,
	[WhenEntered] [datetime] NOT NULL,
	[WhenModified] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Agreement] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

 