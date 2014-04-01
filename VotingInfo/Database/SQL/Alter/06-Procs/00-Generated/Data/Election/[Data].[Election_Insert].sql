-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Election_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Election_Insert]
GO--
CREATE PROCEDURE [Data].[Election_Insert]
			@ContentInspectionId int,
			@ElectionLevelId int,
			@ElectionRegion varchar(150),
			@VotingDate datetime
AS --Generated--
BEGIN

	INSERT INTO [Data].[Election] (

			[ContentInspectionId],
			[ElectionLevelId],
			[ElectionRegion],
			[VotingDate]
	) VALUES (

			@ContentInspectionId,
			@ElectionLevelId,
			@ElectionRegion,
			@VotingDate
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [ElectionId]
END