using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3
{
    class IDice
    {
        private delegate void ChangedEventHandler();
        private event ChangedEventHandler DiceRolled;

        public void attach(IObserver observer)
        {
            DiceRolled += observer.Update;
        }

        public void detach(IObserver observer)
        {
            DiceRolled -= observer.Update;
        }

        public void notify()
        {
            if (DiceRolled != null)
                DiceRolled();
        }
    }
}
