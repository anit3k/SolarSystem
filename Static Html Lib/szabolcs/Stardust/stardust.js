//Generate a random number between 2000 and 2500 for the stars
var maxStar = Math.floor( Math.random() * 2500 )+ 2000;

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
  //console.log(x, y);
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
    var counter = 50;


 

    for (var i = 0; i < stars.length; i++)
    {

        var actPositionX = stars[i].style.left;
        var actPositionY = stars[i].style.top;
        actPositionX = Number(actPositionX.substring(0, actPositionX.length-2));
        actPositionY = Number(actPositionY.substring(0, actPositionY.length-2));
        /*Checking the mouse and star positions. Not needed.
        console.log(actPositionX +","+ actPositionY);
        console.log(getMouseX(), getMouseY());*/

        if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
            if((actPositionX + counter) >= (window.innerWidth - 15) || (actPositionY + counter) >= (window.innerHeight - 15))
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
        }
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            if((actPositionX + counter) <= (window.innerWidth - 15) || (actPositionY + counter) <= (window.innerHeight - 15))
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px"; 
            }
        }
        else if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            if((actPositionX + counter) <= (window.innerWidth - 15) || (actPositionY + counter) >= (window.innerHeight - 15))
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px"; 
            }
        }
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
            if((actPositionX + counter) >= (window.innerWidth - 15) || (actPositionY + counter) <= (window.innerHeight - 15))
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
        } 
        else
        {
            stars[i].style.background = "white";
        }
    }
   
  }, 10);