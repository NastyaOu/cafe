using cafe.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe.Services
{
    internal static class StaffService
    {
        public static Staff Authorization(string login, string password)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"SELECT * FROM \"staff\" WHERE \"login\" = \"{login}\" AND \"password\" = \"{password}\" AND  \"status\" != \"Уволен\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Staff staff = new Staff(
                                reader.GetInt32(0), 
                                reader.GetString(1), 
                                reader.GetString(2), 
                                reader.GetString(3), 
                                reader.GetString(4), 
                                reader.GetString(5), 
                                reader.GetString(6), 
                                reader.GetString(7)
                                );

                            return staff;
                        }

                        return null;
                    }
                }
            }
        }

        public static void CreateStaffTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"staff\" (\r\n\t\"id_staff\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"last_name\"\tTEXT NOT NULL,\r\n\t\"name\"\tTEXT NOT NULL,\r\n\t\"patronymic\"\tTEXT,\r\n\t\"position\"\tTEXT NOT NULL CHECK((\"position\"=\"Администратор\") || (\"position\"=\"Повар\") || (\"position\"=\"Официант\")),\r\n\t\"login\"\tTEXT NOT NULL UNIQUE,\r\n\t\"password\"\tTEXT NOT NULL,\r\n\t\"status\"\tTEXT NOT NULL CHECK((\"status\"=\"Работает\") || (\"status\"=\"Уволен\")),\r\n\tPRIMARY KEY(\"id_staff\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateStaff(Staff staff)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"staff\"\r\n(\"last_name\", \"name\", \"patronymic\", \"position\", \"login\", \"password\", \"status\")\r\nVALUES ('{staff.last_name}', '{staff.name}', '{staff.patronymic}', '{staff.position}', '{staff.login}', '{staff.password}', '{staff.status}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateStaff(Staff staff)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"UPDATE \"staff\"\r\nSET \"last_name\" = '{staff.last_name}', \"name\" = '{staff.name}', \"patronymic\" = '{staff.patronymic}', \"position\" = '{staff.position}', \"login\" = '{staff.login}', \"password\" = '{staff.password}', \"status\" = '{staff.status}' \r\nWHERE \"id_staff\" = {staff.id_staff};";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Staff> GetStaff()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"staff\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Staff> staff = new List<Staff>();

                        while (reader.Read())
                        {
                            staff.Add(new Staff(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6),
                                reader.GetString(7)
                                ));
                        }

                        return staff;
                    }
                }
            }
        }
    }
}
