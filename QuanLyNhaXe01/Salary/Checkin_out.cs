using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Checkin_out
    {
        MyDB mydb = new MyDB();

        public bool insert_Checkin(int MaTho, DateTime time_in)
        {
            SqlCommand command = new SqlCommand("insert into Luong(MaTho, checkin_time) values (@ma, @checkin)", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.Int).Value = MaTho;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = time_in;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool update_time_out(int MaTho, DateTime time_in, DateTime time_out)
        {
            SqlCommand command = new SqlCommand("update Luong set checkout_time = @time_out where MaTho = @ma and checkin_time = @time_in", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.Int).Value = MaTho;
            command.Parameters.Add("@time_in", SqlDbType.DateTime).Value = time_in;
            command.Parameters.Add("@time_out", SqlDbType.DateTime).Value = time_out;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
