using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using wishApp.Model;

namespace wishApp.DAO
{
    public class WishDAO : IWishDAO
    {
        private static readonly string conn_string = @"Data Source=../../../DB/wishes.db;";
        public bool AddWish(WishModel wishModel)
        {
            using SqliteConnection conn = new SqliteConnection(conn_string);
            conn.Open();

            SqliteCommand command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO wishes (name, age, wish, amount) VALUES (@name, @age, @wish, @amount)";

            command.Parameters.AddWithValue("@name", wishModel.Name);
            command.Parameters.AddWithValue("@age", wishModel.Age);
            command.Parameters.AddWithValue("@wish", wishModel.Wish);
            command.Parameters.AddWithValue("@amount", wishModel.Amount);

            if (command.ExecuteNonQuery() != 1) return false;
            
            return true;
        }

        public WishModel GetWish(int id)
        {
            WishModel model = new WishModel();
            using SqliteConnection conn = new SqliteConnection(conn_string);
            conn.Open();

            SqliteCommand command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM wishes WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            using SqliteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                model.ID = reader.GetInt32(0);
                model.Name = reader.GetString(1);
                model.Age = reader.GetInt32(2);
                model.Wish = reader.GetString(3);
                model.Amount = reader.GetInt32(4);
            }
            return model;
        }

        public List<WishModel> GetWishModels()
        {
            List<WishModel> models = new List<WishModel>();
            using SqliteConnection conn = new SqliteConnection(conn_string);
            conn.Open();

            SqliteCommand command = conn.CreateCommand();
            command.CommandText = @"SELECT * FROM wishes";

            using SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                WishModel model = new WishModel();
                model.ID = reader.GetInt32(0);
                model.Name = reader.GetString(1);
                model.Age = reader.GetInt32(2);
                model.Wish = reader.GetString(3);
                model.Amount = reader.GetInt32(4);
                models.Add(model);
            }

            return models;
        }
    }
}
