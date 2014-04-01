-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevelMetaDataXref_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevelMetaDataXref_Search]
GO--
CREATE PROCEDURE [Data].[ElectionLevelMetaDataXref_Search] 
			@MetaDataId nchar(10) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionLevelMetaDataXrefId],
			[ContentInspectionId],
			[ElectionLevelId],
			[MetaDataId]
	FROM	[Data].[ElectionLevelMetaDataXref]
	WHERE	(@MetaDataId IS NULL OR [MetaDataId] LIKE '%' + @MetaDataId + '%')

END