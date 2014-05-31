-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Voter_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Voter_Insert]
GO--
CREATE PROCEDURE [Data].[Voter_Insert]
			@UserId int,
			@ContentInspectionId int,
			@LocationId int,
			@VoterName varchar(150),
			@PostalCode char(6),
			@FavoriteOrganizationId int
AS --Generated--
BEGIN

	INSERT INTO [Data].[Voter] (

			[UserId],
			[ContentInspectionId],
			[LocationId],
			[VoterName],
			[PostalCode],
			[FavoriteOrganizationId]
	) VALUES (

			@UserId,
			@ContentInspectionId,
			@LocationId,
			@VoterName,
			@PostalCode,
			@FavoriteOrganizationId
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [VoterId]
END