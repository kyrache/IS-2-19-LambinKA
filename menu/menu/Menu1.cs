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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zadanie_1 z = new zadanie_1();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadanie_2 z = new Zadanie_2();
            z.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadanie_3 z = new Zadanie_3();
            z.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zadanie_4 z = new Zadanie_4();
            z.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zadanie_5 z = new Zadanie_5();
            z.Show();
        }

        private void Menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
