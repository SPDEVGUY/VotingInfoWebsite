-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ContentInspection_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ContentInspection_Insert]
GO--
CREATE PROCEDURE [Data].[ContentInspection_Insert]
			@IsArchived bit,
			@IsBeingProposed bit,
			@ProposedByUserId int,
			@ConfirmedByUserId int,
			@FalseInfoCount int,
			@TrueInfoCount int,
			@AdminInpsected bit,
			@DateLastChecked datetime,
			@SourceUrl varchar(250)
AS --Generated--
BEGIN

	INSERT INTO [Data].[ContentInspection] (

			[IsArchived],
			[IsBeingProposed],
			[ProposedByUserId],
			[ConfirmedByUserId],
			[FalseInfoCount],
			[TrueInfoCount],
			[AdminInpsected],
			[DateLastChecked],
			[SourceUrl]
	) VALUES (

			@IsArchived,
			@IsBeingProposed,
			@ProposedByUserId,
			@ConfirmedByUserId,
			@FalseInfoCount,
			@TrueInfoCount,
			@AdminInpsected,
			@DateLastChecked,
			@SourceUrl
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [ContentInspectionId]
END