CREATE VIEW [Client].[Locations] WITH SCHEMABINDING
AS
SELECT	
		L.[LocationId],
		L.[ContentInspectionId],
		L.[LocationName],
		CI.[IsArchived],
		CI.[IsBeingProposed],
		CI.[ProposedByUserId],
		CI.[ConfirmedByUserId],
		CI.[FalseInfoCount],
		CI.[TrueInfoCount],
		CI.[AdminInpsected],
		CI.[DateLastChecked],
		CI.[SourceUrl]
FROM	[Data].[Location] L
INNER JOIN [Data].[ContentInspection] CI
	ON L.[ContentInspectionId] = CI.[ContentInspectionId]

