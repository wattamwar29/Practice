﻿using Entity;
namespace DataLayer;

public class DataAccess
{
public static List<Movie> movie = new List<Movie>()
{
new Movie{Id=1,Name="Toofan",Ryear=2021,Ratings=3},
new Movie{Id=2,Name="Ludo",Ryear=2020,Ratings=4},
new Movie{Id=3,Name="Gunjan",Ryear=2020,Ratings=1},
new Movie{Id=4,Name="Big Bull",Ryear=2021,Ratings=3},
new Movie{Id=5,Name="Laxmi",Ryear=2020,Ratings=2},
};

public List<Movie> GetMovies()
{
    
    return movie;
}
}