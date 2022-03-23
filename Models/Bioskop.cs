namespace AspNetFilmApp.Models;

class Bioskop
{
     public int Id {get; set;}
     public string NamaBioskop {get; set;}
     public KelasBioskop Kelas {get; set;}
     public string Alamat {get; set;}
     public Bioskop(int id, string namaBioskop, string alamat)
     {
          if (id == 0)
               Id = new Random().Next();
          else
               Id = id;

          NamaBioskop = namaBioskop;
          Alamat = alamat;
     }

     public void KelasTersedia (KelasBioskop kelas){
          Kelas = kelas;
     }
}