using AspNetFilmApp.Models;
namespace AspNetFilmApp.Services
{
     public interface IFilmService{
          List<FilmViewModel> GetFilm();
          int Add(FilmViewModel request);
     }
}