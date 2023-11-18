import { Component, OnInit } from '@angular/core';
import { Idetails } from '../model/idetails';
import { MovieserviceService } from '../service/movieservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-createdetails',
  templateUrl: './createdetails.component.html',
  styleUrls: ['./createdetails.component.css']
})
export class CreatedetailsComponent implements OnInit {
  detailsdata:Idetails = {detailid:0,actor:'',movieid:0,gender:'',role:''}
  showdata: any[]=[]

  constructor(private ms: MovieserviceService,private router : Router) {

   }
   saveData(data:Idetails):void{
    this.ms.addDetails(this.detailsdata).subscribe(
      ()=>{
        alert('Record Added Successfully')
        this.router.navigate(['/listmovies'])
      }
    )
   }

  ngOnInit() {
    this.ms.getAllMovies().subscribe(data=>{this.showdata.push(...data)})
  }

}
