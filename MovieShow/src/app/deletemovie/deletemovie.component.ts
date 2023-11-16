import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../service/movieservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-deletemovie',
  templateUrl: './deletemovie.component.html',
  styleUrls: ['./deletemovie.component.css']
})
export class DeletemovieComponent implements OnInit {

  constructor(private ms:MovieserviceService,private route:Router,private ar: ActivatedRoute) { }
  moviedata: IMovie={id:0,name:'',yearrelease:0,rating:0}
  id:number

  ngOnInit() {
    const tid=this.ar.snapshot.paramMap.get('id')
    this.id=Number(tid)
    this.getMovie(this.id)
  }
  getMovie(id:number){
        this.ms.getMovie(id).subscribe((data:IMovie)=>this.moviedata=data)
      }
      saveData(movie:IMovie)
      {
        this.moviedata=movie
        this.ms.deleteMovie(this.moviedata.id).subscribe(()=>{
          alert("Record Deleted")
          this.route.navigate(['/listmovies'])
        })
      }

    }