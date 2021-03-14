window.onload = startForm;

function startForm()
{
	document.forms[0].onsubmit = checkForm2;
	
}

function checkForm2()
{
	if(document.forms[0].fname.value.length == 0)
	{
		window.alert("You must enter a first name");
		return false;
	}
	
	else if(document.forms[0].lname.value.length == 0)
	{
		window.alert("You must enter a last name");
		return false;
	}
	
	else if(document.forms[0].street.value.length == 0)
	{
		window.alert("You must enter a street address");
		return false;
	}
	
	else if(document.forms[0].city.value.length == 0)
	{
		window.alert("You must enter a city");
		return false;
	}
	
	else if(checkZip(document.forms[0].zip.value) == false)
	{
		window.alert("Invalid zip code");
		return false;
	}
	
	else
	{
		return true;
	}
}

function checkZip(zip)
{
	if(zip.length != 0 && zip.length != 5)
	{
		return false;
	}
	
	else
	{
		return true;
	}
}
