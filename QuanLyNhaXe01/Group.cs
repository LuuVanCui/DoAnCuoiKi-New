using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Group
    {
        MyDB mydb = new MyDB();

        public bool insertGroup(int groupID, string groupName)
        {
            SqlCommand command = new SqlCommand("Insert INTO Nhom(MaNhom, TenNhom) " +
                "Values(@MaNhom, @TenNhom)", mydb.getConnection);

            command.Parameters.Add("@MaNhom", System.Data.SqlDbType.Int).Value = groupID;
            command.Parameters.Add("@TenNhom", System.Data.SqlDbType.NVarChar).Value = groupName;

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

        public bool updateGroup(int groupID, string groupName)
        {
            SqlCommand command = new SqlCommand("UPDATE Nhom SET TenNhom = @TenNhom WHERE MaNhom = @MaNhom", mydb.getConnection);

            command.Parameters.Add("@MaNhom", System.Data.SqlDbType.Int).Value = groupID;
            command.Parameters.Add("@TenNhom", System.Data.SqlDbType.NVarChar).Value = groupName;

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

        public bool deleteGroup(int groupID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Nhom WHERE MaNhom = @MaNhom", mydb.getConnection);
            command.Parameters.Add("@MaNhom", System.Data.SqlDbType.Int).Value = groupID;

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
