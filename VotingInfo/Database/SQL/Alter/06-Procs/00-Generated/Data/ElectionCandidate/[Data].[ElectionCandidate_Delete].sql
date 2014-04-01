-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionCandidate_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionCandidate_Delete]
GO--
CREATE PROCEDURE [Data].[ElectionCandidate_Delete] 
			@ElectionCandidateId int
AS --Generated--
BEGIN

	DELETE FROM	[Data].[ElectionCandidate]
	WHERE	[ElectionCandidateId] = @ElectionCandidateId

END