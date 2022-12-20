let output = "";
let skipNum = 3;

for (let i = 0; i < 10; i++) {
    if (i === skipNum) {
        continue;
    }
    output += i;
}

console.log(output);

let output1 = "";

for (let i = 0; i < 10; i++) {
    if (i === skipNum) {
        break;
    }
    output1 += i;
}

console.log(output1);