CREATE VIEW [Client].[Organizations] WITH SCHEMABINDING
AS
SELECT	
		O.[OrganizationId],
		O.[ContentInspectionId],
		O.[OrganizationName],
		CI.[IsArchived],
		CI.[IsBeingProposed],
		CI.[ProposedByUserId],
		CI.[ConfirmedByUserId],
		CI.[FalseInfoCount],
		CI.[TrueInfoCount],
		CI.[AdminInpsected],
		CI.[DateLastChecked],
		CI.[SourceUrl]
FROM	[Data].[Organization] O
INNER JOIN [Data].[ContentInspection] CI
	ON O.[ContentInspectionId] = CI.[ContentInspectionId]

