let myDivMouseEvent = document.createElement("div")
myDivMouseEvent.style.height = "50px";
myDivMouseEvent.style.widh = "200px";
myDivMouseEvent.style.backgroundColor = "pink";

function changeColor(colorName, element) {
    console.log(colorName, element)
    element.style.backgroundColor = colorName;
}

myDivMouseEvent.addEventListener("mouseover", function () {
    changeColor("green", this);
 });
 myDivMouseEvent.addEventListener("mouseup", function () {
    changeColor("red", this);
 });
 myDivMouseEvent.addEventListener("mousedown", function () {
    changeColor("blue", this);
 });
 myDivMouseEvent.addEventListener("mouseout", function () {
    changeColor("yellow", this);
 });

document.body.appendChild(myDivMouseEvent);