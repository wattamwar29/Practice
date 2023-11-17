import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';
import { ReactformComponent } from './reactform/reactform.component';


const routes: Routes = [
  {path:'listmovies',component:ListmovieComponent},
  {path:'find/:id',component:FindmovieComponent},
  {path:'add',component:AddMovieComponent},
  {path:'edit/:id',component:EditmovieComponent},
  {path:'delete/:id',component:DeletemovieComponent},
  {path:'reactform',component:ReactformComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
