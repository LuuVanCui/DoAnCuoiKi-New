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
    class Vehicle
    {
        MyDB mydb = new MyDB();

        //MaTheXe, LoaiXe,BienSo,NguoiGui,HieuXe,AnhXe,ThoiGianVao,Slot
        public bool insertCar(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream HieuXe,
                                     DateTime ThoiGianVao)
        {
            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,BienSo,HieuXe,ThoiGianVao)" +
                "Values(@ma,@loai,@bienso,@hieuxe,@time)", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@hieuxe", System.Data.SqlDbType.Image).Value = HieuXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

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


        public bool insertMoto(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream NguoiGui, DateTime ThoiGianVao)
        {
            
            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,BienSo,NguoiGui,ThoiGianVao)" +
                "Values(@ma,@loai,@bienso,@nguoigui,@time)", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

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

        public bool insertBike(string MaTheXe, string LoaiXe, MemoryStream NguoiGui,
                                    MemoryStream AnhXe, DateTime ThoiGianVao)
        {

            SqlCommand command = new SqlCommand("Insert INTO Xe(MaTheXe, LoaiXe,NguoiGui,AnhXe,ThoiGianVao)" +
                "Values(@ma,@loai,@nguoigui,@anhxe,@time)", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;

            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();

            command.Parameters.Add("@anhXe", System.Data.SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

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


        public bool updateCar(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream HieuXe,
                                    DateTime ThoiGianVao, MemoryStream AnhXe, MemoryStream NguoiGui)
        {
            SqlCommand command = new SqlCommand("UPDATE Xe SET  LoaiXe=@loai, BienSo= @bienso, HieuXe= @hieuxe,ThoiGianVao=@time, AnhXe=@anhxe, NguoiGui=@nguoigui " +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();

            command.Parameters.Add("@hieuxe", System.Data.SqlDbType.Image).Value = HieuXe.ToArray();

            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;
            command.Parameters.Add("@anhxe", SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@nguoigui", SqlDbType.Image).Value = NguoiGui.ToArray();

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

        public bool updateMoto(string MaTheXe, string LoaiXe, MemoryStream BienSo, MemoryStream NguoiGui, DateTime ThoiGianVao, MemoryStream HieuXe, MemoryStream AnhXe)
        {

            SqlCommand command = new SqlCommand("UPDATE Xe SET LoaiXe=@loai, BienSo= @bienso,NguoiGui= @nguoigui,ThoiGianVao=@time, HieuXe=@hieuxe, AnhXe=@anhxe " +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;
            command.Parameters.Add("@bienso", System.Data.SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;
            command.Parameters.Add("@hieuxe", SqlDbType.Image).Value = HieuXe.ToArray();
            command.Parameters.Add("@anhxe", SqlDbType.Image).Value = AnhXe.ToArray();

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

        public bool updateBike(string MaTheXe, string LoaiXe, MemoryStream NguoiGui,
                                   MemoryStream AnhXe, DateTime ThoiGianVao, MemoryStream BienSo, MemoryStream HieuXe)
        {

            SqlCommand command = new SqlCommand("UPDATE Xe SET  LoaiXe=@loai, NguoiGui= @nguoigui, AnhXe= @anhxe,ThoiGianVao=@time, BienSo=@bienso, HieuXe=@hieuxe " +
                "WHERE MaTheXe=@ma", mydb.getConnection);

            command.Parameters.Add("@ma", System.Data.SqlDbType.Char).Value = MaTheXe;
            command.Parameters.Add("@loai", System.Data.SqlDbType.NVarChar).Value = LoaiXe;

            command.Parameters.Add("@nguoigui", System.Data.SqlDbType.Image).Value = NguoiGui.ToArray();

            command.Parameters.Add("@anhXe", System.Data.SqlDbType.Image).Value = AnhXe.ToArray();
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = ThoiGianVao;

            command.Parameters.Add("@bienso", SqlDbType.Image).Value = BienSo.ToArray();
            command.Parameters.Add("@hieuxe", SqlDbType.Image).Value = HieuXe.ToArray();

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


        public DataTable getVehicle(SqlCommand cmd)
        {
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTypeVehicle()
        {
            SqlCommand cmd = new SqlCommand("SELECT LoaiXe FROM Slot");
            cmd.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteVehicle(string ma)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Xe WHERE MaTheXe=@ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = ma;

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

        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();

            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();

            return count;
        }

        public string totalVehicle()
        {
            return execCount("SELECT COUNT(*) FROM Xe");
        }

        public string totalMotorcycle()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe May' ");
        }
        public string totalCar()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe Hoi' ");
        }
        public string totalBicycle()
        {
            return execCount("SELECT COUNT(*) FROM Xe WHERE LoaiXe = 'Xe Dap' ");
        }
    }
}
