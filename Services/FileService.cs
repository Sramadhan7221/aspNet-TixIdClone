using AspNetFilmApp.Models;

namespace AspNetFilmApp.Services
{
     public class FileService : IFileService
     {
          private const string FILE_NAME = "_dataFilm.txt";
          public async Task<List<FilmViewModel>> Read()
          {
               if (!File.Exists(System.AppContext.BaseDirectory + FILE_NAME))
               {
                    return new List<FilmViewModel>();
               }
               var res = await File.ReadAllLinesAsync(System.AppContext.BaseDirectory + FILE_NAME);
               if (res == null)
               {
                    return new List<FilmViewModel>();
               }

               List<FilmViewModel> film = new List<FilmViewModel>();
               foreach (var item in res)
               {
                    var dataSplit = item.Split("|").ToArray();
                    film.Add(new FilmViewModel(dataSplit[0], dataSplit[1], dataSplit[2], dataSplit[3], dataSplit[4], dataSplit[5], dataSplit[6])
                    {
                         LinkImg = dataSplit[7],
                         LinkTrailer = dataSplit[8],
                         TglTayang = Convert.ToDateTime(dataSplit[9])
                    });
               }

               return film;
          }

          public async Task Write(FilmViewModel request)
          {
               if (!File.Exists(System.AppContext.BaseDirectory + FILE_NAME))
               {
                    using (var fileStream = File.Create(System.AppContext.BaseDirectory + FILE_NAME))
                    {
                         fileStream.Close();
                    }
               }
               using (var fileStream = File.AppendText(System.AppContext.BaseDirectory + FILE_NAME))
               {
                    await fileStream.WriteLineAsync($"{request.Judul}|{request.Sutradara}|{request.Aktor}|{request.Sinopsis}|{request.Durasi}|{request.RatingUsia}|{request.Genre}|{request.LinkImg}|{request.LinkTrailer}|{request.TglTayang}");
               }
          }
     }
}
