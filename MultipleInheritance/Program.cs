using System;
using System.Drawing;

namespace MultipleInheritance
{
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        public override void Draw()
        {
            base.Draw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
