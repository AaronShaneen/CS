-- Aaron Shaneen
-- CS 3550 T/TH
-- Assignment #11

USE AdventureWorks
GO

/* #1 List the first name, last name, gender, age, and job title of the oldest employee */
SELECT p.FirstName, p.LastName, e.Gender, (DATEDIFF(dd, e.BirthDate, GETDATE())/365) AS Age, e.JobTitle
FROM HumanResources.Employee e
JOIN Person.Person p
ON e.BusinessEntityID = p.BusinessEntityID
WHERE e.BirthDate = (SELECT MIN(BirthDate) FROM HumanResources.Employee)

/* #5 Display the vendor ID, credit rating and address for vendors that have a credit rating higher than 3 */
SELECT DISTINCT v.BusinessEntityID, v.CreditRating, d.AddressLine1, d.City, s.Name
FROM Purchasing.Vendor v
JOIN Person.BusinessEntity b
ON v.BusinessEntityID = b.BusinessEntityID
JOIN Person.BusinessEntityAddress a
ON b.BusinessEntityID = a.BusinessEntityID
JOIN Person.Address d
ON a.AddressID = d.AddressID
JOIN Person.StateProvince s
ON d.StateProvinceID = s.StateProvinceID
WHERE v.CreditRating > 3

/* #6 Display the territory (ID, Name, CountryRegionCode, Group and Count) of the territory that has the most customers */
SELECT t.TerritoryID, t.Name, t.CountryRegionCode, [Group], COUNT(c.CustomerID) AS NumOfCustomers
FROM Sales.Customer c
JOIN Sales.SalesTerritory t
ON c.TerritoryID = t.TerritoryID
GROUP BY t.TerritoryID, t.Name, t.CountryRegionCode, [Group]
HAVING COUNT(c.CustomerID) = 
(SELECT MAX(x.NumOfCustomers)
FROM
(SELECT t.TerritoryID, t.Name, t.CountryRegionCode, [Group], COUNT(c.CustomerID) AS NumOfCustomers
FROM Sales.Customer c
JOIN Sales.SalesTerritory t
ON c.TerritoryID = t.TerritoryID
GROUP BY t.TerritoryID, t.Name, t.CountryRegionCode, [Group]) x )