using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.FontName = "Calibri";
            text.Width = 100;
            text.Copy();
            Console.ReadLine();
        }
    }
}
