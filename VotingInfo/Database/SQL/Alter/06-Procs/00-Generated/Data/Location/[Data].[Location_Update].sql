-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Location_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Location_Update]
GO--
CREATE PROCEDURE [Data].[Location_Update] 
			@LocationId int,
			@ContentInspectionId int,
			@LocationName varchar(150)
AS --Generated--
BEGIN

	UPDATE	[Data].[Location] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[LocationName] = @LocationName
	WHERE	[LocationId] = @LocationId

END