-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ContentInspection_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ContentInspection_Delete]
GO--
CREATE PROCEDURE [Data].[ContentInspection_Delete] 
			@ContentInspectionId int
AS --Generated--
BEGIN

	DELETE FROM	[Data].[ContentInspection]
	WHERE	[ContentInspectionId] = @ContentInspectionId

END