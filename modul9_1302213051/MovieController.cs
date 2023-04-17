using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace modul9_1302213051
{
    //Route digunakan untuk mendefinisikan MovieController dengan dua attribute yaitu:
    [Route("api/[controller]")] //attribute yang menentukan route endpoint
    [ApiController] //route yang memungkinkan beberapa fitur bawaan pada web API
    public class MovieController : ControllerBase
    {
        //List<Movie> menampung data static dari film yang berasal dari TOP Film IMDB
        public static List<Movie> movies = new List<Movie>
        {
            new Movie ("The Shawshank Redemption", "Frank Darabont", new List<string>{"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler"},
                "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie ("The Godfather", "Francis Ford Coppola", new List<string>{"Al Pacino", "Marlon Brando", "James Caan", "Diane Keaton"},
                "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie ("The Dark Knight", "Christopher Nolan", new List<string>{"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"},
                "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."),
        };

        //Mendefinisikan GET yang akan mengembalikan data
        //yang ada di dalam list movies dengan method Get()
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }


        //Mendefinisikan GET dengan parameter "id" yang akan
        //mengembalikan salah satu data Movie dengan id tertentu
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movies[id];
        }

        //Mendefinisikan endpoint POST yang menambahkan data Movie baru
        //dan  data tersebut akan disimpan di list movies dengan method movies.Add(mvs)
        [HttpPost]
        public void Post(Movie mvs)
        {
            movies.Add(mvs);
        }

        //Mendefinisikan endpoint DELETE yang menghapus data Movies
        //dengan id tertentu dari list movies dengan method movies.RemoveAt(id)
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movies.RemoveAt(id);
        }
    }
}
