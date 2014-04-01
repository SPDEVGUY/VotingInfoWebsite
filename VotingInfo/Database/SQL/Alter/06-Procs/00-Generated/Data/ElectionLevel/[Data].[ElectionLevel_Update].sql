-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevel_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevel_Update]
GO--
CREATE PROCEDURE [Data].[ElectionLevel_Update] 
			@ElectionLevelId int,
			@ContentInspectionId int,
			@ElectionLevelTitle varchar(150)
AS --Generated--
BEGIN

	UPDATE	[Data].[ElectionLevel] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[ElectionLevelTitle] = @ElectionLevelTitle
	WHERE	[ElectionLevelId] = @ElectionLevelId

END