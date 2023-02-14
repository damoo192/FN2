const myWords = ["learn Javascript", "learn html", "learn css"];
const game = {
    word: "",
    solution: "",
    pageElements: [],
    lettersLeft: 0
}
const gameArea = document.querySelector(".gameArea");
const score = document.querySelector(".score");
const puzzle = document.querySelector(".puzzle");
const letters = document.querySelector(".letters");
const button = document.querySelector("button");
button.addEventListener("click", startGame);

function startGame() {
    if (myWords.length > 0) {
        button.style.display = "none";
        game.pageElements = [];
        game.lettersLeft = 0;
        game.word = myWords.shift();
        game.solution = game.word.split("");
        builder();
    }
}

function crateElement(tagName, parent, ouputContent, classOfElement) {
    let myElement = document.createElement(tagName);
    myElement.classList.add(classOfElement);
    parent.append(myElement);
    myElement.textContent = ouputContent;
    return myElement;
}

function builder() {
    puzzle.innerHTML = "";
    letters.innerHTML = "";
    for (const letter of game.solution) {
        let element = crateElement("p", puzzle, "-", "boxE");
        if (letter === " ") {
            element.textContent = "";
            element.style.borderColor = "white";
        } else {
            game.lettersLeft++;
        }
        game.pageElements.push(element);
        updateScore();
    }
    for (let i = 0; i < 26; i++) {
        const alphabet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"];
        let char = alphabet[i]
        //let char = String.fromCharCode(i);
        let myElement = crateElement("div", letters, char, "box");
        myElement.addEventListener("click", checker);
    }
}

function checker() {
    console.dir(this);
    this.classList.remove("box");
    this.classList.add("boxD");
    this.style.backgroundColor = "lightGray";
    this.removeEventListener("click", checker);
    checkLetter(this.textContent);
}

function checkLetter(letter) {
    game.solution.forEach((element, index) => {
        if (element.toUpperCase() === letter) {
            game.pageElements[index].textContent = letter;
            game.lettersLeft--;
            updateScore();
        }
    });
}

function updateScore() {
    if (game.lettersLeft === 0) {
        score.textContent = "Game over";
        puzzle.textContent = "";
        button.style.display = "block";
    } else {
        score.textContent = game.lettersLeft;
    }
}

