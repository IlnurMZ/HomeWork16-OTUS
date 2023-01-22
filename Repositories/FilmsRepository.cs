using Dapper;
using Npgsql;

namespace HomeWork16
{
    internal static class FilmsRepository
    {
        public static List<Film> GetFilms(int count)
        {
            var query = @" select
                film_id, title, release_year, length
                from film
                order by film_id asc
                limit @limit";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var list = connection.Query<Film>(query, new {limit=count});
                return list.ToList();
            }
        }

        public static Film GetFilmByTitle(string myTitle)
        {
            var query = @" select
                film_id, title, release_year, length
                from film
                where title =@title";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var film = connection.QueryFirstOrDefault<Film>(query, new { title = myTitle });
                return film;
            }
        }


    }
}