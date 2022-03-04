var frame = document.getElementById("stardust-container");
//Generate a random number between 1000 and 1200 for the stars
var maxStar = Math.floor( Math.random() * 1200 )+ 1000;

//Generate random amount of stars
for (var starcounter = 0; starcounter < maxStar; starcounter++) {
    const star = document.createElement("span");
    document.getElementById("stardust-container").appendChild(star);
    
}
