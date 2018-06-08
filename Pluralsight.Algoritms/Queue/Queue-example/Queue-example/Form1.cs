using System;
using System.Collections.Generic;
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
            int index = 0;
            foreach (int message in queue)
            {
                switch (index)
                {
                    case 0:
                        UpdateListBox(listBox2, message);
                        break;
                    case 1:
                        UpdateListBox(listBox3, message);
                        break;
                    case 2:
                        UpdateListBox(listBox4, message);
                        break;
                    case 3:
                        UpdateListBox(listBox5, message);
                        break;
                    case 4:
                        UpdateListBox(listBox6, message);
                        break;
                    case 5:
                        UpdateListBox(listBox7, message);
                        break;
                }
                index++;

                if (index > 5)
                {
                    break;
                }
            }
        }

        private void UpdateListBox(ListBox listBox, int message)
        {
            listBox.Items.Clear();
            listBox.Items.Add(message.ToString());
        }

        public List<ListBox> CreateListOfListBoxes()
        {
            List<ListBox> listBoxes = new List<ListBox>();
            listBoxes.Add(listBox2); 
        }
    }
}
