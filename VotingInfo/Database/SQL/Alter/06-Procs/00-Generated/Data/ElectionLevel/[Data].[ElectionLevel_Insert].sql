-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevel_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevel_Insert]
GO--
CREATE PROCEDURE [Data].[ElectionLevel_Insert]
			@ContentInspectionId int,
			@ElectionLevelTitle varchar(150)
AS --Generated--
BEGIN

	INSERT INTO [Data].[ElectionLevel] (

			[ContentInspectionId],
			[ElectionLevelTitle]
	) VALUES (

			@ContentInspectionId,
			@ElectionLevelTitle
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [ElectionLevelId]
END