
--1) a)

CREATE VIEW ProductLessThanAveragePriceView
AS 
SELECT * FROM Products WHERE UnitPrice < (SELECT AVG(UnitPrice) FROM Products);


--b)
SELECT * FROM ProductLessThanAveragePriceView;


--c) 
EXEC sp_rename 'ProductLessThanAveragePriceView', 'LowCostProductsView';

--d)
Drop View LowCostProductsView;





--2) a)
CREATE PROCEDURE uspReadData 
AS 
BEGIN
	DECLARE cursor_product CURSOR
	FOR SELECT ProductName, UnitPrice, UnitsInStock FROM Products;

	DECLARE @Name VARCHAR(MAX), @UnitPrice DECIMAL, @UnitsInStock DECIMAL;

	OPEN cursor_product;

	FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsInStock;

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @Name + ' - ' + CAST(@UnitPrice AS VARCHAR)+ ' - ' + CAST(@UnitsInStock AS VARCHAR);
			FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsInStock;
		END;
	CLOSE cursor_product;

	DEALLOCATE cursor_product;

END

EXEC uspReadData;

--2)b)

DECLARE cursor_product CURSOR
	FOR SELECT ProductName, UnitPrice, UnitsOnOrder FROM Products;

	DECLARE @Name VARCHAR(MAX), @UnitPrice DECIMAL, @UnitsOnOrder DECIMAL;

	OPEN cursor_product;

	FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @Name + ' : ' + CAST(@UnitPrice*@UnitsOnOrder AS VARCHAR);
			FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;
		END;
	CLOSE cursor_product;

	DEALLOCATE cursor_product;

--2) c) 
CREATE PROCEDURE uspsTotalAmount 
AS 
BEGIN
	DECLARE cursor_product CURSOR
	FOR SELECT ProductName, UnitPrice, UnitsOnOrder FROM Products;

	DECLARE @Name VARCHAR(MAX), @UnitPrice DECIMAL, @UnitsOnOrder DECIMAL;

	OPEN cursor_product;

	FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @Name + ' : ' + 'Total Price - ' + CAST(@UnitPrice*@UnitsOnOrder AS VARCHAR);
			FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;
		END;
	CLOSE cursor_product;

	DEALLOCATE cursor_product;

END

EXEC uspsTotalAmount;

--2) d)

CREATE PROCEDURE uspsGrandSPriceTotal
AS 
BEGIN
	DECLARE cursor_product CURSOR
	FOR SELECT ProductName, UnitPrice, UnitsOnOrder FROM Products;

	DECLARE @Name VARCHAR(MAX), @UnitPrice BIGINT, @UnitsOnOrder BIGINT, @GrandTotal BIGINT = 0;

	OPEN cursor_product;

	FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;

	WHILE @@FETCH_STATUS = 0
		BEGIN
			SET @GrandTotal = @GrandTotal + @UnitPrice*@UnitsOnOrder;
			PRINT @Name + ' : ' + 'Total Price - ' + CAST(@UnitPrice*@UnitsOnOrder AS VARCHAR);
			FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;
		END;
		PRINT 'Grand Total : ' + CAST(@GrandTotal AS VARCHAR) ;
	CLOSE cursor_product;

	DEALLOCATE cursor_product;

END

EXEC uspsGrandSPriceTotal;


--2) e)
CREATE PROCEDURE uspSsTotalDEcimalAmount 
AS 
BEGIN
	DECLARE cursor_product CURSOR
	FOR SELECT ProductName, UnitPrice, UnitsOnOrder FROM Products;

	DECLARE @Name VARCHAR(MAX), @UnitPrice DECIMAL, @UnitsOnOrder DECIMAL;

	OPEN cursor_product;

	FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT @Name + ' : ' + 'Total Price - ' + CAST(CAST(@UnitsOnOrder*@UnitsOnOrder AS DECIMAL(10,2)) AS VARCHAR);
			FETCH NEXT FROM cursor_product INTO @Name, @UnitPrice, @UnitsOnOrder;
		END;
	CLOSE cursor_product;

	DEALLOCATE cursor_product;

END

EXEC uspSsTotalDEcimalAmount;

