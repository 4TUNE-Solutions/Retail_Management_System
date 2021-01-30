CREATE PROCEDURE [dbo].[spArticle_New]
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

	INSERT INTO GL_article_list
	VALUES(@barcode, @barcode2, @barcode3, @barcode4,
	@articleName, @taxId, @description, @articleNote, @expDate,
	@supplierId, @isService, @discount);

END