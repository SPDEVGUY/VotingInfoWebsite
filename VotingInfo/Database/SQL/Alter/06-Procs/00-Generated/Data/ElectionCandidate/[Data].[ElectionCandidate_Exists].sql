-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionCandidate_Exists]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionCandidate_Exists]
GO--
CREATE PROCEDURE [Data].[ElectionCandidate_Exists]
			@ElectionCandidateId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	IF EXISTS(
		SELECT * FROM [Data].[ElectionCandidate]
		WHERE	[ElectionCandidateId] = @ElectionCandidateId
	) BEGIN
		SELECT CAST(1 as bit) as [Exists]
	END ELSE BEGIN
		SELECT CAST(0 as bit) as [Exists]
	END
END
