-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionCandidate_SelectBy_ElectionCandidateId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionCandidate_SelectBy_ElectionCandidateId]
GO--
CREATE PROCEDURE [Data].[ElectionCandidate_SelectBy_ElectionCandidateId] 
			@ElectionCandidateId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionCandidateId],
			[ContentInspectionId],
			[CandidateId],
			[ElectionId],
			[IsWinner],
			[ReportedVoteCount]
	FROM	[Data].[ElectionCandidate]
	WHERE	[ElectionCandidateId] = @ElectionCandidateId

END