let num1 = 5;
let num2 = 3;
let operator = "-";

function calculator(n1, n2, op) {
    let res;
    console.log(n1);
    console.log(n2);
    console.log(op);
    switch (op) {
        case "-" :
            res = n1 - n2;
            break;
        case "+" :
            res = n1 + n2;
            break;
        case "*" :
            res = n1 * n2;
            break;
        case "/" :
            res = n1 / n2;
            break;
        default:
            res = n1 + n2;
            break;
    }
    return res;
}

let res = calculator(num1, num2, operator);
console.log(calculator(5, 5, "*"));
console.log(calculator(3, 7, "*"));
console.log(calculator());

function sumOfTwoNumbers(n1, n2) {
    let res = n1 + n2;
    return res;
}

sumOfTwoNumbers(5, 10);

let sumOfTwoNumbers2 = function(n1, n2) {
    let res = n1 + n2;
    return res;
}

console.log(sumOfTwoNumbers3(5, 2));

let sumOfTwoNumbers3 = (n1, n2)  =>  n1 + n2;


console.log(sumOfTwoNumbers3(5, 10));