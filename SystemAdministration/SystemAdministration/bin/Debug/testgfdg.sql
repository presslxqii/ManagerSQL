GO
UPDATE [config].[Классы объектов] SET [Название класса] = 'Teees32' WHERE ID = '726d9f8d-7d7b-4961-86ac-0b032c771a41'
GO
UPDATE [config].[Классы объектов] SET [Название класса] = 'Справочник типов производственных фондов' WHERE ID = 'e8bf6765-73a1-4040-990b-fec9eec4b80e'
GO
UPDATE [config].[Классы объектов] SET [Схема] = 'ref' WHERE ID = 'e8bf6765-73a1-4040-990b-fec9eec4b80e'
GO
UPDATE [config].[Классы объектов] SET [Таблица] = 'Справочник типов производственных фондов' WHERE ID = 'e8bf6765-73a1-4040-990b-fec9eec4b80e'
GO
INSERT INTO [config].[Классы объектов] ([ID],[Производственные фонды],[Метакласс],[Название класса],[Название класса в родительном падеже],[Название класса во множественном числе],[Название класса во множественном числе родительном падеже],[Схема],[Таблица],[Значок],[Редактируемый],[ID_Норматива по умолчанию],[Название View],[Нестандартные триггеры],[Правило именования],[Специальная схема отображения],[Дополнительные метаданные],[ID_Шаблона_отчета],[Метка времени]) 
VALUES (CONVERT(uniqueidentifier,'dd593d4f-e0c3-4659-b70e-0a78c8f793a2'), 'False', 'Справочник', 'Справочник типов производственных фондов', 
'test1', '', '','ref', 'Справочник типов производственных фондов', 'Qk32AgAAAAAAADYAAAAoAAAADgAAABAAAAABABgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACEgoTGw8bGw8bGw8bGw8bGw8bGw8bGw8bGw8bGw8bGw8bGw8bGw8YAAAAAAISChP///////////////////////////////////////////8bDxgAAAAAAhIKE////////////////////////////////////////////xsPGAAAAAACEgoT////////////////////////////////////////////Gw8YAAAAAAISChP///////////////////////////////////////////8bDxgAAAAAAhIKE////////////AAD/AAD/////////AAD/AAD/////////xsPGAAAAAACEgoT///////////////8AAP8AAP8AAP8AAP/////////////Gw8YAAAAAAISChP///////////////////wAA/wAA/////////////////8bDxgAAAAAAhIKE////////////////AAD/AAD/AAD/AAD/////////////xsPGAAAAAACEgoT///////////8AAP8AAP////////8AAP8AAP/////////Gw8YAAAAAAISChP///////////////////////////////////////////8bDxgAAAAAAhIKE////////////////////////////////////////////xsPGAAAAAACEgoT////////////////////////////////////////////Gw8YAAAAAAISChP///////////////////////////////////////////8bDxgAAAAAAhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEhIKEAAA=', 'False', NULL, '', 'False', '','',  '', NULL, '')

