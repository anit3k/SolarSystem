//Generate a random number between 1000 and 1200 for the stars
var maxStar = Math.floor( Math.random() * 1200 )+ 1000;

//Generate random amount of stars
for (var starcounter = 0; starcounter < maxStar; starcounter++) {
    var positionX = Math.floor( Math.random() * (window.innerWidth - 15) );
    var positionY = Math.floor( Math.random() * (window.innerHeight - 15) );
    const star = document.createElement("span");
    star.style.left = positionX + "px";
    star.style.top = positionY + "px";
    document.getElementById("stardust-container").appendChild(star);
    
}

function mouse_position()
{
    var e = window.event;

    var posX = e.clientX;
    var posY = e.clientY;

    console.log(posX);
    console.log(posY);

    setTimeout(mouse_position,100);
    
}
mouse_position();