-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevelMetaDataXref_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevelMetaDataXref_Update]
GO--
CREATE PROCEDURE [Data].[ElectionLevelMetaDataXref_Update] 
			@ElectionLevelMetaDataXrefId int,
			@ContentInspectionId int,
			@ElectionLevelId int,
			@MetaDataId nchar(10) = NULL
AS --Generated--
BEGIN

	UPDATE	[Data].[ElectionLevelMetaDataXref] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[ElectionLevelId] = @ElectionLevelId,
			[MetaDataId] = @MetaDataId
	WHERE	[ElectionLevelMetaDataXrefId] = @ElectionLevelMetaDataXrefId

END