alert("alooo")
/*
17. Write a JavaScript function to calculate the sum of values in an array. Go to the editor
Test Data :
console.log(sum([1,2,3]));
console.log(sum([100,-200,3]));
console.log(sum([1,2,'a',3]));
Output :
6
-97
6
*/

function sum(arr){
    let sumOfArr = 0;
    for (const element of arr) {
       if(!isNaN(element)) {
        sumOfArr +=element;
       }
    }

    return sumOfArr;
}
console.log(sum([1,2,3]));
console.log(sum([100,-200,3]));
console.log(sum([1,2,'a',3]));