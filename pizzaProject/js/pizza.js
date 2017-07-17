function myFunction(){
	recipt = document.getElementById("recipt");
	recipt.style.visibility = "visible";

	var size = '';
	var crust = '';
	var sauce = '';
	var cheese = '';

	var absoluteTotal = 0;

	//size stuff

	sizeinfo = document.getElementsByName("size");

	for (var i = 0; i < sizeinfo.length;i++) {
	if (sizeinfo[i].checked) {
		console.log(sizeinfo[i].value)
		size = sizeinfo[i].value
		}
	}
	
	if (size == 'personal') {
		document.getElementById("size").innerHTML = "Personal Pizza";
		document.getElementById("sizecost").innerHTML = "$6.00"
		absoluteTotal += 6



	}

	if (size == 'medium') {
		document.getElementById("size").innerHTML = "Medium Pizza";
		document.getElementById("sizecost").innerHTML = "$10.00"
		absoluteTotal+=10



	}

	if (size == 'large') {
		document.getElementById("size").innerHTML = "Large Pizza";
		document.getElementById("sizecost").innerHTML = "$14.00"
		absoluteTotal+=14


	}

	if (size == 'xl') {
		document.getElementById("size").innerHTML = "Extra-Large Pizza";
		document.getElementById("sizecost").innerHTML = "$16.00"
		absoluteTotal+=16


	}
	//End Size Stuff

	//Crust stuff

	crustinfo = document.getElementsByName("crust");

	for (var i = 0; i < crustinfo.length;i++) {
	if (crustinfo[i].checked) {
		console.log(crustinfo[i].value)
		crust = crustinfo[i].value
		}
	}
	
	if (crust == 'plain') {
		document.getElementById("crust").innerHTML = "Plain Crust";
		document.getElementById("crustcost").innerHTML = "+$0.00"



	}

	if (crust == 'garlic') {
		document.getElementById("crust").innerHTML = "Garlic Crust";
		document.getElementById("crustcost").innerHTML = "+$0.00"



	}

	if (crust == 'cheeseStuffed') {
		document.getElementById("crust").innerHTML = "Cheese-Stuffed Crust";
		document.getElementById("crustcost").innerHTML = "+$3.00"
		absoluteTotal+=3


	}

	if (crust == 'spicy') {
		document.getElementById("crust").innerHTML = "Spicy Crust";
		document.getElementById("crustcost").innerHTML = "+$0.00"



	}

	if (crust == 'house') {
		document.getElementById("crust").innerHTML = "House Special Crust";
		document.getElementById("crustcost").innerHTML = "+$0.00"



	}

	//End Crust Stuff

	//Meat stuff

	meatInfo = document.getElementsByName("meat");

	var outputString = "";

	var meatCount = 0;

	var meatCost = 0

	for (var i = 0; i < meatInfo.length; i++) {
		if (meatInfo[i].checked) {
			outputString += meatInfo[i].value + ", ";
			meatCount += 1;

			if (meatCount > 1) {
				meatCost += 1;
			}

		}
	}
	console.log(outputString);
	console.log(meatCost);
	absoluteTotal+=meatCost;

	if (outputString != "")	{
		document.getElementById("meats").innerHTML = outputString;
	}
	else {
		document.getElementById("meats").innerHTML = "No Meat";
	}
	document.getElementById("meatsCost").innerHTML = "+$" + meatCost.toString() + ".00";

	//End Meat Stuff

	//Veggie Stuff

	veggieInfo = document.getElementsByName("veg");

	outputString = "";

	var veggieCount = 0;

	var veggieCost = 0

	for (var i = 0; i < veggieInfo.length; i++) {
		if (veggieInfo[i].checked) {
			outputString += veggieInfo[i].value + ", ";
			veggieCount += 1;

			if (veggieCount > 1) {
				veggieCost += 1;
			}

		}
	}
	console.log(outputString);
	console.log(veggieCost);
	absoluteTotal+=veggieCost;
	if (outputString != "") {
		document.getElementById("veggies").innerHTML = outputString;
	}
	else {
		document.getElementById("veggies").innerHTML = "No Veggies"
	}
	document.getElementById("veggieCost").innerHTML = "+$" + veggieCost.toString() + ".00";


	//End Veggie Stuff

	//Sauce Stuff

	sauceType = document.getElementsByName("sauce");

	for (var i = 0; i < sauceType.length; i++) {
		if (sauceType[i].checked) {
			document.getElementById("sauce").innerHTML = sauceType[i].value;
		}
	}

	//End Sauce Stuff

	//Cheese Stuff

	cheeseType = document.getElementsByName("cheese");

	for (var i = 0;i < cheeseType.length;i++) {
		if (cheeseType[i].checked) {
			if (cheeseType[i].value == "xtraCheese") {
				document.getElementById("cheese").innerHTML = "Extra Cheese";
				document.getElementById("cheeseCost").innerHTML = "+$3.00";
				absoluteTotal+=3;
			}

			else if (cheeseType[i].value == "cheese") {
				document.getElementById("cheese").innerHTML = "Cheese";
				document.getElementById("cheeseCost").innerHTML = "+$0.00";
			}
			else {
				document.getElementById("cheese").innerHTML = "No Cheese";
				document.getElementById("cheeseCost").innerHTML = "+$0.00";
			}
		}
	}

	//End Cheese Stuff

	//Total Stuff

	document.getElementById("orderTotal").innerHTML = "$" + absoluteTotal.toString() +".00";

}

function goaway() {
	recipt = document.getElementById("recipt");
	recipt.style.visibility = "hidden";
}


