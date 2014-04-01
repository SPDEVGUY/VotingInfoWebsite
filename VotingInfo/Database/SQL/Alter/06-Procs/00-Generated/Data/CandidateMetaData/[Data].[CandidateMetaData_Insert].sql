-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_Insert]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_Insert]
			@ContentInspectionId int,
			@CandidateId int,
			@MetaDataId int,
			@MetaDataValue varchar(max)
AS --Generated--
BEGIN

	INSERT INTO [Data].[CandidateMetaData] (

			[ContentInspectionId],
			[CandidateId],
			[MetaDataId],
			[MetaDataValue]
	) VALUES (

			@ContentInspectionId,
			@CandidateId,
			@MetaDataId,
			@MetaDataValue
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [CandidateMetaDataId]
END