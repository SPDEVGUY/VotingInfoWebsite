-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevelMetaDataXref_SelectBy_ElectionLevelMetaDataXrefId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevelMetaDataXref_SelectBy_ElectionLevelMetaDataXrefId]
GO--
CREATE PROCEDURE [Data].[ElectionLevelMetaDataXref_SelectBy_ElectionLevelMetaDataXrefId] 
			@ElectionLevelMetaDataXrefId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionLevelMetaDataXrefId],
			[ContentInspectionId],
			[ElectionLevelId],
			[MetaDataId]
	FROM	[Data].[ElectionLevelMetaDataXref]
	WHERE	[ElectionLevelMetaDataXrefId] = @ElectionLevelMetaDataXrefId

END