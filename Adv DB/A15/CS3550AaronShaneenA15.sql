/*
	Aaron Shaneen
	CS 3550 T/TH
	Assignment #15
*/

/* #1 List the territory ID, territory Name and number of states/provinces in that territory */
SELECT t.TerritoryID, t.Name, COUNT(*) AS StatesPerTerritory
FROM Person.StateProvince s
JOIN Sales.SalesTerritory t
ON s.TerritoryID = t.TerritoryID
GROUP BY t.TerritoryID, t.Name

/* #2 SQL to Mongo script of territory ID's, territory names, state/province IDs, and state names */
SELECT 'db.territoryState.save({'
+ '"territoryID":"' + CONVERT(VARCHAR(MAX), t.TerritoryID) + '",'
+ '"territoryName":"' + t.Name + '",'
+ '"stateID":"' + CONVERT(VARCHAR(MAX), s.StateProvinceID) + '",'
+ '"stateName":"' + s.Name + '"});'
FROM Person.StateProvince s
JOIN Sales.SalesTerritory t
ON s.TerritoryID = t.TerritoryID