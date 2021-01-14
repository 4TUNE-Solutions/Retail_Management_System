CREATE TABLE [dbo].[GL_article_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Barcode] VARCHAR(50) NULL, 
    [Barcode2] VARCHAR(50) NULL, 
    [Barcode3] VARCHAR(50) NULL, 
    [Barcode4] VARCHAR(50) NULL, 
    [Article_name] VARCHAR(50) NOT NULL, 
    [Tax_id] INT NOT NULL, 
    [Description] TEXT NULL, 
    [Article_note] TEXT NULL, 
    [Exp_date] DATE NULL, 
    [Supplier_id] INT NULL, 
    [Service] BIT NOT NULL, 
    [Discount] INT NULL,

)
