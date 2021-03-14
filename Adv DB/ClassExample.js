// MAP FUNCTION
var mapFunction = function() {emit(this.lastName,1);};
db.employeePay.mapReduce(
mapFunction,
function(key,values) {return Array.sum(values);},
	{
		out:"payHistoryCount"
	}
);

/* --------------ASSIGNMENT 15 EXAMPLE------------------ */
// AGGREGATE FUNCTION
db.employeeCount.aggregate([{$group:{_id:{stateName:"$stateName",personType:"$personType"},count:{$sum:1}}}]);

// MAP REDUCE FUNCTION
db.employeeCount.mapReduce(
	function(){emit({"stateName":this.stateName,"personType":this.personType},1);},
	function(key,values){return Array.sum(values);},
		{query:{},out:{inline:1}}).find();

// BUILD FOR ABOVE AGGREGATE/REDUCE FUNCTIONS
SELECT 'db.employeeCount.save({'
+ '"stateName":"' + s.Name + '",'
+ '"personType":"' + p.PersonType + '",'
+ '"businessEntityID":"' + CONVERT(VARCHAR(MAX), p.BusinessEntityID) + '"});'
FROM HumanResources.Employee e
JOIN Person.Person p
ON e.BusinessEntityID = p.BusinessEntityID
JOIN Person.BusinessEntity b
ON p.BusinessEntityID = b.BusinessEntityID
JOIN Person.BusinessEntityAddress a
ON b.BusinessEntityID = a.BusinessEntityID
JOIN Person.Address d
ON a.AddressID = d.AddressID
JOIN Person.StateProvince s
ON d.StateProvinceID = s.StateProvinceID