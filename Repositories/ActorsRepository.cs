using Dapper;
using Npgsql;

namespace HomeWork16
{
    internal static class ActorsRepository
    {
        public static List<Actor> GetActors(int count)
        {
            var query = @" select
                actor_id, first_name, last_name
                from actor
                limit @limit";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var list = connection.Query<Actor>(query, new {limit = count});
                return list.ToList();
            }
        }

        public static Actor GetActorById(int actor_id)
        {
            var query = @" select
                actor_id, first_name, last_name
                from actor
                where actor_id =@id";

            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var actor = connection.QueryFirstOrDefault<Actor>(query, new { id = actor_id });
                return actor;
            }
        }


    }
}