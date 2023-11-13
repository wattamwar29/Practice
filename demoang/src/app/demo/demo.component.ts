import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  name:string = 'Tom'
  age:number = 13
 
  fno:number = 30
  sno:number = 40
  tno:number = 50
  Sum():number{
    return this.fno+this.sno
  }
  Show():void{
    alert("Name is " + this.name + " and age is " + this.age)
  }

  constructor() { }

  ngOnInit() {
  }

}
