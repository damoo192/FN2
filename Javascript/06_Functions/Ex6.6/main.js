alert("aloooo");

function factorial(nr) {
    if (nr === 0){
        return 1;
    }

    return nr * factorial(--nr);
}

console.log(factorial(5));
console.log(factorial(7));