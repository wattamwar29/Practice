import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-simple',
  templateUrl: './simple.component.html',
  styleUrls: ['./simple.component.css']
})
export class SimpleComponent implements OnInit {
  weekdays:string[]=['Sunday','Monday','Tuesday','Wednesday','Thursday','Friday','Saturday']

  constructor() { }

  ngOnInit() {
  }

}
