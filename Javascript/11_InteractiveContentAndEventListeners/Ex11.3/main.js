
function message(text, object){
    console.log(text, object);
}

window.addEventListener("DOMContentLoaded", (event) => {
    message("Document Ready", event);
});

window.onload = event => {
    message("Window Ready", event);
}