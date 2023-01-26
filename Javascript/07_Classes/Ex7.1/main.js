class Person {
    constructor(fName, lName){
        this.firstname = fName;
        this.lastname = lName;
    }
}


let friend1 = new Person("damjan","mladenovski");
let friend2 = new Person("matej","dimitrovski");

console.log("Hi " + friend1.firstname + " " + friend1.lastname);
console.log("Hi " + friend2.firstname + " " + friend2.lastname);

function sayHi(person) {
    console.log("Hi " + person.firstname + " " + person.lastname);
}

sayHi(friend1);
sayHi(friend2);

class PersonMethods {
    constructor(fName, lName){
        this.firstname = fName;
        this.lastname = lName;
    }

    greet(){
        console.log("Hi there!");
    }
    compliment(name, object){
        return "That's a wonderfull " + object + ", " + name;
    }
}

let ana = new PersonMethods("Ana", "Cvetskovski");
let nate = new PersonMethods("Natalija", "Stemenkovska");

ana.greet();
nate.greet();

let anaCompliment = ana.compliment (nate.firstname, "dress");
console.log(anaCompliment);