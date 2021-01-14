CREATE TABLE [dbo].[GL_article_list] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Barcode1] varchar(15),
  [Barcode2] varchar(15),
  [Barcode3] varchar(15),
  [Barcode4] varchar(15),
  [Article_name] varchar(30) NOT NULL,
  [Tax_id] int NOT NULL,
  [Description] text,
  [Article_note] text,
  [Exp_date] date,
  [Supplier_id] int,
  [Service] bit NOT NULL,
  [Discount] int
)
