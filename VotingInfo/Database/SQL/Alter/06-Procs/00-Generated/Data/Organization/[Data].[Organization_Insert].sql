-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Organization_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Organization_Insert]
GO--
CREATE PROCEDURE [Data].[Organization_Insert]
			@ContentInspectionId int,
			@OrganizationName varchar(250)
AS --Generated--
BEGIN

	INSERT INTO [Data].[Organization] (

			[ContentInspectionId],
			[OrganizationName]
	) VALUES (

			@ContentInspectionId,
			@OrganizationName
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [OrganizationId]
END