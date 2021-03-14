window.onload = startForm;

function todayTxt()
{
	var Today = new Date();
	return Today.getMonth() + 1 + "/" + Today.getDate() + "/" + Today.getFullYear();
}

function startForm()
{
	document.forms[0].date.value = todayTxt();
	document.forms[0].prod.focus();
	
	document.forms[0].prod.onchange = calcPrice;
	document.forms[0].qty.onchange = calcPrice;
	
	for(var i = 0; i < document.forms[0].shipType.length; i++)
	{
		document.forms[0].shipType[i].onclick = calcShipping;
	}
	
	document.forms[0].onreset = resetForm;
	document.forms[0].onsubmit = checkForm;
}

function checkForm()
{
	if(document.forms[0].prod.selectedIndex == 0)
	{
		window.alert("You must select a product");
		return false;
	}
	
	else if(document.forms[0].qty.selectedIndex == 0)
	{
		window.alert("You must select a quantity");
		return false;
	}
	
	else if(document.forms[0].ship.value == "0.00")
	{
		window.alert("You must select shipping");
		return false;
	}
}

function resetForm()
{
	location.reload();
}

function calcShipping()
{
	document.forms[0].ship.value = this.value;
	
	calcTotal();
}

function calcPrice()
{
	var product = document.forms[0].prod;
	var pIndex = product.selectedIndex;
	var productPrice = product.options[pIndex].value;
	
	var quantity = document.forms[0].qty;
	var qIndex = quantity.selectedIndex;
	var quantityOrdered = quantity.options[qIndex].value;
	
	document.forms[0].price.value = (productPrice * quantityOrdered).toFixed(2);
	
	calcTotal();
}

function calcTotal()
{
	var priceVal = parseFloat(document.forms[0].price.value);
	var shipVal = parseFloat(document.forms[0].ship.value);
	
	document.forms[0].sub.value = (priceVal + shipVal).toFixed(2);
	
	var taxVal = 0.05 * (priceVal + shipVal);
	document.forms[0].tax.value = taxVal.toFixed(2);
	
	document.forms[0].tot.value = (priceVal + shipVal + taxVal).toFixed(2);
}