using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySchedule
{
    internal class AssignmentDatabase
    {
        //เชื่อมกับไฟล์ database ในโฟลเดอร์ bin (Assignment.db)
        private static string connectionString = "Data Source=Assignment.db;Version=3;";

        //เมธอดสำหรับเชืื่อมต่อเข้ากับ database
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        //เมธอดสำหรับแสดงข้อมูลจาก database
        public static DataTable ExecuteQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query,conn))
                {
                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        //เมธอดสำหรับป้อมข้อมูลเข้า database
        public static void ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query,conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
