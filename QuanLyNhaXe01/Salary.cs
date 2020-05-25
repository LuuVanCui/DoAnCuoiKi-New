using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Salary
    {
        public bool updateSalary(string workerType, float salary)
        {
            MyDB mydb = new MyDB();
            SqlCommand command = new SqlCommand("update MucLuong set Luong = @luong Where LoaiTho = @type", mydb.getConnection);

            command.Parameters.Add("@luong", SqlDbType.Float).Value = salary;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = workerType;


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
