Create Database  Sept2024Db


---------------------------------

CREATE TABLE product(
	productId INT PRIMARY KEY,
	pname VARCHAR(20),
	price INT,
	quantity INT,
	category VARCHAR(20)
)



------
INSERT INTO product VALUES(2001,'Laptops',100000,10,'Electronics')
INSERT INTO product VALUES(2002,'Books',40,20,'Stationery')
INSERT INTO product VALUES(2003,'Pen',5,20,'Stationery')
INSERT INTO product VALUES(2004,'Ipad',100000,20,'Electronics')
INSERT INTO product VALUES(2005,'Gold Chain',50000,1,'Accessory')
INSERT INTO product VALUES(2006,'Earrings',600,3,'Accessory')


SELECT * FROM product
----


