window.onload = function(){
    let navItem = document.querySelectorAll("#navList li");
    console.log(navItem);
    
    navItem.forEach(li => {
        li.addEventListener("click", function () {
            console.log(this.textContent.toLowerCase());
            let sectionID = this.textContent.toLowerCase();
            console.log(document.getElementById("galery"));

            if(document.getElementById("galery") === null){
                // document.querySelector("main").innerHTML +=
                // "<section id='galery'><h2>Galery</h2></section>";
                
                document.querySelector("main").innerHTML +=
                `
                <section id="galery">
                    <h2>${sectionID.charAt(0).toUpperCase() + sectionID()}</h2>
                </section>    
                `
            }
            document.querySelectorAll("main section").forEach(sec =>{
                if(sec.id === sectionID){
                    sec.classList.remove("d-none");
                }
                else{
                    if(!sec.classList.contains()){
                        sec.classList.add("d-none");
                    }
                }
            });
        })
    });
}
