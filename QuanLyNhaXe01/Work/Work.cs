using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Work
    {
        MyDB mydb = new MyDB();

        public bool insertWork(string workID, int workerID, string workName, string contain, int groupID)
        {
            SqlCommand command = new SqlCommand("Insert INTO CongViec(MaCV, MaTho, TenCV, NoiDungCV, MaNhom) " +
                "Values(@workID, @workerID, @name, @contain, @groupID)", mydb.getConnection);

            command.Parameters.Add("@workID", System.Data.SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workerID", System.Data.SqlDbType.Int).Value = workerID;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = workName;
            command.Parameters.Add("@contain", System.Data.SqlDbType.Text).Value = contain;
            command.Parameters.Add("@groupID", System.Data.SqlDbType.Int).Value = groupID;

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

        public bool updateWork(string workID, int workerID, string workName, string contain, int groupID)
        {
            SqlCommand command = new SqlCommand("UPDATE CongViec SET TenCV = @name, NoiDungCV = @contain, MaNhom = @groupID WHERE MaCV = @workID and MaTho = @workerID", mydb.getConnection);

            command.Parameters.Add("@workID", System.Data.SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workerID", System.Data.SqlDbType.Int).Value = workerID;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = workName;
            command.Parameters.Add("@contain", System.Data.SqlDbType.Text).Value = contain;
            command.Parameters.Add("@groupID", System.Data.SqlDbType.Int).Value = groupID;

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

        public bool deleteWork(string workID, int workerID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CongViec WHERE MaCV = @workID and MaTho = @workerID", mydb.getConnection);
            command.Parameters.Add("@workID", SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workerID", SqlDbType.Int).Value = workerID;

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


        public DataTable getWork()
        {

            MyDB mydb = new MyDB();
            SqlCommand command = new SqlCommand("Select * From CongViec", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}
