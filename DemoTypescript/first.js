console.log("Welcome to Typescript");
var firstname = 'Tom';
var age = 33;
console.log("Name=" + firstname);
console.log("Age=" + age);
var fno = 70;
var sno = 80;
var csno = '40';
// var result=fno+csno+sno
var result = fno + sno + csno;
console.log(result);
var fruits = ['Apple', 'Mango', 'Pear', 'Orange', 'Chikoo'];
for (var i = 0; i < fruits.length; i++) {
    console.log(fruits[i]);
}
function sayHello() {
    console.log('Hello World');
}
function multiply(a, b) {
    return a * b;
}
sayHello();
console.log(multiply(4, 5));
