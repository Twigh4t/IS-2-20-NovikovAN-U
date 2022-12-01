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
    public partial class Task1 : Form
    {
        HDD<int> hdd;
        GPU<int> gpu;

        abstract class Comp<T>
        {
            public int Price;
            public int DateRelease;
            public T Article;
            public Comp(int price, int daterelease, T article)
            {
                Price = price;
                DateRelease = daterelease;
                Article = article;
            }
            public virtual string Display()
            {
                return $"Цена: {Price} Год выпуска: {DateRelease}";
            }
        }
        class HDD<T> : Comp<T>
        {
            int Rate;
            int Capacity;
            string Face;

            public HDD(int Price, int Daterelease, T Art, int rate, string face, int capacity) : base(Price, Daterelease, Art)
            {
                Rate = rate;
                Capacity = capacity;
                Face = face;
            }

            public int Rates
            {
                get { return Rate; } set{ Rate = value; }
            }

            public int Capacitys
            {
                get { return Capacity; } set { Capacity = value; }
            }

            public string Faces
            {
                get{ return Face; } set{ Face = value; }
            }
            
            public override string Display()
            {
                return $"Цена: {Price} Год выпуска: {DateRelease} Артикул: {Article} Скорость: {Rates} Интерфейс: {Faces} Объем: {Capacitys}";
            }
        }
        class GPU<T> : Comp<T>
        {
            int FreqGPU;
            string Manuf; 
            int Mem; 

            public GPU(int Price, int DateRelease, T Art, int freq, string manuf, int memsize) : base(Price, DateRelease, Art)
            {
                Freq = freq;
                Manuf = manuf;
                Memsize = memsize; 
            }

            public int Freq
            {
                get { return FreqGPU; } set { FreqGPU = value; }
            }

            public string Manu
            {
                get { return Manuf; } set { Manuf = value; }
            }
 
            public int Memsize
            {
                get { return Mem; } set { Mem = value; }
            }

            public override string Display()
            {
                return $"Цена: {Price} Год выпуска: {DateRelease} Артикул: {Article} Частота: {Freq} Производитель: {Manu} Объем памяти: {Memsize}";
            }
        }

        public Task1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                hdd = new HDD<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(hdd.Display());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gpu = new GPU<int>(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), textBox11.Text, Convert.ToInt32(textBox12.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(gpu.Display());
        }
    } 
}
