
console.log(document.getElementById("details-frame").style.display="none");
console.log(document.getElementById("details-frame").style.display);

function details(planet){
    var frame = document.getElementById("details-frame");
    var solarSysCon = document.getElementById("solar-system-container");
    
    
    if(frame.style.display == "none"){
        frame.style.display = "block";
        solarSysCon.style.display = "none";
        console.log("alma");
    }else{
        console.log("körte");
    }
}