-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_SelectBy_CandidateId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_SelectBy_CandidateId]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_SelectBy_CandidateId] 
			@CandidateId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[CandidateMetaDataId],
			[ContentInspectionId],
			[CandidateId],
			[MetaDataId],
			[MetaDataValue]
	FROM	[Data].[CandidateMetaData]
	WHERE	[CandidateId] = @CandidateId

END