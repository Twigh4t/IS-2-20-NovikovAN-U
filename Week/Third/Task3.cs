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
        MySqlConnection Connection;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable DT = new DataTable();
        BindingSource BindingS = new BindingSource();
        public void NumberBus()
        {
            DT.Clear();
            string table = "SELECT id_route AS `id`, way AS `путь`, bus AS `автобус`, price AS `цена` FROM route ON route.id_route = id_route";
            Connection.Open();
            MyDA.SelectCommand = new MySqlCommand(table, Connection);
            MyDA.Fill(DT);
            BindingS.DataSource = DT;
            dataGridView1.DataSource = BindingS;
            Connection.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[3].Visible = true;
            dataGridView1.Columns[4].Visible = true;
            dataGridView1.Columns[5].Visible = true;




            dataGridView1.Columns[0].FillWeight = 15;
            dataGridView1.Columns[3].FillWeight = 15;
            dataGridView1.Columns[4].FillWeight = 15;
            dataGridView1.Columns[5].FillWeight = 15;



            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;



            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        public Task3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            Connection.Open();
            string info1 = "";
            string info2 = "";
            string info3 = "";
            string info4 = "";
            string sql = $"SELECT *";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                info1 = reader[0].ToString();
                info2 = reader[3].ToString();
                info3 = reader[4].ToString();
                info4 = reader[5].ToString();
            }
            reader.Close();
            MessageBox.Show("id:" + info1 + "путь:" + info2 + "автобус:" + info3 + "цена:" + info4);
            Connection.Close();
        }
    }
}
