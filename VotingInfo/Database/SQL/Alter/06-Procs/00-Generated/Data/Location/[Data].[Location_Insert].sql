-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Location_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Location_Insert]
GO--
CREATE PROCEDURE [Data].[Location_Insert]
			@ContentInspectionId int,
			@LocationName varchar(150)
AS --Generated--
BEGIN

	INSERT INTO [Data].[Location] (

			[ContentInspectionId],
			[LocationName]
	) VALUES (

			@ContentInspectionId,
			@LocationName
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [LocationId]
END