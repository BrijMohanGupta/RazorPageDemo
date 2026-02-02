USE RazorPagesDemo;
GO

CREATE TABLE Products (
Id INT IDENTITY(1,1) PRIMARY KEY,
Name NVARCHAR(100) NOT NULL,
Quantity INT NOT NULL,
Price DECIMAL(18,2) NOT NULL,
Description NVARCHAR(500)
);

INSERT INTO Products (Name, Quantity, Price, Description)
VALUES
('Laptop', 5, 65000, 'Business Laptop'),
('Keyboard', 20, 1500, 'Mechanical Keyboard'),
('Mouse', 50, 500, 'Wireless Mouse');

