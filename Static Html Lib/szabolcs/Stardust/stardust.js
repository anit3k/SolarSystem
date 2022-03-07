//Generate a random number between 1000 and 1200 for the stars
var maxStar = Math.floor( Math.random() * 1200 )+ 1000;

//Generate random amount of stars with random positions
for (var starcounter = 0; starcounter < maxStar; starcounter++) {
    var positionX = Math.floor( Math.random() * (window.innerWidth - 15) );
    var positionY = Math.floor( Math.random() * (window.innerHeight - 15) );
    const star = document.createElement("span");
    star.style.left = positionX + "px";
    star.style.top = positionY + "px";
    document.getElementById("stardust-container").appendChild(star);
    
}

//Getting the position of the mouse

var x = null;
var y = null;
    
document.addEventListener('mousemove', onMouseUpdate, false);
document.addEventListener('mouseenter', onMouseUpdate, false);
    
function onMouseUpdate(e) {
  x = e.pageX;
  y = e.pageY;
  console.log(x, y);
}

function getMouseX() {
  return x;
}

function getMouseY() {
  return y;
}

//Making the stars move

const element = document.getElementById("stardust-container");
setInterval(function() {
    var stars = document.getElementsByTagName("span");

 

    for (var i = 0; i < stars.length; i++)
    {

        var actPositionX = stars[i].style.left;
        var actPositionY = stars[i].style.top;
        actPositionX = Number(actPositionX.substring(0, actPositionX.length-2));
        actPositionY = Number(actPositionY.substring(0, actPositionY.length-2));
        console.log(actPositionX +","+ actPositionY);
        console.log(getMouseX(), getMouseY());

       /* if ((actPositionY <= getMouseY()+100 && actPositionX <= getMouseX()+100) || (actPositionY >= getMouseY()-100 && actPositionX >= getMouseX()-100)) 
        {
            stars[i].style.background = "yellow";    
        }
        else if ((actPositionY <= getMouseY()+100 && actPositionX <= getMouseX()-100) || (actPositionY >= getMouseY()-100 && actPositionX >= getMouseX()+100))
        {
            stars[i].style.background = "yellow";
        }
        else{
            stars[i].style.background = "white";
        }*/
        if (((actPositionY <= getMouseY()+100 && actPositionY >= getMouseY()+0) && (actPositionX <= getMouseX()+100 && actPositionX >= getMouseX()+0))) 
        {
            stars[i].style.background = "yellow";    
        }
        else if (((actPositionY >= getMouseY()-100 && actPositionY <= getMouseY()+0) && (actPositionX >= getMouseX()-100 && actPositionX <= getMouseX()+0))) 
        {
            stars[i].style.background = "green";    
        }
        //
        else if (((actPositionY >= getMouseY()-100 && actPositionY <= getMouseY()+0) && (actPositionX >= getMouseX()-100 && actPositionX <= getMouseX()+0))) 
        {
            stars[i].style.background = "green";    
        }
        else{
            stars[i].style.background = "white";
        }
    }
   
  }, 10);