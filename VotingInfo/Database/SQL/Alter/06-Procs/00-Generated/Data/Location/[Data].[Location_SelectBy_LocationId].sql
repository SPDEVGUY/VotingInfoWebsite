-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Location_SelectBy_LocationId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Location_SelectBy_LocationId]
GO--
CREATE PROCEDURE [Data].[Location_SelectBy_LocationId] 
			@LocationId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[LocationId],
			[ContentInspectionId],
			[LocationName]
	FROM	[Data].[Location]
	WHERE	[LocationId] = @LocationId

END