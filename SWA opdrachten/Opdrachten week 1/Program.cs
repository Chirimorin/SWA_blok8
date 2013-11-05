using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowText showText = new ShowText();

            showText.writeAll();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
