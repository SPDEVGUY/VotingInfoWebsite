-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_Insert]
GO--
CREATE PROCEDURE [Data].[Candidate_Insert]
			@ContentInspectionId int,
			@CandidateName varchar(150),
			@OrganizationId int
AS --Generated--
BEGIN

	INSERT INTO [Data].[Candidate] (

			[ContentInspectionId],
			[CandidateName],
			[OrganizationId]
	) VALUES (

			@ContentInspectionId,
			@CandidateName,
			@OrganizationId
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [CandidateId]
END