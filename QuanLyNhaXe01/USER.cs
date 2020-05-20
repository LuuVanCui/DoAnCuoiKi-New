using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    class USER
    {
        MyDB mydb = new MyDB();
        public bool insertUser(int id, string fname, string lname, string uname, string pwd, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (id, fname, lname, uname, pwd, fig)" +
                "VALUES (@id, @fn, @ln, @uname, @pwd, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.NChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.NChar).Value = pwd;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool deleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM login WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool updateUser(int id, string fname, string lname, string uname, string pwd, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE login SET fname=@fn, lname=@ln, username=@uname, password=@pwd, image=@pic WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.NChar).Value = pwd;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable getUser(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";

            if (operation == "register")
            {
                query = "SELECT * FROM login WHERE username = @un";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM login WHERE username = @un AND id <> @uid";
            }

            SqlCommand command = new SqlCommand(query, mydb.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

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
