//Generate a random number between 500 and 600 for the stars
var maxStar = Math.floor( Math.random() * 500 )+ 600;

//Generate random amount of stars with random positions
for (var starcounter = 0; starcounter <= maxStar; starcounter++) 
{
    var positionX = Math.floor( Math.random() * (window.innerWidth - 15) );
    var positionY = Math.floor( Math.random() * (window.innerHeight - 15) );
    const star = document.createElement("span");
    star.style.left = positionX + "px";
    star.style.top = positionY + "px";
    document.getElementById("stardust-container").appendChild(star);
    star.setAttribute("id", "star-" + starcounter);
    var randPic = Math.floor( Math.random() * 5)+ 1;
    console.log(randPic);
    star.style.backgroundImage = "url(./Stars/star"+ randPic + ".png)";
    var randSize = Math.floor( Math.random() * 20)+ 13;
    star.style.width = randSize + "px";
    star.style.height = randSize + "px";
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
    var counter = 25;

    for (var i = 0; i < stars.length; i++)
    {

        var actPositionX = stars[i].style.left;
        var actPositionY = stars[i].style.top;
        actPositionX = Number(actPositionX.substring(0, actPositionX.length-2));
        actPositionY = Number(actPositionY.substring(0, actPositionY.length-2));

        //Bottom right corner of the mouse
        if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
            starMove4(stars[i].id);
        }
        //Top left corner of the mouse
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            starMove3(stars[i].id);
        }
        //Bottom left corner of the mouse
        else if (((actPositionY <= getMouseY()+counter && actPositionY >= getMouseY()+0) && (actPositionX >= getMouseX()-counter && actPositionX <= getMouseX()+0))) 
        {
            starMove1(stars[i].id);
        }
        //Top right corner of the mouse
        else if (((actPositionY >= getMouseY()-counter && actPositionY <= getMouseY()+0) && (actPositionX <= getMouseX()+counter && actPositionX >= getMouseX()+0))) 
        {
            starMove2(stars[i].id);
        }
    }
   
  }, 10);
  
  //Moving the stars to the bottom left corner
  function starMove1(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    var ogPos1 = pos1;
    var ogPos2 = pos2;
    clearInterval(id);
    id = setInterval(frame, 1);
    function frame()
    {
      if (pos1 <= (ogPos1 + 25))
      {
        pos1--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      }
      else
      {
        clearInterval(id);
      }
      if (pos2 <= (ogPos2 + 25)) 
      {
        pos2++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      } 
      else
      {
        clearInterval(id);
      }
    }
  }

  //Moving the stars to the top right corner
  function starMove2(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    var ogPos1 = pos1;
    var ogPos2 = pos2;
    clearInterval(id);
    id = setInterval(frame, 1);
    function frame()
    {
      if (pos1 <= (ogPos1 + 25))
      {
        pos1++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      }
      else
      {
        clearInterval(id);
      }
      if (pos2 <= (ogPos2 + 25)) 
      {
        pos2--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      } 
      else
      {
       clearInterval(id);
      }
    }
  }

  //Moving the stars to the top left corner
  function starMove3(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    var ogPos1 = pos1;
    var ogPos2 = pos2;
    clearInterval(id);
    id = setInterval(frame, 1);
    function frame()
    {
      if ((pos1 + 50) >= (ogPos1 + 50))
      {
        pos1--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      }
      else
      {
        clearInterval(id);
      }
      if ((pos2 + 50) >= (ogPos2 + 50)) 
      {
        pos2--; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      } 
      else
      {
        clearInterval(id);
      }
    }
  }

  //Moving the stars to the bottom right corner
  function starMove4(starId)
  {
    var id = null;
    const elem = document.getElementById(starId);
    var pos1 = elem.style.left;
    var pos2 = elem.style.top;
    pos1 = Number(pos1.substring(0, pos1.length-2));
    pos2 = Number(pos2.substring(0, pos2.length-2));
    var ogPos1 = pos1;
    var ogPos2 = pos2;
    clearInterval(id);
    id = setInterval(frame, 1);
    function frame()
    {
      if (pos1 <= (ogPos1 + 25))
      {
        pos1++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      }
      else
      {
        clearInterval(id);
      }
      if (pos2 <= (ogPos2 + 25)) 
      {
        pos2++; 
        elem.style.top = pos2 + "px"; 
        elem.style.left = pos1 + "px";
      } 
      else
      {
        clearInterval(id);
      }
    }
  }