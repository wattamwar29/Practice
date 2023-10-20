namespace BzLayer;
using DataLayer;
using Entity;
public class MovieBz
{
    public List<Movie> GetMovies()
    {
        DataAccess dataAccess = new DataAccess();
        return dataAccess.GetMovies();
    }
}
