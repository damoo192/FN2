
let broj = function brojot(brojVal) {
 console.log(brojVal);
}

broj("alooo");

function brojot(brojVal) {
    console.log(brojVal);
   }

   brojot("abee");


   function doFlexibleStuff(executeStaff) {
    executeStaff("Damjan Mladenovski");
    console.log("Inside doFlexibleStuff Function");
   }

   doFlexibleStuff(broj);

let logName = function () {
    console.log("My name is Damjan") 
}
   setTimeout(logName, 5000);
   setInterval(() => console.log(new Date().getHours().toString(),
":", new Date().getMinutes().toString(), ":", 
new Date().getSeconds().toString()), 1000);