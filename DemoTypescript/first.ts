console.log("Welcome to Typescript")
var firstname:string='Tom'
var age:number=33
console.log("Name="+firstname)
console.log("Age="+age)
var fno:number=70
var sno:number=80
var csno:string='40'
// var result=fno+csno+sno
var result=fno+sno+csno
console.log(result)
var fruits:string[]=['Apple','Mango','Pear','Orange','Chikoo']
for(var i=0;i<fruits.length;i++)
{
    console.log(fruits[i])
}
function sayHello():void
{
    console.log('Hello World')
}
function multiply(a:number,b:number):number
{
    return a*b
}
sayHello()
console.log(multiply(4,5))