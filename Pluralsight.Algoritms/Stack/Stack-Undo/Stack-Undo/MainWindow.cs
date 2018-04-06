using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Stack_Undo
{
    public partial class MainWindow : Form
    {
        Stack<UndoAction> undoOps = new Stack<UndoAction>();
        Random rng = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private Color GetRandomBrush()
        {
            byte[] rgb = new byte[3];
            rng.NextBytes(rgb);
            return new SolidColorBrush(Color.FromArgb(rgb[0], rgb[1], rgb[2]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            undoOps.Push(new UndoAction(button1));
            button1.BackColor = GetRandomBrush();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
