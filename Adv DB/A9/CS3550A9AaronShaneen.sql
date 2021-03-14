-- Aaron Shaneen
-- CS 3550 T/TH
-- Assignment #9

USE AdventureWorks

GO

-- Question #1: Find the average pay rate for
-- all females working in the sales department

SELECT emp.JobTitle, AVG(eph.Rate) AS AverageRate
FROM HumanResources.Employee emp
INNER JOIN HumanResources.EmployeePayHistory eph
ON emp.BusinessEntityID = eph.BusinessEntityID
INNER JOIN HumanResources.EmployeeDepartmentHistory edh
ON emp.BusinessEntityID = edh.BusinessEntityID
INNER JOIN HumanResources.Department dep
ON edh.DepartmentID = dep.DepartmentID
WHERE emp.Gender = 'F' AND dep.Name = 'Sales'
GROUP BY eph.Rate, emp.JobTitle;

-- Question #2: Print the first name, last name, and total
-- for all customers that spent over $2000 in one order

SELECT DISTINCT per.FirstName, per.LastName, sod.LineTotal
FROM Person.Person per
INNER JOIN Sales.SalesOrderHeader soh
ON per.BusinessEntityID = soh.CustomerID
INNER JOIN Sales.SalesOrderDetail sod
ON soh.SalesOrderID = sod.SalesOrderID
WHERE sod.LineTotal > 2000.00;