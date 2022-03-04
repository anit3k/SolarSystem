var frame = document.getElementById("stardust-container");
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

//const positionUpdate = setTimeout(myGreeting, 500);

/*function starMovement() {
    var e = window.event;

    var posX = e.clientX;
    var posY = e.clientY;

    document.Form1.posx.value = posX;
    document.Form1.posy.value = posY;

    var t = setTimeout(mouse_position,100);
    console.log(t);
}*/