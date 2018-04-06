using System.Drawing;
using System.Windows.Forms;

namespace Stack_Undo
{
    public class UndoAction
    {
        public UndoAction(Button button)
        {
            oldButton = button;
            oldBrush = oldButton.BackColor.CloneCurrentValue;
        }

        public void Execute()
        {
            oldButton.BackColor = oldBrush;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", oldButton.Content, oldBrush.ToString());
        }

        private Button oldButton;
        private Color oldBrush;
    }
}