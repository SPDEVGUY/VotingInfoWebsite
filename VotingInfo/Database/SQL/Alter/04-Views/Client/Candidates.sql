CREATE VIEW [Client].[Candidates] WITH SCHEMABINDING
AS
SELECT	
		C.[CandidateId],
		C.[ContentInspectionId],
		C.[CandidateName],
		C.[OrganizationId],
		CI.[IsArchived],
		CI.[IsBeingProposed],
		CI.[ProposedByUserId],
		CI.[ConfirmedByUserId],
		CI.[FalseInfoCount],
		CI.[TrueInfoCount],
		CI.[AdminInpsected],
		CI.[DateLastChecked],
		CI.[SourceUrl]
FROM	[Data].[Candidate] C
INNER JOIN [Data].[ContentInspection] CI
	ON C.[ContentInspectionId] = CI.[ContentInspectionId]

