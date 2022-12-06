
let age = prompt("What is your age");
Number(age);

let message = "";

if (age >= 21 ){
    message ="You can buy alcohol.";
}  else if (age >= 19) {
    message ="You can't buy alcohol but you can enter.";
} else{
    message ="You can not enter.";
}
console.log(message);