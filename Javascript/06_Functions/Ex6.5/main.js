alert("aloooo");

let myVar = "1000";

(function () {
    let myVar = "Local 1000";
})();

let resultVar = (function() {
let myVar = "Return Local 1000";
return myVar;
}
)();

console.log(resultVar);
console.log(myVar);

(function(par1){
    myVar = par1;
})("Global 1000")
console.log(myVar);
