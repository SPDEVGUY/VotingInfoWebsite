-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_List]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_List]
GO--
CREATE PROCEDURE [Data].[Candidate_List] 
			@CandidateName varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
		[CandidateId] as [ListKey],
		[CandidateName] AS [ListLabel]			
	FROM	[Data].[Candidate]
	WHERE	(@CandidateName IS NULL OR [CandidateName] LIKE '%' + @CandidateName + '%')
	ORDER BY [ListLabel] ASC

END