let j0bj = [{
    "name": "Learn JavaScript",
    "status": true
},
{
    "name": "Learn Java",
    "status": false
},
{
    "name": "C#",
    "status": true
}
];

j0bj.forEach(el => console.log(el.name));
console.log(JSON.stringify(j0bj));
