using System;
using System.Net.Http;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meklēt filmu: ");
            string title = Console.ReadLine();

            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");

                var result = client.GetAsync(String.Format("?apikey=18328d22&s={0}", title)).Result;
                if(result.IsSuccessStatusCode)
                {
                    var movies = result.Content.ReadAsAsync<SearchResult>().Result;
                    
                    if(movies.Search != null)
                    {
                        foreach (var movie in movies.Search)
                        {
                            Console.WriteLine("{0} {1}", movie.Year, movie.Title);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Filma nav atrasta!");
                    }
                }
                else
                {
                    Console.WriteLine("Filmu DB nav pieejama!");
                }
            }

            Console.Read();
        }
    }
}
