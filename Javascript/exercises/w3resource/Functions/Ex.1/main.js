alert("allloooo");

/*
1. Write a JavaScript function that reverse a number. Go to the editor
Example x = 32243;
Expected Output : 34223
Click me to see the solution
*/

let x = 32243;
let stringOfX = x.toString();
let arrayOfX = stringOfX.split("")
console.log(arrayOfX);
let reverseArrOfX = arrayOfX.reverse();
let reverseStringOfX = reverseArrOfX.join("");
let reversX = parseInt(reverseStringOfX);
console.log(reversX);

function ReverseNumber2(x) {
    let y = x.toString().split("").reverse().join("");
    return parseInt(y);
}

console.log(ReverseNumber2(322423));
console.log(ReverseNumber2(324523));
console.log(ReverseNumber2(324234));