-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[CandidateMetaData_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[CandidateMetaData_Delete]
GO--
CREATE PROCEDURE [Data].[CandidateMetaData_Delete] 
			@CandidateMetaDataId int
AS --Generated--
BEGIN

	DELETE FROM	[Data].[CandidateMetaData]
	WHERE	[CandidateMetaDataId] = @CandidateMetaDataId

END