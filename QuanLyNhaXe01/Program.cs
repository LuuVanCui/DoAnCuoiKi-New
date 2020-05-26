using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaXe01
{
    public static class Globals
    {
        public static Int32 GlobalUserID; // Modifiable in Code
        public static DateTime time_in;
        public static DateTime time_out;
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            loginForm fLogin = new loginForm();
            fLogin.ShowDialog();
        }
    }
}
