using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Zadanie_2 : Form
    {
        public Zadanie_2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Connection //Подключение
        {
            public MySqlConnection ConnDB()
            {
                // строка подключения к БД
                string connQwe = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connQwe);
                return conn;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            Connection Conndb = new Connection();
            try
            {
                Conndb.ConnDB().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось подключится к базе данных.\nИсключение скопировано в буфер обмена.\n{ex.ToString()}", "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Clipboard.SetDataObject(ex.ToString());
                x = 1;
            }
            finally
            {
                if (x == 1) { }
                else { MessageBox.Show("Подключение прошло успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                Conndb.ConnDB().Close();

            }
        }
    }
}
