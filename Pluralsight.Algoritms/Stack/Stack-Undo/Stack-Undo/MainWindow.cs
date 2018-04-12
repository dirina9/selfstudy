using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Stack_Undo
{
    public partial class MainWindow : Form
    {
        Stack<UndoAction> undoColors = new Stack<UndoAction>();
        Random rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private Color GetRandomColor()
        {
            byte[] rgb = new byte[3];
            rnd.NextBytes(rgb);
            return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (undoColors.Count != 0)
            {
                undoColors.Peek().UndoColor();
                listBox1.Items.Remove(undoColors.Pop()); 
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            AddUndoAction(new UndoAction(button));
            button.BackColor = GetRandomColor();
        }


        private void AddUndoAction(UndoAction undoAction)
        {
            undoColors.Push(undoAction);
            listBox1.Items.Add(undoAction);
        }
    }
}
