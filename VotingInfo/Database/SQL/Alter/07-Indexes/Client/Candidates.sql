CREATE UNIQUE CLUSTERED INDEX [IX_Client_Candidates_CandidateId] 
	ON [Client].[Candidates] ([CandidateId])

CREATE  NONCLUSTERED INDEX [IX_Client_Candidates_ContentInspectionId] 
	ON [Client].[Candidates] ([ContentInspectionId])

CREATE  NONCLUSTERED INDEX [IX_Client_Candidates_OrganizationId] 
	ON [Client].[Candidates] ([OrganizationId])

CREATE  NONCLUSTERED INDEX [IX_Client_Candidates_ProposedByUserId] 
	ON [Client].[Candidates] ([ProposedByUserId])

CREATE  NONCLUSTERED INDEX [IX_Client_Candidates_ConfirmedByUserId] 
	ON [Client].[Candidates] ([ConfirmedByUserId])
