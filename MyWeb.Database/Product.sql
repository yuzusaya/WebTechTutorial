CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(MAX) NULL, 
    [ProductCategoryId] INT NULL, 
    CONSTRAINT [FK_Product_ToProductCategory] FOREIGN KEY ([ProductCategoryId]) REFERENCES [ProductCategory]([Id])
)
