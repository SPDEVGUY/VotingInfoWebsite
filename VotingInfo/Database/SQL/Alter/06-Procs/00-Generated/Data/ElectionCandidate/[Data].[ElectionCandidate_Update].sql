-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionCandidate_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionCandidate_Update]
GO--
CREATE PROCEDURE [Data].[ElectionCandidate_Update] 
			@ElectionCandidateId int,
			@ContentInspectionId int,
			@CandidateId int,
			@ElectionId int,
			@IsWinner bit,
			@ReportedVoteCount bit
AS --Generated--
BEGIN

	UPDATE	[Data].[ElectionCandidate] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[CandidateId] = @CandidateId,
			[ElectionId] = @ElectionId,
			[IsWinner] = @IsWinner,
			[ReportedVoteCount] = @ReportedVoteCount
	WHERE	[ElectionCandidateId] = @ElectionCandidateId

END