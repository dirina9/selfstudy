using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Queue_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Queue<int> queue = new Queue<int>();
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            queue.Enqueue(rnd.Next(0, 200));
            UpdateGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                listBox1.Items.Add(queue.Dequeue().ToString());
                UpdateGrid();
            }
        }

        public void UpdateGrid()
        {
            listBox2.Items.Clear(); 
            listBox3.Items.Clear(); 
            listBox4.Items.Clear(); 
            listBox5.Items.Clear(); 
            listBox6.Items.Clear(); 
            listBox7.Items.Clear();

            int index = 0;
            foreach (int message in queue)
            {
                switch (index)
                {
                    case 0:
                        listBox2.Items.Add(message.ToString());
                        break;
                    case 1:
                        listBox3.Items.Add(message.ToString());
                        break;
                    case 2:
                        listBox4.Items.Add(message.ToString());
                        break;
                    case 3:
                        listBox5.Items.Add(message.ToString());
                        break;
                    case 4:
                        listBox6.Items.Add(message.ToString());
                        break;
                    case 5:
                        listBox7.Items.Add(message.ToString());
                        break;
                }
                index++;

                if (index > 5)
                {
                    break;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
