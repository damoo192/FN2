let myTable = [];
let row = 5;
let col = 7;

let counter = 0;

for (let i = 0; i < row; i++){
  let tempTable = [];

  for (let j = 0; j < col; j++){
    tempTable.push(counter);
    counter++;
    }
    myTable.push(tempTable);
}

console.log(myTable);