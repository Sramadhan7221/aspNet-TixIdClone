using AspNetFilmApp.Models;

namespace AspNetFilmApp.Services
{
     public interface IFileService
     {
          Task<List<FilmViewModel>> Read();
          Task Write(FilmViewModel request);
     }
}
