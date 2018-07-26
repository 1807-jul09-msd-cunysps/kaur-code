//var name = prompt("Please enter your Name");
//document.write("Welcome "+name);
//Datatypes: Number, String, undefined, null, boolean, object

//1. NUMBER 
//age = 18; // Global variables 

/* "use strict"
{// block scope
    debugger;// for debugging 
    var age = 18;
    age = "James";
    alert(age);// Javascript is untyped language 
    alert(typeof(age));
   // let age = 18;
}
alert(age);// Hoisting - var keyword allows but not allowed with let 
{
    alert(age);
}*/

// 2. String 
/*var name = "Kevin";
alert(`hello ${name.toUpperCase()}`);
*/
// undefined
//let dummy;
//alert(dummy);

//boolean
//let age = 18;
//let minor;
/*if (age >= 18) {
    minor = false;
}
else
    minor = true;
alert(minor);*/

//age >= 18 ? alert('you are not minor') : alert('you are minor');// conditional operator
//null
//let data = null;
//alert(typeof(dummy));
//alert(typeof(null));// object

// Type Conversion
/*debugger;
let data1 = "100";
let data2 = 200;
alert(Number(data1) + data2);
data2 = String(data2);
alert(typeof(data2));*/


//**************************FUNCTIONS*********************
//1. Declarative or named functions

/*Welcome();// Function Hoisting 
function Welcome() {
    var name = prompt("Please enter your Name ");
    alert(`Welcome ${name}`);
}*/
//Welcome();// Call the function
//2. FunctionExpression
/*var FuncExp = function Welcome() {
    var name = prompt("Please enter your Name ");
    alert(`Welcome ${name}`);
};
FuncExp();*/
//IIFE
/*(function Welcome() {
    var name = prompt("Please enter your Name ");
    alert(`Welcome ${name}`);
})();//IIFE*/
// Function returns a values
/*function Add(n1, n2=50) {
    return n1 + n2;
}
var result=Add('10');
alert(result);
*/
//alert("a"/5);//NaN

/*function Add(...params) {
    var temp=0;
    debugger;
    for (a in params) {
         temp += params[a];
    }
    return temp;
}
alert(Add(10, 15,45,465,789798));*/

// Function expression having Anonymous Functions
/*var wish = function () {
    alert('My pleasure');
};
wish();
*/
// IIFE with parameterised anonymous functions
/*(function (a,b) {
    alert(a+b);
})(12,15);*/
//Lambda Functions
//(parameters)=>computation
//((a, b) => alert(a+b))(10,45);// lambda IIFE
/*var add = (a, b) => alert(a + b);// lambda Funcrion expressions
add(10, 45);*/

// Function Constructor
/*var Multipy = new Function("x", "y", "alert(x*y);");
Multipy(4, 8);*/

// Callback function
/*function greeting(name) {
    alert('Hello ' + name);
}

function processUserInput(callback) {
    var name = prompt('Please enter your name.');
    callback(name);
}

processUserInput(greeting);
*/
// Closures
/*function Outer() {
    var outerData = "Hello CUNY-SPS-Rev";
    function Inner() {
        alert(outerData);
    }
    return Inner;
}
var func = Outer();
func();*/

// ARRAYS
//var countries = ["London", "USA", "India", "Denmark", "France"];
//alert(countries.length);
//for (var i = 0; i < countries.length; i++) {
//    alert(countries[i]);
//}
//for (var i in countries) {
//    alert(countries[i]);
//}
debugger;
//countries.push("China");
//alert(countries.length);

var countries = "London, USA, India, Denmark, France";
myarray = countries.split(",");

//Object
