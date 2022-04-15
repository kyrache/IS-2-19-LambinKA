using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zadanie1
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
        private void button1_Click(object sender, EventArgs e)
        {
            string prise = Convert.ToString(textBox1.Text);
            string yearOfRelease = Convert.ToString(textBox2.Text);
            string frequencyOfGPU = Convert.ToString(textBox3.Text);
            string manufacturer = Convert.ToString(textBox4.Text);
            string memoryVolume = Convert.ToString(textBox5.Text);
            string articyl = Convert.ToString(textBox6.Text);
            Videocard vd1 = new Videocard(prise, yearOfRelease, articyl, frequencyOfGPU, manufacturer, memoryVolume);
            vd1.Display(listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string prise = Convert.ToString(textBox1.Text);
            string yearOfRelease = Convert.ToString(textBox2.Text);
            string frequency = Convert.ToString(textBox3.Text);
            string numberOfCores = Convert.ToString(textBox4.Text);
            string numberOfThread = Convert.ToString(textBox5.Text);
            string aticyl = Convert.ToString(textBox6.Text);
            Cpu cp1 = new Cpu(prise, yearOfRelease, aticyl, frequency, numberOfCores, numberOfThread);
            cp1.Display(listBox1);
        }
    }
    abstract class Accessories<k>
    {
        protected string price; //цена
        protected string yearOfRelease; //год выпуска
        protected string articyl;
        public Accessories(string Price, string YearOfRelease, string Articyl)
        {
            price = Price;
            yearOfRelease = YearOfRelease;
            articyl = Articyl;
        }
        public abstract void Display(ListBox listBox);
    }
    class Cpu : Accessories<string>
    {
        public string frequency1; //частота
        public string numberOfCores1; //Количество ядер
        public string numberOfThread1; //количество потоков
        public Cpu(string Price, string YearOfRelease, string Articyl, string Frequency, string NumberOfCores, string NumberOfThread)
        : base(Price, YearOfRelease, Articyl)
        {
            frequency = Frequency;
            numberOfCores = NumberOfCores;
            numberOfThread = NumberOfThread;
        }
        public string frequency { get { return frequency1; } set { frequency1 = value; } }
        public string numberOfCores { get { return numberOfCores1; } set { numberOfCores1 = value; } }
        public string numberOfThread { get { return numberOfThread1; } set { numberOfThread1 = value; } }
        public override void Display(ListBox listBox1)
        {
            listBox1.Items.Add($"Цена {price}, Год выпуска {yearOfRelease}, Частота {frequency}, Количество ядер {numberOfCores}, Количество потоков {numberOfThread}, Артикул {articyl}");
        }
    }
    class Videocard : Accessories<string>
    {
        public string frequencyOfGPU1; // частота процессора 
        public string manufacturer1; // производитель 
        public string memoryVolume1; // объем памяти 
        public Videocard(string Price, string YearOfRelease, string Articyl, string FrequencyOfGPU, string Manufacturer, string MemoryVolume)
        : base(Price, YearOfRelease, Articyl)
        {
            frequencyOfGPU = FrequencyOfGPU;
            manufacturer = Manufacturer;
            memoryVolume = MemoryVolume;
        }
        public string frequencyOfGPU { get { return frequencyOfGPU1; } set { frequencyOfGPU1 = value; } }
        public string manufacturer { get { return manufacturer1; } set { manufacturer1 = value; } }
        public string memoryVolume { get { return memoryVolume1; } set { memoryVolume1 = value; } }
        public override void Display(ListBox listBox1)
        {
            listBox1.Items.Add($"Цена {price}, Год выпуска {yearOfRelease}, Частота процессора  {frequencyOfGPU}, Производительность {manufacturer1}, Объем памяти {memoryVolume}, Артикул {articyl}");
        }
    }
}

    

      