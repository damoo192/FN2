const grid = [];
const cells = 64;
let counter = 0;
let row;

for (let x = 0; x < cells + 1; x++) {
   if (counter % 8 == 0) {
      if (row != undefined) {
         grid.push(row);
      }
      row = [];
   }
   row.push(++counter);
}
console.table(grid);