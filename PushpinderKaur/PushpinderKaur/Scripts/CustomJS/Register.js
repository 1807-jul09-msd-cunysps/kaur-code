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
    /*firstName.onblur = welcome;
    function welcome() {
        debugger;
        // var firstName = document.getElementById("exampleFirstName").value;
        var firstName = document.querySelector("#exampleFirstName").value;// CSS selectors
        var data = document.querySelectorAll("input");
        alert("Welcome " + firstName);
    }*/
function stripquotes(a) {
    debugger;
    

    return a;
}

function locationPopulate(json) {
    debugger;
   // var json = { "zip_code": "10017", "lat": 0.711263, "lng": -1.29106, "city": "New York", "state": "NY", "timezone": { "timezone_identifier": "America\/New_York", "timezone_abbr": "EDT", "utc_offset_sec": -14400, "is_dst": "T" }, "acceptable_city_names": [{ "city": "Grand Central", "state": "NY" }, { "city": "Manhattan", "state": "NY" }, { "city": "Nyc", "state": "NY" }] };
    json = JSON.parse(json);
    var state = document.getElementById("State");
    var city = document.getElementById("City");
    state.value = json.state;
    city.value = json.city;
}

function checkZipcodeWithFile() {
 
    var zipcode = document.getElementById("zipcode").value;
    var url = "../zipcode.txt";
    var xhr = new XMLHttpRequest();
    xhr.open('GET', url);
    xhr.onreadystatechange = function (e) {    //Call a function when the state changes.
        if (this.readyState == XMLHttpRequest.DONE && this.status == 200) {
            var result = xhr.responseText;
            if (result !== null || result !== "" || result !== undefined) {
                if (result.charAt(0) === '"' && result.charAt(result.length - 1) === '"') {
                    result = result.substr(1, result.length - 2);
                 }
                debugger;
                locationPopulate(result);
            }
            
        }
    }
    xhr.send();
}
function checkZipcode()
{
        debugger;
        var zipcode = document.getElementById("zipcode").value;
        var clientKey = 'js-YJinPMmmqbKEhKQetnGUovcNgrZRxHmaJuMtXFZUJBf48jUpeKPovT6FFEkAwO60';
        var url = "https://www.zipcodeapi.com/rest/" + clientKey + "/info.json/" + zipcode + "/radians";
        //1. create XHR object
        var xhr = new XMLHttpRequest();
        xhr.open('POST', url);
        xhr.onreadystatechange = function (e) {    //Call a function when the state changes.
            if (this.readyState == XMLHttpRequest.DONE && this.status == 200) {
                var result = xhr.responseText;
                if (result !== null || result !== "" || result !== undefined) {
                    if (result.charAt(0) === '"' && result.charAt(result.length - 1) === '"') {
                        result = result.substr(1, result.length - 2);
                    }
                    debugger;
                    locationPopulate(result);
                }
            }
     }
        xhr.send();
    }



