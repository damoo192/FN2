alert("alooooo")

/*
1. Write a JavaScript program to display the current day and time in the following format.  Go to the editor
Sample Output : Today is : Tuesday.
Current time is : 10 PM : 30 : 38
Click me to see the solution
*/

// console.log(`Today is : ${"Tuesday"}`);
let denovi= ["Nedela","Ponedelnik","Vtornik","Sreda",
"Cetvrtok","Petok","Sabota"]

let indexZaDen = new Date().getDay();
console.log(`Today is : ${denovi[indexZaDen]}`);

// console.log(new Date().getDay());

let datum = new Date();
let saat = datum.getHours();
let minuti = datum.getMinutes();
let sekundi = datum.getSeconds();
let saatNov;
let amPm;
if (saat > 12) {
    saatNov = saat - 12;
    amPm = "PM"
} else{
    saatNov = saat;
    amPm = "AM"
}
console.log(`Momentalno vreme e : ${saatNove} ${amPm} : ${minuti} : ${sekundi} `);