let myCar = {
    make:"Ford",
    model:"fiesta",
    year:2012,
    color:"green",

};
console.log ("MyCar color:", myCar.color);

let prop = "color";
myCar[prop] = "red";
console.log("MyCar color: ",myCar.color);

prop = "forSale";
myCar[prop] = true;
console.log(`Car ${myCar.make} ${myCar.model} ${myCar.year}`);
console.log("For sale: ", myCar.forSale);