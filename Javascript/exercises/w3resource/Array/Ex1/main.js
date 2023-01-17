
/*
1. Write a JavaScript function to check whether an `input` is an array or not. Go to the editor
Test Data :
console.log(is_array('w3resource'));
console.log(is_array([1, 2, 4, 0]));
false
true
*/
// let myArray = [1,"t",new Date()];

// console.log(typeof myArray === typeof{ name: "Boben"});
// console.log(Array.isArray([]));
// console.log(typeof({}));

function is_array(arr){
    let isArray = false;

    if (Array.isArray(arr)){
        isArray = true;
    }
    return isArray;
}

console.log(is_array('w3resource'));
console.log(is_array([1,2,4,0]));