ALTER TABLE [Data].[Election]
ADD	CONSTRAINT [FK_Data_Election_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_Election_ElectionLevelId] FOREIGN KEY ([ElectionLevelId]) REFERENCES [Data].[ElectionLevel] ([ElectionLevelId])

