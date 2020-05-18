using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class PriceAndSlot
    {
        public bool updatePriceAndSlot(string typeOfVehicle, float price, int slot)
        {
            MyDB mydb = new MyDB();
            SqlCommand command = new SqlCommand("update PhiGuiXeVaSlot set Phi = @price, Slot = @slot Where LoaiXe = @type", mydb.getConnection);

            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@slot", SqlDbType.NVarChar).Value = slot;
            command.Parameters.Add("@type", SqlDbType.VarChar).Value = typeOfVehicle;


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
