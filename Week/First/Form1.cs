using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Form1 : Form
    {
        HDD<int> hdd;
        GPU<int> gpu;
        abstract class Components<T>
        {
            public int Price;
            public int DateRelease;
            public T Article;
            public Components(int price, int dateRelease, T article)
            {
                Price = price;
                DateRelease = dateRelease;
                Article = article;
            }
            public virtual string Display()
            {
                return $"Цена: {Price} \nГод выпуска: {DateRelease}";
            }
        }
        class HDD<T> : Components<T>
        {
            int Turnovers;
            public int Turn
            {
                get { return Turnovers; } set{ Turnovers = value; }
            }
            string ConnectInterface;
            public string Connect
            {
                get{ return ConnectInterface; } set{ ConnectInterface = value; }
            }
            int Size;
            public int size
            {
                get{ return Size; } set{ Size = value; }
            }
            public HDD(int Price, int DateSince, T Art, int turnovers, string connectInterface, int Size) : base(Price, DateSince, Art)
            {
                Turn = turnovers;
                Connect = connectInterface;
                size = Size;
            }
            public override string Display()
            {
                return $"Цена: {Price} \nГод выпуска: {DateRelease} \nАртикул: {Article} \nСкорость оборротов: {Turn} \nИнтерфейс подключения: {Connect} \nОбъем: {size} ";
            }
        }
        class GPU<T> : Components<T>
        {
            int FreqGPU;
            public int Freq
            {
                get { return FreqGPU; } set { FreqGPU = value; }
            }
            string Manufacture;
            public string Manuf
            {
                get { return Manufacture; } set { Manufacture = value; }
            }
            int SizeMem;
            public int Mem
            {
                get { return SizeMem; } set { SizeMem = value; }
            }
            public GPU(int Price, int DateRelease, T Art, int freq, string manufacture, int sizeMem) : base(Price, DateRelease, Art)
            {
                Freq = freq;
                Manuf = manufacture;
                Mem = sizeMem;
            }
            public override string Display()
            {
                return $"Цена: {Price} \nГод выпуска: {DateRelease} \nАртикул: {Article} \nЧастота граф.процессора: {Freq}\n Производитель: {Manuf}\n Объем памяти: {Mem}";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hdd = new HDD<int>(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox13.Text), Convert.ToInt32(textBox6.Text), textBox5.Text, Convert.ToInt32(textBox7.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(hdd.Display());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gpu = new GPU<int>(Convert.ToInt32(textBox12.Text), Convert.ToInt32(textBox11.Text), Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox10.Text), textBox9.Text, Convert.ToInt32(textBox8.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(gpu.Display());
        }
    }
}
