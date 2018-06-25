INSERT INTO [dbo].[tbl_computer]
           ([name]
           ,[price]
           ,[last_modified]
           ,[quantity]
           ,[type]
           ,[ram]
           ,[hdd]
           ,[graphics]
           ,[color]
           ,[tower]
           ,[brand_ID])
     VALUES
           ('Inspiron 17 5000 laptop', 1799.99, '2018-05-22 4:47:09', '3', 'L', '16gb', '1TB', 'AMD Radeon 530', 'Pink', 'null', (SELECT brand_ID from tbl_brand WHERE brand_ID='1')),
		   ('HP EliteBook 830 G5 Notebook', 1249.00, '2018-05-22 4:35:09', '2', 'L', '8gb', '256GB', 'Intel HD Graphics 620', 'Silver', 'null', (SELECT brand_ID from tbl_brand WHERE brand_ID='2') ),
		   ('Razer Blade Pro', 3799.99, '2018-05-22 3:52:09', '10', 'L', '16gb', '1TB', 'GTX 1080', 'Black', 'null', (SELECT brand_ID from tbl_brand WHERE brand_ID='3'));