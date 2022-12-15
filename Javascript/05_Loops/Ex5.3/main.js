let myWork=[];

for (let i = 0; i < 11; i++) {
    myWork.push(
        {
            name: "Lesson " + i,
            status: i % 2 > 0 ? true : false
        }
    );
}
console.log(myWork);
