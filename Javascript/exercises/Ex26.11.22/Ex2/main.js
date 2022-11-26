
// let nb1 = 15;
// let nb2 = 5.5;

// console.log (typeof(nb1));
// console.log (typeof(nb2));
// console.log (typeof(NaN));
// console.log (typeof("hallo"));

// let potato = "potato"
// console.log(typeof(potato))
// console.log (typeof(true));

// console.log (typeof(1 !=2));

// let hamburger = "hamburger";
// let s = "s";

// console.log (hamburger + s)
// console.log (typeof(hamburger + s))
// console.log (hamburger - s)
// console.log (typeof(hamburger - s))

// let test = "1"+"3";
// console.log(test);
// console.log(typeof(test));

// let test2 = "1"-"3";
// console.log(test2);
// console.log(typeof(test2));

// let test3 = "johnny" + 5;
// console.log(test3);
// console.log(typeof(test3));

// let test4 = "johnny" - 5;
// console.log(test4);
// console.log(typeof(test4));

// let test5 = 99 * "luftbaloons";
// console.log(test5);
// console.log(typeof(test5));

let NameOfTheSpaceShuttle = "Determination";
let ShuttleSpeed = 17500;
let DistenceToMars = 225000000;
let DistenceToMoon = 384400;
let MilesPerKilometer = 0.621;

// console.log(NameOfTheSpaceShuttle)
// console.log(typeof(NameOfTheSpaceShuttle))
// console.log(ShuttleSpeed)
// console.log(typeof(ShuttleSpeed))
// console.log(DistenceToMars)
// console.log(typeof(DistenceToMars))
// console.log(DistenceToMoon)
// console.log(typeof(DistenceToMoon))
// console.log(MilesPerKilometer)
// console.log(typeof(MilesPerKilometer))


let MilesToMars = DistenceToMars * MilesPerKilometer;
console.log (MilesToMars);
let HToMars = MilesToMars / ShuttleSpeed;
console.log(HToMars);
let DaysToMars = HToMars / 24;
console.log(DaysToMars);



console.log (`${NameOfTheSpaceShuttle} will take ${DaysToMars} days to get to Mars.`)



