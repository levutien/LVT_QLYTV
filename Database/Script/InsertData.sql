USE [MemberCard]
GO

-- Insert tblServicePlace

SET IDENTITY_INSERT dbo.tblServicePlace ON;

INSERT [dbo].[tblServicePlace] ([Place_ID], [PlaceName], [Address], [Tel] ) VALUES (1, N'Trung tâm Mắt Kỹ thuật cao 30-4', N'9 Sư Vạn Hạnh, P.9, Q.5, TP.HCM', '08 3833 3369')
INSERT [dbo].[tblServicePlace] ([Place_ID], [PlaceName], [Address], [Tel] ) VALUES (2, N'Trung tâm Mắt Hải Yến', N'31A Nguyễn Đình Chiểu, P.ĐaKao, Q.1, TP.HCM', '0913 666 665')
INSERT [dbo].[tblServicePlace] ([Place_ID], [PlaceName], [Address], [Tel] ) VALUES (3, N'Trung tâm Mắt Kỹ thuật cao An Sinh', N'10 Trần Huy Liệu, Q.Phú Nhuận, TP.HCM', '08 38448523')

Select * from tblServicePlace