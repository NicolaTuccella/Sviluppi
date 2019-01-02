CREATE DATABASE [AdvancedSearchGridExampleMVC]
GO
CREATE TABLE [dbo].[FacilitySites] ([FacilitySiteID] UNIQUEIDENTIFIER NOT NULL,
                                    [FacilityName]   NVARCHAR (MAX)   NULL,
                                    [IsActive]       BIT              NOT NULL,
                                    [CreatedBy]      UNIQUEIDENTIFIER NOT NULL,
                                    [CreatedAt]      DATETIME         NOT NULL,
                                    [ModifiedBy]     UNIQUEIDENTIFIER NULL,
                                    [ModifiedAt]     DATETIME         NULL,
                                    [IsDeleted]      BIT              NOT NULL
                                   );
GO

CREATE TABLE [dbo].[Assets] (
                             [AssetID]                   UNIQUEIDENTIFIER NOT NULL,
                             [Barcode]                   NVARCHAR (MAX)   NULL,
                             [SerialNumber]              NVARCHAR (MAX)   NULL,
                             [PMGuide]                   NVARCHAR (MAX)   NULL,
                             [AstID]                     NVARCHAR (MAX)   NOT NULL,
                             [ChildAsset]                NVARCHAR (MAX)   NULL,
                             [GeneralAssetDescription]   NVARCHAR (MAX)   NULL,
                             [SecondaryAssetDescription] NVARCHAR (MAX)   NULL,
                             [Quantity]                  INT              NOT NULL,
                             [Manufacturer]              NVARCHAR (MAX)   NULL,
                             [ModelNumber]               NVARCHAR (MAX)   NULL,
                             [Building]                  NVARCHAR (MAX)   NULL,
                             [Floor]                     NVARCHAR (MAX)   NULL,
                             [Corridor]                  NVARCHAR (MAX)   NULL,
                             [RoomNo]                    NVARCHAR (MAX)   NULL,
                             [MERNo]                     NVARCHAR (MAX)   NULL,
                             [EquipSystem]               NVARCHAR (MAX)   NULL,
                             [Comments]                  NVARCHAR (MAX)   NULL,
                             [Issued]                    BIT              NOT NULL,
                             [FacilitySiteID]            UNIQUEIDENTIFIER NOT NULL
                            );

GO

CREATE NONCLUSTERED INDEX [IX_FacilitySiteID]   ON [dbo].[Assets]([FacilitySiteID] ASC);

GO
ALTER TABLE [dbo].[Assets]
    ADD CONSTRAINT [PK_dbo.Assets] PRIMARY KEY CLUSTERED ([AssetID] ASC);

GO

ALTER TABLE [dbo].[Assets]
   ADD CONSTRAINT [FK_dbo.Assets_dbo.FacilitySites_FacilitySiteID] FOREIGN KEY ([FacilitySiteID]) REFERENCES [dbo].[FacilitySites] ([FacilitySiteID]) ON DELETE CASCADE;

GO

INSERT INTO [dbo].[FacilitySites] ([FacilitySiteID], [FacilityName],
[IsActive], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt],  
[IsDeleted]) VALUES (N'526fa0d5-1872-e611-b10e-005056c00008',N'FOR', 1, 
N'8de72a70-6a35-4658-ae0d-ca3cc55da752', N'2016-09-04 01:56:08', NULL, NULL, 0)
INSERT INTO [dbo].[FacilitySites] ([FacilitySiteID], [FacilityName],  
[IsActive], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt],  
[IsDeleted]) VALUES (N'536fa0d5-1872-e611-b10e-005056c00008',  
N'Pryco', 1, N'8de72a70-6a35-4658-ae0d-ca3cc55da752',  
N'2016-09-04 01:56:08', NULL, NULL, 0)
INSERT INTO [dbo].[FacilitySites] ([FacilitySiteID], [FacilityName],  
[IsActive], [CreatedBy], [CreatedAt], [ModifiedBy], [ModifiedAt],  
[IsDeleted]) VALUES (N'546fa0d5-1872-e611-b10e-005056c00008',  
N'6rt', 1, N'8de72a70-6a35-4658-ae0d-ca3cc55da752',  
N'2016-09-04 01:56:08', NULL, NULL, 0)
GO

INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'd37cc16b-3d13-4eba-8c98-0008b409a77b', N'D04-056',  
N'N/A', N'D-04', N'D04-056', N'N/A',  
N'DOOR, HYDR/ELEC/PNEUM OPERATED', N'N/A', 1, N'KM',  
N'N/A', N'South', N'7', N'E', N'019',  
N'', N'', N'Swing', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'7be68b37-5ec3-4a8b-be48-00490049f66b', N'C06-114',  
N'N/A', N'C-06', N'C06-114', N'A11-13,C08-16',  
N'CONTROLS, CENTRAL SYSTEM, HVAC', N'N/A', 1, N'N/A',  
N'N/A', N'South', N'9', N'F', N'004',  
N'MER5 ', N'AC-SE-2', N'rtn damper', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem], [Comments],  
[Issued], [FacilitySiteID])
VALUES (N'e8a8af59-a863-4757-93bd-00561f36122b', N'C03-069',  
N'N/A', N'C-03', N'C03-069', N'',  
N'COILS, REHEAT/PREHEAT (REMOTE)', N'N/A', 1, N'N/A',  
N'N/A', N'North', N'4', N'A', N'222',  
N'', N' RH-N-17', N'', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem], [Comments],  
[Issued], [FacilitySiteID]) VALUES (N'69dcdb07-8f60-4bbf-ad05-0078f3902c48',  
N'D06-300', N'N/A', N'D-06', N'D06-300',  
N'', N'DRAIN, AREAWAY/DRIVEWAY/STORM', N'N/A', 1,  
N'N/A', N'N/A', N'South', N'Exterior', N'',  
N'1s0?', N'SB areaway 1st', N'', N'', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber], [Building],  
[Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem], [Comments], [Issued],  
[FacilitySiteID]) VALUES (N'5b229566-5226-4e48-a6c7-008d435f81ae',  
N'A05-46', N'N/A', N'A-05', N'A05-46', N'',  
N'Air Conditioning Machine, Split System Chilled Water Coils',  
N'10 Tons and Under', 1, N'Trane', N'N/A', N'South',  
N'1', N'G', N'022', N'Headquarter Protective Force',  
N'', N'Above Ceilg', 0, N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription], [SecondaryAssetDescription],  
[Quantity], [Manufacturer], [ModelNumber], [Building], [Floor], [Corridor], [RoomNo],  
[MERNo], [EquipSystem], [Comments], [Issued], [FacilitySiteID])
VALUES (N'108d1792-7aa1-4865-a3d3-00a0ea973aa3', N'C06-252',  
N'N/A', N'C-06', N'C06-252', N'F27-35,C08-33',  
N'CONTROLS, CENTRAL SYSTEM, HVAC', N'N/A', 1, N'N/A',  
N'N/A', N'South', N'9', N'F', N'004',  
N'MER5 ', N'E-SE-1', N'exh damper', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem], [Comments],  
[Issued], [FacilitySiteID]) VALUES (N'80b9e4f9-71a4-4bd6-85c1-00a404cfee2b',  
N'D06-409', N'N/A', N'D-06', N'D06-409', N'',  
N'DRAIN, AREAWAY/DRIVEWAY/STORM', N'N/A', 1, N'N/A',  
N'N/A', N'North', N'Exterior', N'',  
N'eas0?', N'NB lawn east', N'', N'', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'bdad32e0-9c21-4451-8cc9-00b47b155eb9', N'D04-182',  
N'N/A', N'D-04', N'D04-182', N'N/A', N'DOOR,  
HYDR/ELEC/PNEUM OPERATED', N'N/A', 1, N'N/A', N'N/A',  
N'South', N'2', N'E', N'2E-115',  
N'Bathrooms', N'', N'HYDR/ELEC/PNEUM', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'4d859a1b-10e0-4cb0-96a4-00c164a7237e', N'C03-222',  
N'N/A', N'C-03', N'C03-222', N'', N'COILS,  
REHEAT/PREHEAT (REMOTE)', N'N/A', 1, N'N/A',  
N'N/A', N'West', N'G', N'GJ, GI', N'086,052',  
N'MER8 ', N'SW-26', N'', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem], [Comments],  
[Issued], [FacilitySiteID]) VALUES (N'3df536d8-9f25-40dd-a83f-00c4434ad58e',  
N'D06-348', N'N/A', N'D-06', N'D06-348',  
N'', N'DRAIN, AREAWAY/DRIVEWAY/STORM', N'N/A', 1,  
N'N/A', N'N/A', N'West', N'Exterior',  
N'', N'2n4?', N'WB areaway 2nd', N'',  
N'', 0, N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'26c671bc-47f1-4d0e-acc6-00cdfb94b67d', N'C06-165',  
N'N/A', N'C-06', N'C06-165', N'A11-17,C08-22',  
N'CONTROLS, CENTRAL SYSTEM, HVAC', N'N/A', 1, N'N/A',  
N'N/A', N'South', N'9', N'F', N'004',  
N'MER5 ', N'AC-SE-6', N'min OA', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'be09535a-0fb6-4f7b-a74e-00dab4730211', N'D04-034',  
N'N/A', N'D-04', N'D04-034', N'N/A',  
N'DOOR, HYDR/ELEC/PNEUM OPERATED', N'N/A', 1,  
N'Dor-O-Matic, Jr', N'N/A', N'North', N'G',  
N'A', N'064', N'', N'', N'Swing', 0,  
N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode], [SerialNumber],  
[PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'65a0abaa-75cf-489a-9367-0118486218b9', N'D05-049',  
N'N/A', N'D-05', N'D05-049', N'N/A',  
N'DOOR, ENTRANCE, MAIN', N'N/A', 1,  
N'N/A', N'N/A', N'South', N'G_
1st', N'E', N'283', N'Ped Mall east', N'',  
N'', 0, N'526fa0d5-1872-e611-b10e-005056c00008')
INSERT INTO [dbo].[Assets] ([AssetID], [Barcode],  
[SerialNumber], [PMGuide], [AstID], [ChildAsset], [GeneralAssetDescription],  
[SecondaryAssetDescription], [Quantity], [Manufacturer], [ModelNumber],  
[Building], [Floor], [Corridor], [RoomNo], [MERNo], [EquipSystem],  
[Comments], [Issued], [FacilitySiteID])
VALUES (N'c0101cf3-d1f1-4d32-a4b5-0135dc54645a',  
N'C03-046', N'N/A', N'C-03', N'C03-046',  
N'', N'COILS, REHEAT/PREHEAT (REMOTE)', N'N/A', 1,  
N'N/A', N'N/A', N'North', N'5',  
N'A', N'084', N'', N'RH-N-30',  
N'', 0, N'526fa0d5-1872-e611-b10e-005056c00008')
GO