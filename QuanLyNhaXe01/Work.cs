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

        public bool insertWork(string workID, int workerID, string workName, string contain)
        {
            SqlCommand command = new SqlCommand("Insert INTO CongViec(MaCV, MaTho, TenCV, NoiDungCV) " +
                "Values(@workID, @workerID, @name, @contain)", mydb.getConnection);

            command.Parameters.Add("@workID", System.Data.SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workerID", System.Data.SqlDbType.Int).Value = workerID;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = workName;
            command.Parameters.Add("@contain", System.Data.SqlDbType.Text).Value = contain;
            
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

        public bool updateWork(string workID, int workerID, string workName, string contain)
        {
            SqlCommand command = new SqlCommand("UPDATE CongViec SET TenCV = @name, NoiDungCV = @contain WHERE MaCV = @workID, MaTho = @workerID", mydb.getConnection);

            command.Parameters.Add("@workID", System.Data.SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workerID", System.Data.SqlDbType.Int).Value = workerID;
            command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = workName;
            command.Parameters.Add("@contain", System.Data.SqlDbType.Text).Value = contain;

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
            SqlCommand command = new SqlCommand("DELETE FROM CongViec WHERE MaCV = @workID, MaTho = @workerID", mydb.getConnection);
            command.Parameters.Add("@workID", SqlDbType.VarChar).Value = workID;
            command.Parameters.Add("@workID", SqlDbType.Int).Value = workerID;

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
    }
}
