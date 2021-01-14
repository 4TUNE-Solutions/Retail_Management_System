CREATE TABLE [dbo].[GL_article_group] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Group_name] varchar(20) NOT NULL,
  [Group_color] varchar(20),
  [Discount_amount] int
)
