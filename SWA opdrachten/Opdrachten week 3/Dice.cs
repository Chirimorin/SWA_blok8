using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3
{
    class Dice : IDice
    {
        private Random RNG;

        private int _value;
        public int Value 
        {
            get { return _value; }
            set { _value = value; notify(); }
        }

        public Dice()
        {
            _value = 0;
            RNG = new Random();
        }

        public void Roll()
        {
            Value = RNG.Next(1,7);
        }

        
    }
}
