namespace HomeWork16
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Запрос {0}: Вывод актеров", 1);
            var actors = ActorsRepository.GetActors(5);
            foreach (var actor in actors)
                Console.WriteLine($"{actor.Actor_id}\t:{actor.First_name} {actor.Last_name}");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Запрос {0}: Вывод информации об актере по его id", 2);
            var actor2 = ActorsRepository.GetActorById(1);
            Console.WriteLine($"{actor2.Actor_id}\t:{actor2.First_name} {actor2.Last_name}");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Запрос {0}: Вывод фильмов", 3);
            var films = FilmsRepository.GetFilms(6);
            foreach (var film in films)
                Console.WriteLine($"{film.Film_id}\t:{film.Title} {film.Release_year} {film.Length}");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Запрос {0}: Вывод информации о фильме по названию", 4);
            var film2 = FilmsRepository.GetFilmByTitle("Alone Trip");
            Console.WriteLine($"{film2.Film_id}\t:{film2.Title} {film2.Release_year} {film2.Length}");
            Console.WriteLine("--------------------------");

            Console.ReadKey();
        }
    }
}
