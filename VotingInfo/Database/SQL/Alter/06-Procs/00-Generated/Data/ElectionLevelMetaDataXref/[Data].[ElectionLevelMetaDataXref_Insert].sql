-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevelMetaDataXref_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevelMetaDataXref_Insert]
GO--
CREATE PROCEDURE [Data].[ElectionLevelMetaDataXref_Insert]
			@ContentInspectionId int,
			@ElectionLevelId int,
			@MetaDataId nchar(10) = NULL
AS --Generated--
BEGIN

	INSERT INTO [Data].[ElectionLevelMetaDataXref] (

			[ContentInspectionId],
			[ElectionLevelId],
			[MetaDataId]
	) VALUES (

			@ContentInspectionId,
			@ElectionLevelId,
			@MetaDataId
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [ElectionLevelMetaDataXrefId]
END