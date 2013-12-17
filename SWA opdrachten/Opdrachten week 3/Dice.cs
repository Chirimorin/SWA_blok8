using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3
{
    class Dice
    {
        private Random RNG;
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        public event ChangedEventHandler DiceRolled;
        public int Value { get; set; }

        public Dice()
        {
            Value = 0;
            RNG = new Random();
        }

        public void Roll()
        {
            Value = RNG.Next(1,7);
            OnChanged(EventArgs.Empty);
        }

        protected virtual void OnChanged(EventArgs e)
        {
            if (DiceRolled != null)
                DiceRolled(this, e);
        }


    }
}
