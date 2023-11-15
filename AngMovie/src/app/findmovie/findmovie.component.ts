import { Component, OnInit } from '@angular/core';
import { MovieService } from '../MovieService/movie.service';
import { IMovie } from '../model/imovie';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-findmovie',
  templateUrl: './findmovie.component.html',
  styleUrls: ['./findmovie.component.css']
})
export class FindmovieComponent implements OnInit {
  moviedata: IMovie
  id:number

  constructor(private movieservice:MovieService,private ar:ActivatedRoute) { }

  ngOnInit() {
    const tid=this
  }

}
