using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    static class Program1
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu1());
        }
    }
    internal class zadanie31
    {
        public static string C()
        {
            const string host = "caseum.ru";
            const int port = 33333;
            const string user = "test_user";
            const string db = "db_test";
            const string pass = "test_pass";
            string connQwe = $"server={host};port={port};user={user};" +
            $"database={db};password={pass};";
            return connQwe;
        }
    }
}
