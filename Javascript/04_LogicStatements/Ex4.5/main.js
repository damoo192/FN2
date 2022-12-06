let userInput = prompt("Enter a nnumber between 0 and 10");
let selectedNumber = Number(userInput);

let message = "my selection: ";
switch (selectedNumber) {
    case 0:
        message +="Bear";
        break;
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
    default:
        message = "Invalid input";
        break;
}