﻿using System;
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
        public bool insertWorker(int maTho, string name, string sex, string CMND, DateTime ngaysinh,string address, string sdt, int maNhom, string maCV, DateTime dateStart)
        {
            SqlCommand command = new SqlCommand("insert into Tho(MaTho, TenTho, GioiTinh, CMND, NgaySinh, DiaChi, SDT, MaNhom, MaCV, NgayBatDau) " +
                "values(@wid,@name,@sex,@identity,@bDate,@address,@phone, @maNhom, @maCV, @dStart)", mydb.getConnection);

            command.Parameters.Add("@wid", SqlDbType.Int).Value = maTho;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@identity", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@bDate", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("dStart", SqlDbType.DateTime).Value = dateStart;
           
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;

            command.Parameters.Add("@maNhom", SqlDbType.Int).Value = maNhom;
            command.Parameters.Add("@maCV", SqlDbType.VarChar).Value = maCV;


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

        public bool updateWorker(int maTho, string name, string sex, string CMND, DateTime ngaysinh, string address, string sdt, int maNhom, string maCV, DateTime dateStart)
        {
            SqlCommand command = new SqlCommand("update Tho set TenTho=@name, GioiTinh=@sex, CMND=@identity, NgaySinh=@bDate, DiaChi=@address, SDT=@phone, MaNhom= @maNhom, MaCV=@maCV,NgayBatDau=@dStart where MaTho=@wid  ", mydb.getConnection);

            command.Parameters.Add("@wid", SqlDbType.Int).Value = maTho;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sex", SqlDbType.VarChar).Value = sex;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@identity", SqlDbType.VarChar).Value = CMND;
            command.Parameters.Add("@bDate", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("dStart", SqlDbType.DateTime).Value = dateStart;
           
            command.Parameters.Add("@address", SqlDbType.Text).Value = address;

            command.Parameters.Add("@maNhom", SqlDbType.Int).Value = maNhom;
            command.Parameters.Add("@maCV", SqlDbType.VarChar).Value = maCV;


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

        public bool deleteWorker(int maTho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Tho WHERE MaTho= @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = maTho;

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
            return execCount("Select count * from Tho");
        }

        public bool checkID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * From Tho Where MaTho = @id", mydb.getConnection);

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

        public DataTable getGroup_Worker()
        {

            MyDB mydb = new MyDB();
            SqlCommand command = new SqlCommand("Select * From Nhom", mydb.getConnection);




            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
    }
}
