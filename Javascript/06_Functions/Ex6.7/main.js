alert("aloooo");

let start = 10;

function countdown(countdownVal) {
    console.log(countdownVal);
    if (countdownVal < 1) {
        return 1;
    }else{
        countdown(countdownVal - 1);
        
    }

}

countdown(start);

(function () {
    console.log("immediately invoked function expression (IIFE) ");
})();

// let IIFE = (function () {
//     console.log("immediately invoked function expression (IIFE) ");
// });

// IIFE();

// [].forEach(function (e) {
//     console.log(e)
// })
