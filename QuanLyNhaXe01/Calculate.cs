using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Calculate
    {

        MyDB mydb = new MyDB();
        public DataTable getData(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public (float, float) parkingFeeAndFine(string LoaiXe, string HinhThucGui, TimeSpan ThoiGianGui)
        {
            Calculate calculate = new Calculate();
            DataTable table = calculate.getData(new SqlCommand("SELECT * FROM PhiGuiXe"));
            float cost;

            if (LoaiXe == "Xe Dap")
            {
                if (HinhThucGui == "For Hour")
                {
                    cost = float.Parse(table.Rows[1][2].ToString());
                }    
                
                if (ThoiGianGui.Hours <= 24)
                {
                    return ();
                }    
            }    
        }
    }
}
