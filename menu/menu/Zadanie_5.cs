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
    public partial class Zadanie_5 : Form
    {
        public Zadanie_5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        MySqlConnection conn = new MySqlConnection(zadanie31.C());


        //Простой метод добавляющий в таблицу записи, в качестве параметров принимает ФИО и Предмет
        public bool InsertStud(string fiostud, string registration_date)
        {
            //определяем переменную, хранящую количество вставленных строк
            int InsertCount = 0;
            //Объявляем переменную храняющую результат операции
            bool result = false;
            // открываем соединение
            conn.Open();
            // запросы
            // запрос вставки данных
            string query = $"INSERT INTO t_PraktStud (fioStud, datetimeStud) VALUES ('{fiostud}', '{registration_date}')";
            try
            {
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                InsertCount = command.ExecuteNonQuery();
                // закрываем подключение к БД
            }
            catch
            {
                //Если возникла ошибка, то запрос не вставит ни одной строки
                InsertCount = 0;
            }
            finally
            {
                //Но в любом случае, нужно закрыть соединение
                conn.Close();
                //Ессли количество вставленных строк было не 0, то есть вставлена хотя бы 1 строка
                if (InsertCount != 0)
                {
                    //то результат операции - истина
                    result = true;
                }
            }
            //Вернём результат операции, где его обработает алгоритм
            return result;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string fiostud = textBox1.Text;
            string registration_date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!");
            }
            else
            {
                InsertStud(fiostud, registration_date);
            }
        }

        private void Zadanie_5_Load(object sender, EventArgs e)
        {

        }
    }
}
