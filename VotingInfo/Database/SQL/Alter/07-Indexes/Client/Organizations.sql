CREATE UNIQUE CLUSTERED INDEX [IX_Client_Organizations_OrganizationId] 
	ON [Client].[Organizations] ([OrganizationId])

CREATE  NONCLUSTERED INDEX [IX_Client_Organizations_ContentInspectionId] 
	ON [Client].[Organizations] ([ContentInspectionId])

CREATE  NONCLUSTERED INDEX [IX_Client_Organizations_ProposedByUserId] 
	ON [Client].[Organizations] ([ProposedByUserId])

CREATE  NONCLUSTERED INDEX [IX_Client_Organizations_ConfirmedByUserId] 
	ON [Client].[Organizations] ([ConfirmedByUserId])
