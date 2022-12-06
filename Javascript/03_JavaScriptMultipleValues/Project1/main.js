const theList = ['Laurence', 
'Svekis', 
true, 35, 
null, 
undefined, 
{test: 'one', score: 55}, 
['one', 'two']
];



let result = [
    'FIRST',
    'Svekis',
    'MIDDLE',
    'Hello World',
    'LAST',
];

console.log(result);

theList.shift();
theList.pop();
theList.unshift("FIRST");
theList.splice(4,0,"hello World")
theList.splice(3,0,"MIDDLE")
theList.push("LAST")
console.log(theList);