let randomNumber = Math.random();
randomNumber = randomNumber * 6;
randomNumber = Math.floor(randomNumber);


let userInput = prompt("Ask your question")

switch(randomNumber){
    case 0:
        answer = "stupid question";
        break;
    case 1:
        answer = "in your dreams";
        break;
    case 2:
        answer = "hell no";
        break;
    case 3:
        answer = "mhhh";
        break;
    case 4:
        answer = "maybe";
        break;
    case 5:
        answer = "yes";
        break;
    case 6:
        answer = "yes 1000%";
}

console.log(userInput);
console.log(answer);
