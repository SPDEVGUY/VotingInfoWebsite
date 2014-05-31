-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[Locations_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[Locations_Search]
GO--
CREATE PROCEDURE [Client].[Locations_Search] 
			@LocationName varchar(150) = NULL,
			@SourceUrl varchar(250) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[LocationId],
			[ContentInspectionId],
			[LocationName],
			[IsArchived],
			[IsBeingProposed],
			[ProposedByUserId],
			[ConfirmedByUserId],
			[FalseInfoCount],
			[TrueInfoCount],
			[AdminInpsected],
			[DateLastChecked],
			[SourceUrl]
	FROM	[Client].[Locations]
	WHERE	(@LocationName IS NULL OR [LocationName] LIKE '%' + @LocationName + '%')
			AND (@SourceUrl IS NULL OR [SourceUrl] LIKE '%' + @SourceUrl + '%')

END