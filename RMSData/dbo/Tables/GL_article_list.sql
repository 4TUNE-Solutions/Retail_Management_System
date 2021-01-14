CREATE TABLE [dbo].[GL_article_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Barcode] VARCHAR(50) NULL, 
    [Barcode2] VARCHAR(50) NULL, 
    [Barcode3] VARCHAR(50) NULL, 
    [Barcode4] VARCHAR(50) NULL, 
    [Article_name] VARCHAR(50) NOT NULL, 
    [Tax_id] INT NOT NULL, 
    [Description] VARCHAR(50) NULL, 
    [Article_note] VARCHAR(50) NULL, 
    [Exp_date] DATETIME2 NULL, 
    [Supplier_id] INT NULL, 
    [Service] BIT NOT NULL, 
    [Discount] INT NULL,

)
