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
    internal static class OrderService
    {
        public static void CreateOrdersTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"orders\" (\r\n\t\"id_order\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"table\"\tNUMERIC NOT NULL,\r\n\t\"number_of_clients\"\tNUMERIC NOT NULL,\r\n\t\"structure\"\tTEXT NOT NULL,\r\n\t\"status\"\tTEXT NOT NULL CHECK((\"status\" = \"Принят\") || (\"status\" = \"Готовится\") || (\"status\" = \"Готов\") || (\"status\" = \"Оплачен\")),\r\n\t\"date\"\tTEXT NOT NULL DEFAULT '01.01.1970',\r\n\t\"time\"\tTEXT NOT NULL DEFAULT '00:00:00',\r\n\tPRIMARY KEY(\"id_order\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateOrder(Order order)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"orders\"\r\n(\"table\", \"number_of_clients\", \"structure\", \"status\", \"date\", \"time\")\r\nVALUES ('{order.table}', '{order.number_of_clients}', '{order.structure}', '{order.status}', '{order.date}', '{order.time}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Order> GetOrders()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"orders\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Order> orders = new List<Order>();

                        while (reader.Read())
                        {
                            
                            orders.Add(new Order(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6)));
                        }

                        return orders;
                    }
                }
            }
        }

        public static List<Order> GetActiveOrders()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                DateTime dateTime = DateTime.Now;
                string date = dateTime.Date.ToShortDateString();
                string hours = "";

                if (dateTime.TimeOfDay.Hours < 10)
                {
                    hours = "0";
                }

                hours += dateTime.TimeOfDay.Hours.ToString();

                string minutes = "";

                if (dateTime.TimeOfDay.Minutes < 10)
                {
                    minutes = "0";
                }

                minutes += dateTime.TimeOfDay.Minutes.ToString();

                string time = $"{hours}:{minutes}";

                string sql = $"SELECT \"orders\".* FROM \"shifts\" JOIN \"orders\" ON \"orders\".\"date\" = \"shifts\".\"date\" AND \"orders\".\"time\" >= \"shifts\".\"begin\" AND \"orders\".\"time\" <= \"shifts\".\"end\" WHERE \"shifts\".\"date\" = '{date}' AND \"shifts\".\"begin\" <= '{time}' AND \"shifts\".\"end\" >= '{time}'";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Order> orders = new List<Order>();

                        while (reader.Read())
                        {
                            orders.Add(new Order(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetString(5),
                                reader.GetString(6)));
                        }

                        return orders;
                    }
                }
            }
        }

        public static void UpdateOrder(Order order)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"UPDATE \"orders\"\r\nSET \"table\" = '{order.table}', \"number_of_clients\" = '{order.number_of_clients}', \"structure\" = '{order.structure}', \"status\" = '{order.status}', \"date\" = '{order.date}', \"time\" = '{order.time}'\r\nWHERE \"id_order\" = {order.id_order};";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
