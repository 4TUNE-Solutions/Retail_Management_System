CREATE TABLE [dbo].[GL_article_list] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Barcode1] varchar(15),
  [Barcode2] varchar(15),
  [Barcode3] varchar(15),
  [Barcode4] varchar(15),
  [Article_name] varchar(30),
  [Sub_group1] int,
  [Sub_group2] int,
  [Sub_group3] int,
  [Measure_unit] varchar(5),
  [Tax_id] int,
  [Description] text,
  [Article_note] text,
  [Exp_date] date,
  [Supplier_id] int,
  [Service] bit,
  [Discount] int
)