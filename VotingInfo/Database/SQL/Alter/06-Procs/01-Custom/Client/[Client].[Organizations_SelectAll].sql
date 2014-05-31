
IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[Organizations_SelectAll]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[Organizations_SelectAll]
GO--
CREATE PROCEDURE [Client].[Organizations_SelectAll]
AS 
BEGIN
	SET NOCOUNT ON;

	SELECT	*
	FROM	[Client].[Organizations]
	ORDER BY [OrganizationName] ASC

END