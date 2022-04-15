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

namespace zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string id_selected_rows = "0";

        MySqlConnection conn = new MySqlConnection(zadanie3.C());
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataTable table = new DataTable();

        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = dataGridView1.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = dataGridView1.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString();
            //Указываем ID выделенной строки в метке
            MessageBox.Show(id_selected_rows);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                // запрос
                string sql = $"SELECT id, fio, theme_kurs FROM t_stud";
                //Объявляем команду, которая выполнить запрос в соединении conn
                MyDA.SelectCommand = new MySqlCommand(sql, conn);
                //Заполняем таблицу записями из БД
                MyDA.Fill(table);
                //Указываем, что источником данных в bindingsource является заполненная выше таблица
                bSource.DataSource = table;
                //Указываем, что источником данных ДатаГрида является bindingsource 
                dataGridView1.DataSource = bSource;
                //Закрываем соединение
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка подключения");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Магические строки
            dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
            dataGridView1.CurrentRow.Selected = true;
            //Метод получения ID выделенной строки в глобальную переменную
            GetSelectedIDString();
        }

        private void zadanie3_Load(object sender, EventArgs e)
        {

        }
    }
}


