ALTER TABLE [Data].[Voter]
ADD	CONSTRAINT [FK_Data_Voter_UserId] FOREIGN KEY ([UserId]) REFERENCES [Auth].[User] ([UserId])

,	CONSTRAINT [FK_Data_Voter_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_Voter_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Data].[Location] ([LocationId])

,	CONSTRAINT [FK_Data_Voter_FavoriteOrganizationId] FOREIGN KEY ([FavoriteOrganizationId]) REFERENCES [Data].[Organization] ([OrganizationId])

