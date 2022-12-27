USE [MindBoxTestDB]
GO

SELECT P.ProductName, C.CategoryName
FROM [Products] AS P
LEFT JOIN [ProductsCategories] AS PC ON P.ProductId = PC.Product
LEFT JOIN [Categories] AS C ON PC.Category = C.CategoryId
GROUP BY P.ProductName, C.CategoryName
GO

