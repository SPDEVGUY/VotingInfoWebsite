-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevelMetaDataXref_SelectBy_MetaDataId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevelMetaDataXref_SelectBy_MetaDataId]
GO--
CREATE PROCEDURE [Data].[ElectionLevelMetaDataXref_SelectBy_MetaDataId] 
			@MetaDataId nchar(10)
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionLevelMetaDataXrefId],
			[ContentInspectionId],
			[ElectionLevelId],
			[MetaDataId]
	FROM	[Data].[ElectionLevelMetaDataXref]
	WHERE	[MetaDataId] = @MetaDataId

END