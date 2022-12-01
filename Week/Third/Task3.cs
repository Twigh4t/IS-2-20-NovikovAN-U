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
using static Third.Program;

namespace Third
{
    public partial class Task3 : Form
    {       
        Connect connect = new Connect("server = chuc.caseum.ru;port=33333;username=st_2_20_19;password=69816309;database=is_2_20_st19_KURS");
        public void NumberBus()
        {
            string table = "Select *";
        }
        public Task3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
