import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindmovieComponent } from './findmovie/findmovie.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';
import { ReactFormComponent } from './reactform/reactform.component';
import { CreatedetailsComponent } from './createdetails/createdetails.component';
import { AuthService } from './service/auth.service';
import { AuthGuard } from './guard/auth.guard';

const routes: Routes = [
  {path:'listmovies',component:ListmovieComponent,canActivate:[AuthGuard]},
  {path:'find/:id',component:FindmovieComponent},
  {path:'add',component:AddMovieComponent},
  {path:'edit/:id',component:EditmovieComponent},
  {path:'delete/:id',component:DeletemovieComponent},
  {path:'reactform',component:ReactFormComponent},
  {path:'details',component:CreatedetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
