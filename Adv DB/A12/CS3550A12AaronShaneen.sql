-- Aaron Shaneen
-- CS 3550 T/TH
-- Assignment #12

USE AdventureWorks
GO

/* #1 Display the name of the day, the average online order sales subtotal, and
average in-store order sales subtotal for each day of the week (Sunday - Saturday).
You should have days of the week as headers across the top and online vs In store
down the side (Static Pivot Query Only) */

SELECT OrderType, [Sunday], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday]
FROM
(SELECT AVG(h.SubTotal) AS AvgSubTotal, DATENAME(WEEKDAY, h.OrderDate) AS DayOrdered,
CASE WHEN h.OnlineOrderFlag = 0
THEN 'InStore'
ELSE 'Online'
END AS OrderType
FROM Sales.SalesOrderHeader h
GROUP BY DATENAME(dw, h.OrderDate), h.OnlineOrderFlag) x
PIVOT (SUM(AvgSubTotal) FOR DayOrdered IN ([Sunday], [Monday], [Tuesday], [Wednesday], [Thursday], [Friday], [Saturday])) AS PivotTable

/* #2 List each product category and the number of units sold by month. You
should have months as headers across the top and product categories down the
side (Complete both Static and Dynamic Pivot Query) */

/* Static Version */
SELECT CategoryName, [January], [February], [March], [April], [May], [June], [July], [August], [September], [October], [November], [December]
FROM
(SELECT c.Name AS CategoryName, SUM(d.OrderQty) AS Quantity, DATENAME(MONTH, h.OrderDate) AS MonthOrdered
FROM Production.ProductCategory c
JOIN Production.ProductSubcategory s
ON c.ProductCategoryID = s.ProductCategoryID
JOIN Production.Product p
ON s.ProductSubcategoryID = p.ProductSubcategoryID
JOIN Sales.SalesOrderDetail d
ON p.ProductID = d.ProductID
JOIN Sales.SalesOrderHeader h
ON d.SalesOrderID = h.SalesOrderID
GROUP BY c.Name, DATENAME(MONTH, h.OrderDate)) x
PIVOT (SUM(quantity)
FOR MonthOrdered
IN ([January], [February], [March], [April], [May], [June], [July], [August], [September], [October], [November], [December])) AS PivotTable

/* Dynamic Version */
DECLARE @columns NVARCHAR(MAX), @sql NVARCHAR(MAX);
SET @columns = N'';
SELECT @columns += N',' + QUOTENAME(MonthOrdered)
FROM
(SELECT DISTINCT DATENAME(month, h.OrderDate) AS MonthOrdered, DATEPART(mm, h.OrderDate) AS MonthNum
FROM Sales.SalesOrderHeader h) x
ORDER BY MonthNum;
SET @columns = STUFF(@columns, 1, 1, '');
SELECT @sql = N'SELECT CategoryName, ' + @columns + N'
FROM
(SELECT c.Name AS CategoryName, SUM(d.OrderQty) AS Quantity, DATENAME(MONTH, h.OrderDate) AS MonthOrdered
FROM Production.ProductCategory c
JOIN Production.ProductSubcategory s
ON c.ProductCategoryID = s.ProductCategoryID
JOIN Production.Product p
ON s.ProductSubcategoryID = p.ProductSubcategoryID
JOIN Sales.SalesOrderDetail d
ON p.ProductID = d.ProductID
JOIN Sales.SalesOrderHeader h
ON d.SalesOrderID = h.SalesOrderID
GROUP BY c.Name, DATENAME(MONTH, h.OrderDate)) y
PIVOT (SUM(quantity)
FOR MonthOrdered IN (' + @columns + N')) AS PivotTable';

EXECUTE sp_executesql @sql;