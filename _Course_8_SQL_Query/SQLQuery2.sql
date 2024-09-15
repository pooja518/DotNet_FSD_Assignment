--1) b) 
SELECT c.CartId, p.Name, c.Quantity, p.UnitPrice FROM Products p, Cart c WHERE p.ProductId = c.ProductId;

--c)

--inner join
SELECT c.CartId, p.ProductId, p.Name, c.Quantity, p.UnitPrice FROM Products p INNER JOIN Cart c ON p.ProductId = c.ProductId;

--right outer join
SELECT c.CartId, p.ProductId, p.Name, c.Quantity, p.UnitPrice FROM Products p RIGHT OUTER JOIN Cart c ON p.ProductId = c.ProductId;

--left outer join
SELECT c.CartId, p.ProductId, p.Name, c.Quantity, p.UnitPrice FROM Products p LEFT OUTER JOIN Cart c ON p.ProductId = c.ProductId;

--full outer join
SELECT c.CartId, p.ProductId, p.Name, c.Quantity, p.UnitPrice FROM Products p FULL OUTER JOIN Cart c ON p.ProductId = c.ProductId;


--students table

CREATE TABLE Student(
	StudentId INT,
	Name VARCHAR(20),
	Course VARCHAR(20),
	City VARCHAR(20),
	ContactNumber BIGINT UNIQUE,
	CONSTRAINT PK_STUDENT_STUDENTID PRIMARY KEY(StudentId),
	CONSTRAINT CHK_STUDENT_CONTACTNUMBER CHECK(ContactNumber <= 9999999999 and ContactNumber > 999999999)
);

INSERT INTO Student VALUES(1,'pooja','.NET','Hyderabad',9876543210);
INSERT INTO Student VALUES(2,'Luna','.NET','Mumbai',9876543211);
INSERT INTO Student VALUES(3,'Sriharsh','React','Hyderabad',9876543212);
INSERT INTO Student VALUES(4,'Hersheys','Angular','Mumbai',9876543213);
INSERT INTO Student VALUES(5,'Kuki','React','Hyderabad',9876543214);
INSERT INTO Student VALUES(6,'Chik','Angular','Pune',9876543215);
INSERT INTO Student VALUES(7,'Anya','Angular','Mumbai',9876543216);
INSERT INTO Student VALUES(8,'Luffy','Angular','Hyderabad',9876543217);
INSERT INTO Student VALUES(9,'Naruto','.NET','Mumbai',9876543218);
INSERT INTO Student VALUES(10,'Light','React','Pune',9876543219);



--2) a) 
SELECT COUNT(*) AS No_of_Angular_Students FROM Student WHERE Course = 'Angular';

--b)
SELECT COUNT(*) AS No_of_Hyderabad_Students FROM Student WHERE City = 'Hyderabad';

--c) 
SELECT City, COUNT(*) AS No_of_Students FROM Student GROUP BY City;

--d) 
SELECT City, COUNT(*) AS No_of_Students FROM Student GROUP BY City;

--e)
SELECT City, Course, COUNT(*) AS No_of_Students FROM Student GROUP BY City, Course;

--3) a)
SELECT c.CartId, p.ProductId, p.Name,p.UnitPrice, p.Category FROM Products p RIGHT OUTER JOIN Cart c ON c.ProductId = p.ProductId;

--b)
SELECT c.CartId, p.ProductId, p.Name , p.UnitPrice, c.Quantity FROM Products p INNER JOIN Cart c ON p.ProductId = c.ProductId WHERE p.UnitPrice > 5000;