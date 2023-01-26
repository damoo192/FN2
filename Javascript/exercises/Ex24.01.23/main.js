alert("aloooo");

function logRecursive(nr){
    console.log("Started function", nr)
    if (nr > 0) {
        logRecursive(nr - 1);
    } else {
        console.log("done with recursion");
}
console.log("Ended function: ", nr);
}

logRecursive(3);