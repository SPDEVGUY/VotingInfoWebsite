-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_Update]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_Update] 
			@CandidateMetaDataId int,
			@ContentInspectionId int,
			@CandidateId int,
			@MetaDataId int,
			@MetaDataValue varchar(max)
AS --Generated--
BEGIN

	UPDATE	[Data].[CandidateMetaData] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[CandidateId] = @CandidateId,
			[MetaDataId] = @MetaDataId,
			[MetaDataValue] = @MetaDataValue
	WHERE	[CandidateMetaDataId] = @CandidateMetaDataId

END