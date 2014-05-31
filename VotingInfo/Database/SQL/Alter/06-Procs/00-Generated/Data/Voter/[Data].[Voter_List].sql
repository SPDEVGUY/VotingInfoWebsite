-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Voter_List]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Voter_List]
GO--
CREATE PROCEDURE [Data].[Voter_List] 
			@VoterName varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
		[VoterId] as [ListKey],
		[VoterName] AS [ListLabel]			
	FROM	[Data].[Voter]
	WHERE	(@VoterName IS NULL OR [VoterName] LIKE '%' + @VoterName + '%')
	ORDER BY [ListLabel] ASC

END