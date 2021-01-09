CREATE TABLE [dbo].[GL_article_sub_group] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Group_id] int,
  [Sub_group_id] int,
  [Sub_group_name] varchar(20),
  [Sub_group_color] varchar(20),
  [Discount_amount] int
)
GO
