using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    internal class zadanie3
    {
        public static string C()
        {
            const string host = "caseum.ru";
            const int port = 33333;
            const string user = "test_user";
            const string db = "db_test";
            const string pass = "test_pass";
            string connStr = $"server={host};port={port};user={user};" +
            $"database={db};password={pass};";
            return connStr;
        }
    }
}
