-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Organization_List]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Organization_List]
GO--
CREATE PROCEDURE [Data].[Organization_List] 
			@OrganizationName varchar(250) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
		[OrganizationId] as [ListKey],
		[OrganizationName] AS [ListLabel]			
	FROM	[Data].[Organization]
	WHERE	(@OrganizationName IS NULL OR [OrganizationName] LIKE '%' + @OrganizationName + '%')
	ORDER BY [ListLabel] ASC

END