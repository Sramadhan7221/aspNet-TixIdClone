namespace AspNetFilmApp.Models;

class KelasBioskop
{
     public string Kelas {get; set;}
     public DateTime _jamTayang {get; set;}
     private int _hargaTiket {get; set;}

     public KelasBioskop(string kelas, int hargaTiket)
     {
          Kelas = kelas;
          _hargaTiket = hargaTiket;
     }

}