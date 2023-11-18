import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../service/movieservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-findmovie',
  templateUrl: './findmovie.component.html',
  styleUrls: ['./findmovie.component.css']
})
export class FindmovieComponent implements OnInit {

  constructor(private ms: MovieserviceService,private ar: ActivatedRoute,private router:Router) { }
  moviedata: IMovie
  id:number

  ngOnInit() {
    const tid=this.ar.snapshot.paramMap.get('id')
    this.id=Number(tid)
    this.ms.getMovie(this.id).subscribe((data:IMovie)=>{
      this.moviedata=data
    })
  }
Show(){
  this.router.navigate(['/listmovies'])
}
}
