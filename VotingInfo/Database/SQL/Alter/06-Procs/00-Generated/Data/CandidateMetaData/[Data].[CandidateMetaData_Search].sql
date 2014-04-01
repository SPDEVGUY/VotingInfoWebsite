-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_Search]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_Search] 
			@MetaDataValue varchar(max) = NULL
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
	WHERE	(@MetaDataValue IS NULL OR [MetaDataValue] LIKE '%' + @MetaDataValue + '%')

END