document.body.style.color = "red";
const myDiv = document.getElementsByTagName("div")[0];

myDiv.addEventListener("click", function(){
if (myDiv.style.backgroundColor === "black") {
    myDiv.style.backgroundColor = "white";
    myDiv.style.color = "black";
} else {
    myDiv.style.backgroundColor = "black";
    myDiv.style.color = "white";
}
})

//11.2
const paragraphOne = document.createElement("p");
paragraphOne.interText = "blue";
paragraphOne.addEventListener("click", changeTextColor);

const paragraphTwo = document.createElement("p");
paragraphTwo.interText = "green";
paragraphTwo.addEventListener("click", changeTextColor);

function changeTextColor() {
    this.style.color = this.innerText;
}

myDiv.appendChild(paragraphOne);
myDiv.appendChild(paragraphTwo);