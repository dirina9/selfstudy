using System;
using System.Windows.Forms;

namespace Pluralsight.arrays
{
    public class ObjArray
    {
        public void ObjArrayExample()
        {
            object[] objArray = 
            {
                "Hello World",
                4,
                new Button {Text = "Click me!"}
            };

            Type objArrType = objArray.GetType();
            Console.WriteLine(objArrType);

            foreach (object item in objArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}