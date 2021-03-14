-- Aaron Shaneen
-- CS 3550 T/TH
-- Assignment #10

-- What is the maximum discount given to a product with a silver color?
SELECT MAX(sod.UnitPriceDiscount) AS MaxDiscount
FROM Sales.SalesOrderDetail sod
JOIN Sales.SpecialOfferProduct sop
ON sod.ProductID = sop.ProductID
JOIN Production.Product p
ON sop.ProductID = p.ProductID
WHERE p.Color = 'Silver'

GO

-- How many people with the same job title start a shift at the same time?
SELECT e.JobTitle, COUNT(e.BusinessEntityID) AS NumOfSameShift
FROM HumanResources.Employee e
JOIN HumanResources.EmployeeDepartmentHistory edh
ON e.BusinessEntityID = edh.BusinessEntityID
JOIN HumanResources.Shift s
ON edh.ShiftID = s.ShiftID
GROUP BY e.JobTitle, s.StartTime
HAVING COUNT(*) > 1

GO