ALTER TABLE [Data].[OrganizationMetaData]
ADD	CONSTRAINT [FK_Data_OrganizationMetaData_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_OrganizationMetaData_MetaDataId] FOREIGN KEY ([MetaDataId]) REFERENCES [Data].[MetaData] ([MetaDataId])

,	CONSTRAINT [FK_Data_OrganizationMetaData_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Data].[Organization] ([OrganizationId])

