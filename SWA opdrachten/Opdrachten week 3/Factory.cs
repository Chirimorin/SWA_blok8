using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3
{
    abstract class Factory
    {
        private static Dice dice;

        public static Dice Dice
        {
            get
            {
                if (dice == null)
                    dice = new Dice();
                return dice;
            }
        }
    }
}
