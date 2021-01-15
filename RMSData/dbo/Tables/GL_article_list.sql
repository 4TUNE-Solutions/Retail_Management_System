CREATE TABLE [dbo].[GL_article_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Barcode] VARCHAR(50) NULL, 
    [Barcode2] VARCHAR(50) NULL, 
    [Barcode3] VARCHAR(50) NULL, 
    [Barcode4] VARCHAR(50) NULL, 
    [ArticleName] VARCHAR(50) NOT NULL, 
    [TaxId] INT NOT NULL, 
    [Description] TEXT NULL, 
    [ArticleNote] TEXT NULL, 
    [ExpDate] DATE NULL, 
    [SupplierId] INT NULL, 
    [IsService] BIT NOT NULL, 
    [Discount] INT NULL,

)
