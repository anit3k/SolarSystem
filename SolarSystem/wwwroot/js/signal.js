"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/planetSelecterHub").build();


connection.on("PlanetSelecter", function (message) {

    let temp = "http://localhost:59557/Home/Detail/" + message;
    location.href = temp;

});

connection.start().then(function () {
    
});

