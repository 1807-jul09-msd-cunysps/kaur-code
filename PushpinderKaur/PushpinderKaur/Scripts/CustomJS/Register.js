window.onload = function () {
    function checkAdd() {
        var check = document.querySelector("#checkAddress").value;
        if (check == 0) {// check user have selected No
            // get reference of the element to be selected
            var address2 = document.querySelector("#address2");// get reference of the element to be selected
            var h3 = document.createElement("h3");//Create a new wlwment in the DOM tree
            h3.innerText = "Permanent Address"; // Add inner Text to it
            var lbladd1 = document.createElement("label"); // create another element
            lbladd1.innerText = "Address Line 1"; // add inner text to it
            var add1 = document.createElement("input"); // create a text attribute
            add1.setAttribute("type", "text");// set attribute
            address2.appendChild(h3); // tie the elements to the parent (<div id=address2)>)
            address2.appendChild(lbladd1); // tie the elements to the parent (<div id=address2)>)
            address2.appendChild(add1); // tie the elements to the parent (<div id=address2)>)
        }
    };
    var firstName = document.getElementById("exampleFirstName");
    /*if (addEventListener) {
        
        //firstName.addEventListener("blur",welcome)
        firstName.addEventListener("blur", function () {
            var firstName = document.querySelector("#exampleFirstName").value;// CSS selectors
            var data = document.querySelectorAll("input");
            alert("Welcome " + firstName);
        })
    }
    else {
        firstName.attachEvent("blur", function () {
            var firstName = document.querySelector("#exampleFirstName").value;// CSS selectors
            var data = document.querySelectorAll("input");
            alert("Welcome " + firstName);
        })
    }*/
    firstName.onblur = welcome1;

    function welcome() {
        debugger;
        // var firstName = document.getElementById("exampleFirstName").value;
        var firstName = document.querySelector("#exampleFirstName").value;// CSS selectors
        var data = document.querySelectorAll("input");
        alert("Welcome " + firstName);
    }
}


