ALTER TABLE [Data].[ElectionLevelMetaDataXref]
ADD	CONSTRAINT [FK_Data_ElectionLevelMetaDataXref_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_ElectionLevelMetaDataXref_ElectionLevelId] FOREIGN KEY ([ElectionLevelId]) REFERENCES [Data].[ElectionLevel] ([ElectionLevelId])

