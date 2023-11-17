import { Component, OnInit } from '@angular/core';
import { IMovie } from '../model/imovie';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MovieserviceService } from '../service/movieservice.service';
 
@Component({
  selector: 'app-reactform',
  templateUrl: './reactform.component.html',
  styleUrls: ['./reactform.component.css']
})
export class ReactFormComponent implements OnInit {
  moviedata: IMovie
 
 
  constructor(private fb:FormBuilder, private ms: MovieserviceService, private route: Router) { }
  movieform = this.fb.group({
    name: ['',Validators.required],
    yearrelease: ['',[Validators.min(2000), Validators.max(2023)]],
    rating: ['',[Validators.required, Validators.min(1), Validators.max(5)]]
  })
  saveData(): void{
    this.moviedata = this.movieform.value
    if(this.moviedata.rating > 5){
      alert('error in rating')
      return
    }
    console.log(this.moviedata)
    this.ms.addMovie(this.moviedata).subscribe(
      ()=>{
        alert("Record added")
        this.route.navigate(['/listmovies'])
 
      }
    )
  }
  ngOnInit() {
  }
 
}