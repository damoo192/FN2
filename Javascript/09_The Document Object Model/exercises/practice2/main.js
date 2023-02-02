const title = document.querySelector("h1");
title.innerText = "Exercise exemple for 9.3";

// console.dir(title);
// console.log(title.classList);
title.classList.add("red");

let paragraph = document.querySelector("p")
paragraph.id = "MyP";

console.dir(paragraph);

paragraph.style.backgroundColor = "lightgray";

console.log(document.URL);

paragraph.innerText = document.URL;
