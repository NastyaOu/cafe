using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.Services
{
    internal static class ShiftStaffService
    {
        public static void CreateShiftsStaffTable()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = "CREATE TABLE IF NOT EXISTS \"shifts-staff\" (\r\n\t\"id_shift_staff\"\tINTEGER NOT NULL UNIQUE,\r\n\t\"id_staff\"\tINTEGER NOT NULL,\r\n\t\"id_shift\"\tINTEGER NOT NULL,\r\n\tFOREIGN KEY(\"id_staff\") REFERENCES \"staff\"(\"id_staff\"),\r\n\tPRIMARY KEY(\"id_shift_staff\" AUTOINCREMENT)\r\n)";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteShiftStaff(int id_shift)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"DELETE FROM \"shifts-staff\" WHERE \"id_shift\"='{id_shift}'";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateStaffShift(int id_staff, int id_shift)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=Cafe.db"))
            {
                connection.Open();

                string sql = $"INSERT INTO \"shifts-staff\"\r\n(\"id_staff\", \"id_shift\")\r\nVALUES ('{id_staff}', '{id_shift}');";

                using (SqliteCommand command = new SqliteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
