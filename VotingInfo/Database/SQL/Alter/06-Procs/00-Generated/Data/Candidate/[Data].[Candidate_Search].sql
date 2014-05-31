-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_Search]
GO--
CREATE PROCEDURE [Data].[Candidate_Search] 
			@CandidateName varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[CandidateId],
			[UserId],
			[ContentInspectionId],
			[LocationId],
			[OrganizationId],
			[CandidateName]
	FROM	[Data].[Candidate]
	WHERE	(@CandidateName IS NULL OR [CandidateName] LIKE '%' + @CandidateName + '%')

END