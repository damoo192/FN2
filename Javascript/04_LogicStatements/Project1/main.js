let randomNumber = 0;
randomNumber = Math.random();
randomNumber = randomNumber * 11;
randomNumber = Math.floor(randomNumber);
console.log(randomNumber);

let userInput = prompt("Enter a number between 0 and 10");
let userNumber = Number(userInput);
console.log("User input " + userNumber + " type of " + typeof userNumber);
let userNumber2 = parseInt(userInput);
console.log("User input " + userNumber2 + " type of " + typeof userNumber2);

if(userNumber > randomNumber){
    console.log("Your number is greater then the random number");
} else if(userNumber < randomNumber){
    console.log("Youe number is smaller then the random number");
} else{
    console.log("You guessed the number!!!");
}

