CREATE PROCEDURE [dbo].[spArticle_Change]
	@id int,
	@barcode varchar(50),
	@barcode2 varchar(50) = NULL ,
	@barcode3 varchar(50) = NULL,
	@barcode4 varchar(50) = NULL,
	@articleName varchar(50), 
	@taxId int,
	@description text = NULL,
	@articleNote text = NULL, 
	@expDate date = NULL,
	@supplierId int = NULL, 
	@isService bit,
	@discount int = NULL

AS
BEGIN

	SET NOCOUNT ON;

	UPDATE GL_article_list
	SET Barcode = @barcode, Barcode2 = @barcode2, Barcode3 = @barcode3, Barcode4 = @barcode4,
		ArticleName = @articleName, TaxId = @taxId, Description = @description, ArticleNote = @articleNote,
		ExpDate = @expDate, SupplierId = @supplierId, IsService = @isService, Discount = @discount
	WHERE Id = @id;

END