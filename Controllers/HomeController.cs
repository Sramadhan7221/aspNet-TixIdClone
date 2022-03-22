using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetFilmApp.Models;

namespace AspNetFilmApp.Controllers;

public class HomeController : Controller
{
     List<Films> _listFilm = new List<Films>();
     private readonly ILogger<HomeController> _logger;

     public HomeController(ILogger<HomeController> logger)
     {
          _logger = logger;
          _listFilm = new List<Films>(){
            new Films("Ambulance(IMAX 2D)","Michael Bay","Jake Gyllenhaal, Yahya Abdul-Mateen II, Eiza Gonzalez, Garret Dillahunt, Devan Chandler Long, A Martinez, Andy Favreau ","Dua perampok membajak mobil ambulance setelah aksi perampokan mereka tidak berjalan sesuai rencana.","136","D17+"," Action, Crime, Drama"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/16474029723916_287x421.jpg"
            },new Films("Ambulance(3D)","Michael Bay","Jake Gyllenhaal, Yahya Abdul-Mateen II, Eiza Gonzalez, Garret Dillahunt, Devan Chandler Long, A Martinez, Andy Favreau ","Dua perampok membajak mobil ambulance setelah aksi perampokan mereka tidak berjalan sesuai rencana.","136","D17+"," Action, Crime, Drama"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164622271158748_287x421.jpg"
            },new Films("Bachchhan Paandey","Farhad Samji"," Akshay Kumar, Kriti Sanon, Arshad Warsi, Pankaj Tripathi, Jacqueline Fernandez ","Myra Devekar adalah calon sutradara yang diberi tugas untuk membuat film biografi gangster yang mencekam. Dia memutuskan untuk membuat film biografi tentang gangster kehidupan nyata! Memuaskan kebutuhan produser akan komersialisme dan rasa laparnya untuk membuat film yang realistis. Penelitiannya yang ekstensif hanya mengarah pada satu nama, yang paling mengancam, 'Bachchhan Paandey' bermata satu dari Baghwa. Myra mencoba yang terbaik untuk mencari tahu tentang dia, dengan bantuan seorang teman lama, untuk mengembangkan naskah film, tetapi gagal total dalam semua usahanya. Ketika dia akhirnya mendapat kesempatan untuk mendapatkan wawasan tentang kehidupan Bachchhan, dia akhirnya ditangkap oleh Bachchhan Paandey. Apa yang terjadi selanjutnya dalam twist cerita membawa kita pada perjalanan roller coaster. ","147","D17+","Action, Comedy, Crime"){
               LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164724781051638_287x421.jpg"
            },new Films("Jujutsu Kaisen 0","Sunghoo Park","Megumi Ogata, Kana Hanazawa, Mikako Komatsu, Koki Uchiyama, Tomokazu Seki, Yuichi Nakamura, Takahiro Sakurai","Yuta Okkotsu adalah seorang siswa SMA penyendiri yang mengalami masalah besar—teman masa kecilnya, Rika telah menjelma menjadi roh kutukan yang enggan lepas darinya. Karena Rika bukanlah roh kutukan biasa, keberadaan Yuta mendapat perhatian dari Satoru Gojo, seorang pengajar di SMA Jujutsu, sekolah bagi para pelajar ilmu gaib berlatih memerangi kutukan. Gojo meyakinkan Yuta untuk masuk sekolahnya, namun cukupkah pelajaran yang diperoleh Yuta ketika tiba waktunya harus berhadapan dengan kutukan yang mengikutinya?","105","R13+","Animasi"){
               LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164682762650173_287x421.jpg"
            },new Films("Marley","Denny Siregar","Tengku Tezi, Tyas Mirasih, Jason L.Theo. Emmie Lemu, Yadi Timo, Chika Waode Aden Bajaj, Isa Bajaj, Ricky Malau, Roni Gulung","Marley, seekor anjing bersahabat dengan Doni, guru matematika. Satu saat, Doni dipecat dari sekolah karena dia menerapkan sistem belajar yang berbeda. Akhirnya Doni membuka les matematika sendiri. Les yang awalnya sepi, akhirnya ramai. Disanalah Doni bertemu Vina dan muncul rasa suka diantara mereka berdua. Ketegangan terjadi ketika ada lomba matematika, Marley diculik oleh pedagang daging anjing. Bagaimana nasib Marley? Bisakah Doni menyelamatkan sahabatnya itu?","106","SU","Drama"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164664170961099_287x421.jpg"
            },new Films("Iblis dalam Kandungan","Adhe Dharmastriya","Nafa urbach, Denira Wiraguna, Ali Syakieb, Adhiyat, Inggrid Widjanarko, Ananda George, Anggia Chan, Ghea Micheo, Rendy Herpy, Yati surachman, Ian Darmawan, Farensa Thitania","Setelah 15 tahun menikah dan mengadopsi dua kakak beradik Alani (Denira Wiraguna) dan Vito (Adhiyat), Amelia (Nafa Urbach) mengalami kehamilan. Agar bisa menjaga istrinya yang juga menderita penyakit darah tinggi, Ferdi (Ali Syakieb) sang suami, pindah pekerjaan dari Jakarta ke perusahaan perkebunan di kaki gunung Salak.Persoalan muncul ketika rumah yang mereka tinggali ternyata dihuni oleh arwah seorang wanita yang dimasa lalunya kehilangan bayi didalam kandungannya karena sebuah peristiwa mistis. Kini arwah itu datang, mencoba merasuk kedalam tubuh Amelia untuk menghaki bayi didalam kandungannya. Vito dan Alani yang menyadari bahaya itu berupaya melindungi ibu mereka meskipun harus menghadapi teror yang membahayakan nyawa.Namun ternyata, arwah wanita itu bukanlah satu-satunya bahaya yang harus dihadapi. Ada kekuatan lain yang lebih jahat yang tidak pernah terpikirkan sebelumnya.","86","D+17","Horor"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164621881526152_287x421.jpg"
            },new Films("The Other Side","Girry Pratama","Davina Karamoy, Sandy Pradana, Pamela Bowie, Syakir Daulay, Cathy Fakandi, Bryan Andrew, Amel Carla, Emyr Razan, Rizky Fachrel, Wulan Guritno, Marcelino Lefrandt","Alea (Davina Karamoy) seorang remaja 16 tahun yang memutuskan untuk pindah dari Jakarta ke Bandung, karena ingin melupakan mantannya Reynand (Bryan Andrew) yang berselingkuh dengan sahabatnya sendiri. Alea masuk ke sekolah SMA Gempita. Alea yang ingin menyibukkan diri agar bisa lupa dengan Reynand, memutuskan masuk OSIS. Hari pertama penerimaan OSIS, Alea yang telat terburu-buru menuju ruang rapat menabrak Revo (Sandy Pradana). Alea terdiam ketika melihat sosok Revo begitu mirip dengan Reynand mantannya. Arya (Emyr Razan), ketua OSIS yang dikenal galak marah ke Alea karena telat, Arya meminta Alea memenuhi syarat mencari tanda tangan wakil ketua OSIS. Alea percaya diri bisa melakukan itu, tapi anggota OSIS lainnya Bella (Amel Carla) dan Vei (Cathy Fakandi) mengatakan bahwa sangat sulit. Karena wakil ketua OSIS mereka adalah idola semua murid wanita di sekolah Gempita.Alea dan Revo semakin dekat ketika membantu Revo membujuk ibunya, Cecil (Wulan Guritno) yang terkena penyakit amnesia disosiatif. Revo juga mulai jujur dengan hubungannya dengan ayahnya yang sangat buruk. Namun kedekatan mereka sedikit terganggu ketika Reynand datang menemui Alea dan mengajak Alea balikan. Dan juga ketika seorang wanita muncul, Reva (Pamela Bowie) adalah kekasih Revo yang baru saja pulang ke Bandung. Apa yang terjadi selanjutnya dengan kisah cinta Alea, Revo dan Reva. ","134","R+13","Drama,Romance"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164578073842205_287x421.jpg"
            },new Films("The Batman","Matt Reeves","Robert Pattinson, Zoe Kravitz, Andy Serkis, Colin Farrell, Paul Dano, Amber Sienna, Jeffrey Wright, Barry Keoghan, Peter Sarsgaard","Di tahun kedua memerangi kejahatan, Batman mengungkap korupsi besar di Gotham City yang menghubungkan keluarganya sendiri dan menghadapi pembunuh berantai yang dikenal sebagai Riddler.","176","R+13","Action, Crime, Drama"){
                LinkImg = "https://media.21cineplex.com/webcontent/gallery/pictures/164489949235572_287x421.jpg"
            },
        };
     }

     public IActionResult Index()
     {
          return View(_listFilm);
     }


     /// <summary>
     /// Page detail of tweet
     ///base_url/{Controller}/{method}/{username}
     /// </summary>
     /// <param name="username">id of user</param>
     /// <returns></returns>
     [Route("home/detail/{judul}")]

     public IActionResult Detail(string judul)
     {
          //  get data from film list by judul
          var data = _listFilm.Where(x => x.Judul != null && x != null && x.Judul.Contains(judul, StringComparison.OrdinalIgnoreCase)).ToList();

          return View(data);
     }
     public IActionResult Privacy()
     {
          return View();
     }

     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
     public IActionResult Error()
     {
          return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
     }
}
