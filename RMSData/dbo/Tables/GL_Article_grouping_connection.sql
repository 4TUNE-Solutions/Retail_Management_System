CREATE TABLE [dbo].[GL_article_grouping_connection] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Group_id] int NULL,
  [Sub_group_id] int NULL,
  [Article_id] int NOT NULL
)
