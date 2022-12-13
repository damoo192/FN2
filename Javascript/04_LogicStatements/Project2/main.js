let choices = ["Rock","Peper","Scissors"];

let computerChoise = Math.floor(Math.random() * 3);
let playerChoise = Math.floor(Math.random() * 3);

let showChoise = choices[computerChoise];
console.log("computer choise: " + showChoise);

showChoise = choices[playerChoise];
console.log("player choise: " + showChoise);

if (choices[computerChoise] === choices[playerChoise]) {
    console.log("Its a tie!!!");
} else if (choices[computerChoise] === "Rock" && choices[playerChoise] === "Peper") {
    console.log("Palyer wins!!!");
} else if (choices[computerChoise] === "Peper" && choices[playerChoise] === "Scissors") {
    console.log("Palyer wins!!!");
} else if (choices[computerChoise] === "Scissors" && choices[playerChoise] === "Rock") {
    console.log("Palyer wins!!!");
} else if (choices[playerChoise] === "Rock" && choices[computerChoise] === "Peper") {
    console.log("Computer wins!!!");
} else if (choices[playerChoise] === "Peper" && choices[computerChoise] === "Scissors") {
    console.log("Computer wins!!!");
} else if (choices[playerChoise] === "Scissors" && choices[computerChoise] === "Rock") {
    console.log("Computer wins!!!");
}

let message = "";
switch (choices[computerChoise]) {
   case "Rock":
      if (choices[playerChoise] === "Rock") {
         message = "It's a tie!!!";
      } else if (choices[playerChoise] === "Paper") {
         message = "Player Wins!!!";
      } else {
         message = "Computer Wins!!!";
      }
      break;
   case "Paper":
      if (choices[playerChoise] === "Paper") {
         message = "It's a tie!!!";
      } else if (choices[playerChoise] === "Scissors") {
         message = "Player Wins!!!";
      } else {
         message = "Computer Wins!!!";
      }
      break;
   case "Scissors":
      if (choices[playerChoise] === "Scissors") {
         message = "It's a tie!!!";
      } else if (choices[playerChoise] === "Rock") {
         message = "Player Wins!!!";
      } else {
         message = "Computer Wins!!!";
      }
      break;
   default:
      break;
}
​
console.log(message + "(switchStatment)");