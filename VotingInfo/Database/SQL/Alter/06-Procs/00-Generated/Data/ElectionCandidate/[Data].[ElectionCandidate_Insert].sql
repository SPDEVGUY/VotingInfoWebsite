-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionCandidate_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionCandidate_Insert]
GO--
CREATE PROCEDURE [Data].[ElectionCandidate_Insert]
			@ContentInspectionId int,
			@CandidateId int,
			@ElectionId int,
			@IsWinner bit,
			@ReportedVoteCount bit
AS --Generated--
BEGIN

	INSERT INTO [Data].[ElectionCandidate] (

			[ContentInspectionId],
			[CandidateId],
			[ElectionId],
			[IsWinner],
			[ReportedVoteCount]
	) VALUES (

			@ContentInspectionId,
			@CandidateId,
			@ElectionId,
			@IsWinner,
			@ReportedVoteCount
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [ElectionCandidateId]
END