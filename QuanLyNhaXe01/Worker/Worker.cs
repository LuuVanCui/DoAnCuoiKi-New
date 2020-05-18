using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyNhaXe01

{
    class Worker
    {
        MyDB mydb = new MyDB();
        public bool insertWorker(int w_id, string name, string sex, string phone, string identity,string address, DateTime bDate, DateTime dateStart, string work)
        {
            SqlCommand command = new SqlCommand("insert into Tho(MaTho, TenTho, GioiTinh, CMND, NgaySinh, DiaChi, SDT, Nhom, NhomTruong, NgayBatDau) " +
                "values(@wid,@name,@sex,@identity,@bDate,@dStart,@phone,@address,@work)", mydb.getConnection);

            command.Parameters.Add("@wid", SqlDbType.Int).Value = w_id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@identity", SqlDbType.NVarChar).Value = identity;
            command.Parameters.Add("@bDate", SqlDbType.DateTime).Value = bDate;
            command.Parameters.Add("dStart", SqlDbType.DateTime).Value = dateStart;
            command.Parameters.Add("@work", SqlDbType.NVarChar).Value = work;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            

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

        public bool updateWorker(int w_id, string name, string sex, string phone, string identity,string address, DateTime bDate, DateTime dateStart, string work)
        {
            SqlCommand command = new SqlCommand("update Worker set worker_id = @wid, name=@name, sex = @sex, identityCard= @identity,bDate= @bDate, dateStart= @dStart, phone = @phone, address = @address, work=@work Where worker_id = @wid", mydb.getConnection);

            command.Parameters.Add("@wid", SqlDbType.Int).Value = w_id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@identity", SqlDbType.NVarChar).Value = identity;
            command.Parameters.Add("@bDate", SqlDbType.DateTime).Value = bDate;
            command.Parameters.Add("dStart", SqlDbType.DateTime).Value = dateStart;
            command.Parameters.Add("@work", SqlDbType.NVarChar).Value = work;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;


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

        public bool deleteWorker(int W_id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Worker WHERE worker_id=@id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = W_id;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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

        public DataTable getWorker(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            mydb.openConnection();

            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();

            return count;
        }

        public string totalWorker()
        {
            return execCount("Select count * from Worker");
        }

        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * From Worker Where Worker_id = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
