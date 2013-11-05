using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_1
{
    class ShowText
    {
        public ShowText()
        {

        }

        public void writeAll()
        {
            Factory.GetWriter("BlueWriter").write("blue text");
            Factory.GetWriter("RedWriter").write("red text");
            Factory.GetWriter("GreenWriter").write("green text");
        }
    }
}
