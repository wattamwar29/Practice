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
  emplist:Employee[]=[
    {id:132,name:'Tom',salary:40000,city:'Mumbai'},
    {id:133,name:'Jerry',salary:55000,city:'Pune'},
    {id:134,name:'Bob',salary:47000,city:'Delhi'},
    {id:135,name:'Jay',salary:60000,city:'Tirupati'},
    {id:136,name:'Vijay',salary:50000,city:'Tirumala'}
  ]
  constructor() { }

  ngOnInit() {
  }

}
