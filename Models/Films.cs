namespace AspNetFilmApp.Models;

class Films
{
     public string Judul { get; set; }
     public string Genre { get; set; }
     public string Sutradara { get; set; }
     public string Aktor { get; set; }
     public string Sinopsis { get; set; }
     public string Durasi { get; set; }
     public string RatingUsia { get; set; }
     public string LinkImg { get; set; }
     private float _rating { get; set; }

     public Films(string judul, string sutradara, string aktor, string sinopsis, string durasi, string ratingUsia, string genre)
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