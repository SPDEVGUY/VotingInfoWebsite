-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_SelectBy_UserId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_SelectBy_UserId]
GO--
CREATE PROCEDURE [Data].[Candidate_SelectBy_UserId] 
			@UserId int
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
	WHERE	[UserId] = @UserId

END