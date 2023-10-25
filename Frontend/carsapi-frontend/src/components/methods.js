import React from "react";
import axios from "axios";

//POST
export function postMethod() {
    //A HTML tagekben található értéket adja vissza
    var nameValue = document.getElementById("inputName").value;
    var colorValue = document.getElementById("inputColor").value;
    var descriptionValue = document.getElementById("inputDescription").value;

    //A HTML taget adja vissza
    var name = document.getElementById("inputName");
    var color = document.getElementById("inputColor");
    var description = document.getElementById("inputDescription");
    var response = null;

    if(name.classList.contains("is-valid") && color.classList.contains("is-valid") && description.classList.contains("is-valid")) {
        response = axios.post("https://localhost:7141/api/Car", {"name": nameValue,"desription": descriptionValue,"color": colorValue})
        response.then(res => console.log(res.data));
    } else {
        console.log("sikertelen");
    }
}

//UPDATE
export function updateMethod() {

}

//GET BY ID
export function getByIdMethod(id) {
    
}


export function validation() {
    //A HTML taget adja vissza
    var name = document.getElementById("inputName");
    var color = document.getElementById("inputColor");
    var description = document.getElementById("inputDescription");

    if(name.value == "") {
        name.classList.add("is-invalid");
    } else {
        name.classList.add("is-valid");
        name.classList.remove("is-invalid");
    }
    if(color.value == "") {
        color.classList.add("is-invalid");
    } else {
        color.classList.add("is-valid");
        color.classList.remove("is-invalid");
    }
    if(description.value == "") {
        description.classList.add("is-invalid");
    } else {
        description.classList.add("is-valid");
        description.classList.remove("is-invalid");
    }

}