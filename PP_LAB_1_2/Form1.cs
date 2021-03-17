using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneratorCS;

namespace PP_LAB_1_2
{
    public partial class Form1 : Form
    {
        RandomNumberGenerator rng = new RandomNumberGenerator(1);
        List<int> values = new List<int>();
        List<int> weights = new List<int>();
        List<int> packed = new List<int>();
        int cost = 0;
        int load = 0;
        int count, weight, value, capacity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load = 0;
            cost = 0;
            packed.Clear();
            iterPackedBox.Clear();
            for (int i = 0; i < count; i++)
            {
                if (load + weights[i] <= capacity)
                {
                    load = load + weights[i];
                    cost = cost + values[i];
                    packed.Add(i + 1);
                }
            }
            iterPackedBox.Text = string.Join("\t", packed);
            costBox.Text = cost.ToString();
            loadBox.Text = load.ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = Convert.ToInt32(countBox.Text);
            weight = Convert.ToInt32(weightBox.Text);
            value = Convert.ToInt32(valueBox.Text);
            capacity = Convert.ToInt32(capacityBox.Text);

            values.Clear();
            weights.Clear();

            indexBox.Clear();
            iterValBox.Clear();
            iterWeightBox.Clear();
            iterPackedBox.Clear();
            costBox.Clear();
            loadBox.Clear();


            for (int i = 0; i < count; i++)
            {
                values.Add(rng.nextInt(1, value));
                indexBox.AppendText(i + "\t");
            }
            for (int i = 0; i < count; i++)
            {
                weights.Add(rng.nextInt(1, weight));
            }

            iterWeightBox.Text = string.Join("\t", weights);
            iterValBox.Text = string.Join("\t", values);
        }
    }
}
