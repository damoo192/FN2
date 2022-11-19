//console.log("Damjan");
/*
Multi
Line
Comment
*/
//prompt("Insert your name!");

/*
let userName = prompt ("Insert your name!");
alert("Vaseto ime " + userName + " e procesirano!")
console.log(userName);
*/


let randomNum = Math.random() * 3;
console.log("My random number " + randomNum);
let roundNum = Math. floor(randomNum) + 1;
console.log("My random number " + roundNum);

let num = prompt("Guess a number 1 to 3");

if (roundNum == num) {
    alert("you guessed right!");
} 
else {
    alert("you guessed wrong!");
}