using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AspNetFilmApp.Models;

public class FilmViewModel
{
     [DisplayName("Judul Film")]
     [Required]
     public string Judul { get; set; }
     public string Genre { get; set; }
     public string Sutradara { get; set; }
     public string Aktor { get; set; }
     public string Sinopsis { get; set; }
     public string Durasi { get; set; }
     [DisplayName("Rating Umur")]
     public string RatingUsia { get; set; }
     [DisplayName("Poster")]
     public string LinkImg { get; set; }
     public float _rating { get; set; }
     [DisplayName("Link Trailer")]
     public string LinkTrailer { get; set; }
     [DisplayName("Tanggal Tayang")]
     public DateTime TglTayang { get; set; }
     public FilmViewModel()
     {

     }

     public FilmViewModel(string judul, string sutradara, string aktor, string sinopsis, string durasi, string ratingUsia, string genre)
     {
          Judul = judul;
          Sutradara = sutradara;
          Aktor = aktor;
          Sinopsis = sinopsis;
          Durasi = durasi;
          RatingUsia = ratingUsia;
          Genre = genre;
     }

     public void SetRating(float rating)
     {
          this._rating = rating;
     }
}