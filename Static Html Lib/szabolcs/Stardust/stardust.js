//Generate a random number between 2000 and 2500 for the stars
var maxStar = Math.floor( Math.random() * 500 )+ 2000;
//console.log(maxStar);
//Generate random amount of stars with random positions
for (var starcounter = 0; starcounter <= maxStar; starcounter++) 
{
    //console.log(":: "+starcounter);
    var positionX = Math.floor( Math.random() * (window.innerWidth - 15) );
    var positionY = Math.floor( Math.random() * (window.innerHeight - 15) );
    const star = document.createElement("span");
    star.style.left = positionX + "px";
    star.style.top = positionY + "px";
    document.getElementById("stardust-container").appendChild(star);
    star.setAttribute("id", "star-" + starcounter);
}

//Getting the position of the mouse

var x = null;
var y = null;
    
document.addEventListener('mousemove', onMouseUpdate, false);
document.addEventListener('mouseenter', onMouseUpdate, false);
    
function onMouseUpdate(e) 
{
  x = e.pageX;
  y = e.pageY;
}

function getMouseX() 
{
  return x;
}

function getMouseY() 
{
  return y;
}

//Making the stars move

const element = document.getElementById("stardust-container");
setInterval(function() 
{
    var stars = document.getElementsByTagName("span");
    var counter = 50;

    for (var i = 0; i < stars.length; i++)
    {

        var actPositionX = stars[i].style.left;
        var actPositionY = stars[i].style.top;
        actPositionX = Number(actPositionX.substring(0, actPositionX.length-2));
        actPositionY = Number(actPositionY.substring(0, actPositionY.length-2));

        //Bottom right corner of the mouse
        if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
           /* if((actPositionX + counter) >= (window.innerWidth - 15) || (actPositionX - counter) <= 0)
            {
                /*stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
                

            }
            else if ((actPositionY + counter) >= (window.innerHeight - 15) || (actPositionY - counter) <= 0)
            {
                /*stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
                starMove();
            }
            else
            {
                /*stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
                starMove(); 
            }*/
            starMove4(stars[i].id);
            
        }
        //Top left corner of the mouse
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            /*if((actPositionX + counter) <= (window.innerWidth - 15) || (actPositionX - counter) >= 0)
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else if ((actPositionY + counter) <= (window.innerHeight - 15) || (actPositionY - counter) >= 0)
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px"; 
            }*/
            starMove3(stars[i].id);
        }
        //Bottom left corner of the mouse
        else if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            /*if((actPositionX + counter) <= (window.innerWidth - 15) || (actPositionX - counter) >= 0)
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else if ((actPositionY + counter) <= (window.innerHeight - 15) || (actPositionY - counter) >= 0)
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px"; 
            }*/
            starMove1(stars[i].id);
        }
        //Top right corner of the mouse
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
            /*if((actPositionX + counter) >= (window.innerWidth - 15) || (actPositionY - counter) <= 0)
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
            }
            else if ((actPositionY + counter) >= (window.innerHeight - 15) || (actPositionY - counter) <= 0)
            {
                stars[i].style.left = (actPositionX + counter) + "px";
                stars[i].style.top = (actPositionY - counter) + "px";
            }
            else
            {
                stars[i].style.left = (actPositionX - counter) + "px";
                stars[i].style.top = (actPositionY + counter) + "px";
             }*/
            starMove2(stars[i].id);
        }
    }
   
  }, 10);
  
  function starMove1(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame()
    {
      if (pos1 >= (pos1 + 50))
      {
        clearInterval(id);
      }
      else
      {
        pos1--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos1: " + pos1);
      }
      if (pos2 >= (pos2 + 50)) 
      {
        clearInterval(id);
      } 
      else
      {
        pos2++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos2: " + pos2);
      }
    }
  }

  function starMove2(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame()
    {
      if (pos1 >= (pos1 + 50))
      {
        clearInterval(id);
      }
      else
      {
        pos1++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos1: " + pos1);
      }
      if (pos2 >= (pos2 + 50)) 
      {
        clearInterval(id);
      } 
      else
      {
        pos2--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos2: " + pos2);
      }
    }
  }

  function starMove3(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame()
    {
      if (pos1 >= (pos1 + 50))
      {
        clearInterval(id);
      }
      else
      {
        pos1--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos1: " + pos1);
      }
      if (pos2 >= (pos2 + 50)) 
      {
        clearInterval(id);
      } 
      else
      {
        pos2--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos2: " + pos2);
      }
    }
  }

  function starMove4(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    clearInterval(id);
    id = setInterval(frame, 5);
    function frame()
    {
      if (pos1 >= (pos1 + 50))
      {
        clearInterval(id);
      }
      else
      {
        pos1++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos1: " + pos1);
      }
      if (pos2 >= (pos2 + 50)) 
      {
        clearInterval(id);
      } 
      else
      {
        pos2++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
        //console.log("pos2: " + pos2);
      }
    }
  }