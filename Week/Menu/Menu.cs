using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using First;
using Second;
using Third;
using Four;
using Fifth;

namespace Menu
{
    public partial class Menu : Form
    {       
        public Menu()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Task3();
            form.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new Task1();
            form.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form = new Task2();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Task4();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Task5();
            form.ShowDialog();
        }
    }
}
