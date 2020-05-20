using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Customer
    {
        MyDB mydb = new MyDB();

        public bool insertCustomer(string maKH, string ten, string CMND, string diachi, string sdt)
        {
            SqlCommand command = new SqlCommand("insert into KhachHang(MaKH, TenKH, CMND, DiaChi, SDT) " +
                " values(@id, @ten, @cmnd, @diachi, @sdt)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Char).Value = maKH;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;

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

        public bool updateCustomer(string maKH, string ten, string CMND, string diachi, string sdt)
        {
            SqlCommand command = new SqlCommand("update KhachHang set MaKH=@id, TenKH=@ten, CMND=@cmnd, DiaChi=@diachi, SDT=@sdt) ", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Char).Value = maKH;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;

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

        public bool deleteCustomer(string maKH)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KhachHang WHERE MaKH= @ma", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.Char).Value = maKH;

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

        public bool Check_Customer(string maKH)
        {
            SqlCommand command = new SqlCommand("Select * from KhachHang Where MaKH = @ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.Char).Value = maKH;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
