ALTER TABLE [Data].[ContentInspection]
ADD	CONSTRAINT [FK_Data_ContentInspection_ConfirmedByUserId] FOREIGN KEY ([ConfirmedByUserId]) REFERENCES [Auth].[User] ([UserId])

,	CONSTRAINT [FK_Data_ContentInspection_ProposedByUserId] FOREIGN KEY ([ProposedByUserId]) REFERENCES [Auth].[User] ([UserId])

