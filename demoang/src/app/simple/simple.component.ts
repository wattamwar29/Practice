import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-simple',
  templateUrl: './simple.component.html',
  styleUrls: ['./simple.component.css']
})
export class SimpleComponent implements OnInit {
  weekdays:string[]=['Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday']
  age:number=26
  emp:Employee={id:132,name:'Tom',salary:40000,city:'Mumbai'}
  constructor() { }

  ngOnInit() {
  }

}
