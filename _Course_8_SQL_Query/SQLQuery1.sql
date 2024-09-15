CREATE DATABASE ShoppingCartDb;

USE ShoppingCartDb;

CREATE Table Users(
	UserId INT,
	UserName VARCHAR(20),
	pwd NVARCHAR(20),
	ContactNumber BIGINT UNIQUE,
	City VARCHAR(20),
	CONSTRAINT PK_USERS_USERID PRIMARY KEY(UserId),
	CONSTRAINT CHK_USERS_CONTACTNUMBER CHECK(ContactNumber <= 9999999999 and ContactNumber > 999999999)
);


INSERT INTO Users VALUES(1,'pooja','pooja123',9876543210,'Hyderabad');
INSERT INTO Users VALUES(2,'Luna','Luna123',9876543211,'Mumbai');

--products table
CREATE TABLE Products(
	ProductId INT,
	Name VARCHAR(20) NOT NULL,
	QuantityInStock INT NOT NULL,
	UnitPrice INT NOT NULL,
	Category VARCHAR(20) NOT NULL,
	CONSTRAINT PK_PRODUCTS_PRODUCTID PRIMARY KEY(ProductId),
	CONSTRAINT CHK_PRODUCTS_UNITPRICE CHECK(UnitPrice > 0),
);

INSERT INTO Products VALUES(1,'Earrings',5,200,'Fashion');
INSERT INTO Products VALUES(2,'Shoes',10,1000,'Sports');
INSERT INTO Products VALUES(3,'TV',15,25000,'Electronics');
INSERT INTO Products VALUES(4,'Earphones',7,2000,'Electronics');
INSERT INTO Products VALUES(5,'Teddy Bear',9,500,'Plush Toys');
INSERT INTO Products VALUES(6,'Brown Bear',7,300,'Plush Toys');
INSERT INTO Products VALUES(7,'Tshirts',7,300,'Fashion');
INSERT INTO Products VALUES(8,'Jeans',0,800,'Fashion');



--cart table
CREATE TABLE Cart(
	Id INT IDENTITY(1,1),
	CartId INT NOT NULL,
	ProductId INT NOT NULL,
	Quantity INT NOT NULL,
	CONSTRAINT PK_CART_ID PRIMARY KEY(Id),
	CONSTRAINT FK_CART_PRODUCTID FOREIGN KEY(ProductId)
	REFERENCES Products(ProductId)
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	CONSTRAINT CHK_CART_QUANTITY CHECK(Quantity > 0)

);


INSERT INTO Cart VALUES(1,4,4);
INSERT INTO Cart VALUES(1,6,2);

INSERT INTO Cart VALUES(2,1,5);
INSERT INTO Cart VALUES(2,3,10);
INSERT INTO Cart VALUES(3,2,7);
INSERT INTO Cart VALUES(3,6,1);

--2) i) a)
SELECT * FROM Products;

--b) 
SELECT * FROM Products WHERE Category = 'Electronics';

--c) 
SELECT * FROM Products WHERE QuantityInStock = 0;

--d) 
SELECT * FROM Products WHERE UnitPrice >= 1000 and UnitPrice <= 10000;

--e) 
SELECT * FROM Products WHERE ProductId = 5;

--2) ii) a)
SELECT * FROM Cart WHERE CartId = 2;

--b) 
SELECT c.CartId, c.ProductId,c.Quantity FROM Cart c, Products p WHERE p.ProductId = c.ProductId and p.ProductId  = 6;

--iii) a)
SELECT * FROM Users;

--b) 
SELECT * FROM Users WHERE ContactNumber = 9876543210;

--c) 
SELECT * FROM Users WHERE UserId = 2;


