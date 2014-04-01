-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[MetaData_List]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[MetaData_List]
GO--
CREATE PROCEDURE [Data].[MetaData_List] 
			@MetaDataName varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
		[MetaDataId] as [ListKey],
		[MetaDataName] AS [ListLabel]			
	FROM	[Data].[MetaData]
	WHERE	(@MetaDataName IS NULL OR [MetaDataName] LIKE '%' + @MetaDataName + '%')
	ORDER BY [ListLabel] ASC

END