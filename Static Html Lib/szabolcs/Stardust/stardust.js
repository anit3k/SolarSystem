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

(function() {
    document.onmousemove = handleMouseMove;
    function handleMouseMove(event) {
        var eventDoc, doc, body;

        event = event || window.event;

        if (event.pageX == null && event.clientX != null) {
            eventDoc = (event.target && event.target.ownerDocument) || document;
            doc = eventDoc.documentElement;
            body = eventDoc.body;

            event.pageX = event.clientX +
              (doc && doc.scrollLeft || body && body.scrollLeft || 0) -
              (doc && doc.clientLeft || body && body.clientLeft || 0);
            event.pageY = event.clientY +
              (doc && doc.scrollTop  || body && body.scrollTop  || 0) -
              (doc && doc.clientTop  || body && body.clientTop  || 0 );
        }

    }
})();