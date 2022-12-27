USE master;
ALTER DATABASE [MindBoxTestDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE [MindBoxTestDB];

CREATE DATABASE MindBoxTestDB
GO

USE MindBoxTestDB
GO

CREATE TABLE Products 
(
  ProductId INT PRIMARY KEY IDENTITY,
  ProductName NVARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE Categories
(
  CategoryId INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) UNIQUE NOT NULL
)

CREATE TABLE ProductsCategories
(
  Product INT REFERENCES Products(ProductId),
  Category INT REFERENCES Categories(CategoryId),
  PRIMARY KEY(Product, Category)
)

GO

INSERT INTO Products (ProductName) VALUES 
  (N'������'),
  (N'����'),
  (N'���������� ��������� 6H'),
  (N'����� �� �������� ���������'),
  (N'Irbis NB270')
GO

INSERT INTO Categories (CategoryName) VALUES 
 (N'���'),
 (N'���������������'),
 (N'����������'),
 (N'��������'),
 (N'�����')
GO

INSERT INTO ProductsCategories(Product, Category) VALUES 
 (1, 1),
 (1, 2),
 (2, 1),
 (3, 3),
 (3, 4),
 (4, 3),
 (4, 5)
GO
