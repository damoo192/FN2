let output = document.getElementById("output");
let ex8Div = document.getElementById("ex8");
let inputs =document.querySelectorAll("input");

for (const el of inputs ){
    el.addEventListener("keyup", function (event) {
        console.log(event.key);
    });
    el.addEventListener("keyup", function (event) {
        console.log(typeof event.key);
        if (!isNaN(event.key)) {
            output.textContent += event.key;
        }
    });
    el.addEventListener("keyup", function (event) {
        console.log("paste");
        
    });
}