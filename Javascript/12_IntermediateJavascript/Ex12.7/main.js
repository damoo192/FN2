function test(pval) {
    try{
        if (isNaN(val)) {
            throw "Not a number";
        } else {
            console.log("Number!");
        }
    } catch (error) {
        console.log (error);
    } finally{
        console.log("Done " + val);
    }
}
let array = 2;

function name(params) {
    try {
        console.log(array.filter("test"))
    } catch (error) {
        array = [];
        console.log("You did't send array")
    }
}