using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaXe01
{
    class Contract
    {
        MyDB mydb = new MyDB();

        public bool insert_table_HopDong(int soHD, string loaiHD, DateTime ngayKy, string maKH, string soXe, string moTaHD, double giaTriHD,
            DateTime NgayNhiemThu, double thanhToan, string trangthai)
        {
            SqlCommand command = new SqlCommand(" insert into HopDong(SoHD, LoaiHD, NgayKyHD, MaKH, SoXe, MoTaHD, GiaTriHD, NgayNhiemThu, ThanhToan,TrangThai) values(@id, @loai, " +
                "@ngayKy, @idKhach, @soXe, @mota, @gia, @nThu, @pay, @trangthai)", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = soHD;
            command.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loaiHD;
            command.Parameters.Add("@ngayKy", SqlDbType.DateTime).Value = ngayKy;
            command.Parameters.Add("@idKhach", SqlDbType.Char).Value = maKH;
            command.Parameters.Add("@soXe", SqlDbType.Char).Value = soXe;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = moTaHD;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaTriHD;
            command.Parameters.Add("@nThu", SqlDbType.DateTime).Value = NgayNhiemThu;
            command.Parameters.Add("@pay", SqlDbType.Float).Value = thanhToan;
            command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;

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

        public bool update_table_HopDong(int soHD, string loaiHD, DateTime ngayKy, string maKH, string soXe, string moTaHD, float giaTriHD,
            DateTime NgayNhiemThu, double thanhToan)
        {
            SqlCommand command = new SqlCommand(" update HopDong set LoaiHD=@loai, NgayKyHD=@ngayKy, MaKH=@idKhach, SoXe=@soXe," +
                " MoTaHD=@mota, GiaTriHD=@gia, NgayNhiemThu=@nThu, ThanhToan=@pay where soHD=@id ", mydb.getConnection);


            command.Parameters.Add("@id", SqlDbType.Int).Value = soHD;
            command.Parameters.Add("@loai", SqlDbType.NVarChar).Value = loaiHD;
            command.Parameters.Add("@ngayKy", SqlDbType.DateTime).Value = ngayKy;
            command.Parameters.Add("@idKhach", SqlDbType.Char).Value = maKH;
            command.Parameters.Add("@soXe", SqlDbType.Char).Value = soXe;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = moTaHD;
            command.Parameters.Add("@gia", SqlDbType.Float).Value = giaTriHD;
            command.Parameters.Add("@nThu", SqlDbType.DateTime).Value = NgayNhiemThu;
            command.Parameters.Add("@pay", SqlDbType.Float).Value = thanhToan;
         
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

        public bool delete_HopDong(int soHD)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HopDong WHERE SoHD= @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = soHD;

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

        public DataTable getTable(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public bool check_ID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * From HopDong Where SoHD = @id", mydb.getConnection);
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
