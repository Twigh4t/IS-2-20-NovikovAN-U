using ConnectDB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fifth
{
    public partial class Task5 : Form
    {
        Connectdb connect = new Connectdb("server=chuc.caseum.ru;port=33333;username=st_2_20_19;password=69816309;database=is_2_20_st19_KURS");
        MySqlConnection conn;
        MySqlDataAdapter MyDA = new MySqlDataAdapter();
        DataTable DT = new DataTable();
        BindingSource BindingS = new BindingSource();
        public void GetBD()
        {
            DT.Clear();
            string sqlview = "SELECT t_Uchebka_Novikov.idStud AS `Код`, t_Uchebka_Novikov.fioStud AS `ФИО`, t_Uchebka_Novikov.datetimeStud `Дата рождения` FROM `t_Uchebka_Novikov`";
            conn.Open();

            MyDA.SelectCommand = new MySqlCommand(sqlview, conn);
            MyDA.Fill(DT);

            BindingS.DataSource = DT;

            dataGridView1.DataSource = BindingS;
            conn.Close();

            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;


            dataGridView1.Columns[0].FillWeight = 3;
            dataGridView1.Columns[1].FillWeight = 15;
            dataGridView1.Columns[2].FillWeight = 9;


            dataGridView1.Columns[0].ReadOnly = false;
            dataGridView1.Columns[1].ReadOnly = false;
            dataGridView1.Columns[2].ReadOnly = false;


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.ColumnHeadersVisible = true;
        }
        public Task5()
        {
            InitializeComponent();
        }
        private void Task5_Load(object sender, EventArgs e)
        {
            conn = connect.Connection();
            GetBD();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string fio = textBox1.Text;
                string datetime = textBox2.Text;
                string sql = "INSERT INTO `t_Uchebka_Novikov`(fioStud, datetimeStud) VALUES (@a, @b)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@a", MySqlDbType.VarChar).Value = fio;
                cmd.Parameters.Add("@b", MySqlDbType.VarChar).Value = datetime;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь добавлен");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {               
                conn.Close();
                GetBD();
            }
        }
    }
}
