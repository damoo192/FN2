alert ("alooo")

let resultArr = [];

for (let i = 0; i < 10; i ++) {
    let arg1 = i * 5;
    let arg2 = i * i;

    let res = addTwoNumbers(arg1, arg2);
    resultArr.push(res);
}

function addTwoNumbers(par1, par2){
    return par1 + par2;
}

console.log(resultArr);
