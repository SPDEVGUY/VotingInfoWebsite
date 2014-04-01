-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_Delete]
GO--
CREATE PROCEDURE [Data].[Candidate_Delete] 
			@CandidateId int
AS --Generated--
BEGIN

	DELETE FROM	[Data].[Candidate]
	WHERE	[CandidateId] = @CandidateId

END