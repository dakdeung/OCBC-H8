using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace MovieApp.Models
{
    public class MovieContext
    {
        public string ConnectionString { get; set; }

        public MovieContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MovieData> GetAllMovie()
        {
            List<MovieData> list = new List<MovieData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }

            }
            return list;
        }

        public List<MovieData> GetMovie(string id)
        {
            List<MovieData> list = new List<MovieData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movie WHERE id =@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
                return list;
            }
        }

        public List<MovieData> PostMovie(MovieData data)
        {
            List<MovieData> list = new List<MovieData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `movie` (`Name`, `Genre`, `Duration`, `ReleaseDate`) VALUES ('"+data.Name+"','"+data.Genre+"','"+data.Duration+"','"+data.ReleaseDate+"');", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
                return list;
            }
        }

        public List<MovieData> PutMovie(MovieData data, string id)
        {
            List<MovieData> list = new List<MovieData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("Update `movie` SET `Name` = '"+ data.Name+"', `Genre` = '"+ data.Genre+"', `Duration` = '"+ data.Duration+"', `ReleaseDate` = '"+ data.ReleaseDate+"' WHERE movie.id = '"+ id+"';", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            id = reader.GetInt32("id"),
                            Name = reader.GetString("name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
                return list;
            }
        }

        public List<MovieData> DeleteMovie(string id)
        {
            List<MovieData> list = new List<MovieData>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("DELETE FROM `movie` WHERE movie.id = '"+ id+"';", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MovieData()
                        {
                            id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetString("ReleaseDate")
                        });
                    }
                }
                return list;
            }
        }

    }
}