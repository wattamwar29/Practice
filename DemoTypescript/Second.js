var Person = /** @class */ (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    Person.prototype.getname = function () {
        return this.name;
    };
    Person.prototype.getAge = function () {
        return this.age;
    };
    return Person;
}());
var person = new Person('Tom', 33);
console.log(person.getname());
console.log(person.getAge());
