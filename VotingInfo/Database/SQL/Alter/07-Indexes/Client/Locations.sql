CREATE UNIQUE CLUSTERED INDEX [IX_Client_Locations_LocationId] 
	ON [Client].[Locations] ([LocationId])

CREATE  NONCLUSTERED INDEX [IX_Client_Locations_ContentInspectionId] 
	ON [Client].[Locations] ([ContentInspectionId])

CREATE  NONCLUSTERED INDEX [IX_Client_Locations_ProposedByUserId] 
	ON [Client].[Locations] ([ProposedByUserId])

CREATE  NONCLUSTERED INDEX [IX_Client_Locations_ConfirmedByUserId] 
	ON [Client].[Locations] ([ConfirmedByUserId])
