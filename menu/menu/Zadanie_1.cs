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
    public partial class zadanie_1 : Form
    {
        public zadanie_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string цена = Convert.ToString(textBox1.Text);
            string год_выпуска = Convert.ToString(textBox2.Text);
            string частота_GPU = Convert.ToString(textBox3.Text);
            string производитель = Convert.ToString(textBox4.Text);
            string объем_памяти = Convert.ToString(textBox5.Text);
            string артикул = Convert.ToString(textBox6.Text);
            Видеокарты vd1 = new Видеокарты(цена, год_выпуска, артикул, частота_GPU, производитель, объем_памяти);
            vd1.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string цена = Convert.ToString(textBox1.Text);
            string год_выпуска = Convert.ToString(textBox2.Text);
            string частота = Convert.ToString(textBox3.Text);
            string количество_ядер = Convert.ToString(textBox4.Text);
            string количество_потоков = Convert.ToString(textBox5.Text);
            string артикул = Convert.ToString(textBox6.Text);
            Процессоры cp1 = new Процессоры(цена, год_выпуска, артикул, частота, количество_ядер, количество_потоков);
            cp1.Display(listBox1);
        }
    }
    abstract class Комплектующие<k>
    {
        protected string цена; //цена
        protected string год_выпуска; //год выпуска
        protected string артикул;
        public Комплектующие(string Цена, string Год_выпуска, string Артикул)
        {
            цена = Цена;
            год_выпуска = Год_выпуска;
            артикул = Артикул;
        }
        public abstract void Display(ListBox listBox);
    }
    class Процессоры : Комплектующие<string>
    {
        public string частота1; //частота
        public string количество_ядер1; //Количество ядер
        public string количество_потоков1; //количество потоков
        public Процессоры(string Цена, string Год_выпуска, string Артикул, string Частота, string Количество_ядер, string Количество_потоков)
        : base(Цена, Год_выпуска, Артикул)
        {
            частота = Частота;
            количество_ядер = Количество_ядер;
            количество_потоков = Количество_потоков;
        }
        public string частота { get { return частота1; } set { частота1 = value; } }
        public string количество_ядер { get { return количество_ядер1; } set { количество_ядер1 = value; } }
        public string количество_потоков { get { return количество_потоков1; } set { количество_потоков1 = value; } }
        public override void Display(ListBox listBox1)
        {
            listBox1.Items.Add($"Цена {цена}, Год выпуска {год_выпуска}, Частота {частота}, Количество ядер {количество_ядер}, Количество потоков {количество_потоков1}, Артикул {артикул}");
        }
    }
    class Видеокарты : Комплектующие<string>
    {
        public string частота_процессора1; // частота процессора 
        public string производитель1; // производитель 
        public string объем_памяти1; // объем памяти 
        public Видеокарты(string Цена, string Год_выпуска, string Артикул, string Частота_процессора, string Производитель, string Объем_памяти)
        : base(Цена, Год_выпуска, Артикул)
        {
            частота_процессора = Частота_процессора;
            производитель = Производитель;
            объем_памяти = Объем_памяти;
        }
        public string частота_процессора { get { return частота_процессора1; } set { частота_процессора1 = value; } }
        public string производитель { get { return производитель1; } set { производитель1 = value; } }
        public string объем_памяти { get { return объем_памяти1; } set { объем_памяти1 = value; } }
        public override void Display(ListBox listBox1)
        {
            listBox1.Items.Add($"Цена {цена}, Год выпуска {год_выпуска}, Частота процессора  {частота_процессора}, Производитель {производитель1}, Объем памяти {объем_памяти}, Артикул {артикул}");
        }
    }
}
