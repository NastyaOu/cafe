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
    internal static class ShiftService
    {
        public static void CreateShiftsTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"shifts\" (\r\n\t\"id_shift\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"date\"\tTEXT NOT NULL UNIQUE,\r\n\t\"begin\"\tTEXT NOT NULL,\r\n\t\"end\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"id_shift\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<Shift> GetShifts()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "SELECT * FROM \"shifts\"";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        List<Shift> shifts = new List<Shift>();

                        while (reader.Read())
                        {
                            int id_shift = reader.GetInt32(0);
                            List<Staff> staff = GetShiftStaff(id_shift);
                            shifts.Add(new Shift(
                                id_shift,
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                staff));
                        }

                        return shifts;
                    }
                }
            }
        }

        public static List<Staff> GetShiftStaff(int id_shift)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"SELECT \"staff\".*\r\nFROM \"shifts-staff\"\r\nLEFT JOIN \"staff\" ON \"shifts-staff\".\"id_staff\"=\"staff\".\"id_staff\"\r\nWHERE \"shifts-staff\".\"id_shift\"={id_shift}";

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

        public static void CreateShift(Shift shift)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"shifts\"\r\n(\"date\", \"begin\", \"end\")\r\nVALUES ('{shift.date}', '{shift.begin}', '{shift.end}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
