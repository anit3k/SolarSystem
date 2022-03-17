"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/planetSelecterHub").build();


connection.on("PlanetSelecter", function (message) {

    let temp = "http://10.108.149.16:81/Home/Detail/" + message;
    location.href = temp;

});

connection.start().then(function () {
    
});

