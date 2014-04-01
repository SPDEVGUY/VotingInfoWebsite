-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_SelectAll]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_SelectAll]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_SelectAll]
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

END