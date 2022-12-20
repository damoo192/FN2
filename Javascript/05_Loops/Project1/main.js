let multTable = [];
let value = 7;

outer:
for (let i = 1; i < 5; i++) {
    let temp = [];
    inner:
    for (let j = 1; j < 20; j++) {
        let res = i * j
        if (res > 45) {
            break outer;
        }
        if (temp.length === 7) {
            break;
        }
        if (res % 2 === 0) {
            continue;
        }
        temp.push(res);
    }
    multTable.push(temp);
}
console.log(multTable);