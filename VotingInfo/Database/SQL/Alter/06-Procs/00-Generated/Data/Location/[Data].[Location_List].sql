-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Location_List]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Location_List]
GO--
CREATE PROCEDURE [Data].[Location_List] 
			@LocationName varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
		[LocationId] as [ListKey],
		[LocationName] AS [ListLabel]			
	FROM	[Data].[Location]
	WHERE	(@LocationName IS NULL OR [LocationName] LIKE '%' + @LocationName + '%')
	ORDER BY [ListLabel] ASC

END