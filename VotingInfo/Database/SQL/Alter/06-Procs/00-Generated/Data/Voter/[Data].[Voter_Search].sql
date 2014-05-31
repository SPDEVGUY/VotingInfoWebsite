-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Voter_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Voter_Search]
GO--
CREATE PROCEDURE [Data].[Voter_Search] 
			@VoterName varchar(150) = NULL,
			@PostalCode char(6) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[VoterId],
			[UserId],
			[ContentInspectionId],
			[LocationId],
			[VoterName],
			[PostalCode],
			[FavoriteOrganizationId]
	FROM	[Data].[Voter]
	WHERE	(@VoterName IS NULL OR [VoterName] LIKE '%' + @VoterName + '%')
			AND (@PostalCode IS NULL OR [PostalCode] LIKE '%' + @PostalCode + '%')

END