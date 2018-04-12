using System.Drawing;
using System.Windows.Forms;

namespace Stack_Undo
{
    public class UndoAction
    {
        //constructor
        public UndoAction(Button currentButton)
        {
            previousButtonColor = currentButton.BackColor;
            previousButton = currentButton;
        }

        public void UndoColor()
        {
            previousButton.BackColor = previousButtonColor;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", previousButton.Name, previousButtonColor);
        }

        public Button previousButton;
        public Color previousButtonColor;
    }
}