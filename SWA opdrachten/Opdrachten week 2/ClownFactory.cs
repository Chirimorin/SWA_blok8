using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_2
{
    public class ClownFactory
    {
        public static IComponent create(bool[] isChecked)
        {
            IComponent component;

            component = new HoofdStrategy();
            if (isChecked[0])
                component = new StrikjeDecorator(component);
            if (isChecked[1])
                component = new LinkerOogDecorator(component);
            if (isChecked[2])
                component = new RechterOogDecorator(component);
            if (isChecked[3])
                component = new LinkerWenkbrauwDecorator(component);
            if (isChecked[4])
                component = new RechterWenkbrauwDecorator(component);
            if (isChecked[5])
                component = new NeusDecorator(component);
            if (isChecked[6])
                component = new BlosOpWangenDecorator(component);
            if (isChecked[7])
                component = new RoodOmMondDecorator(component);
            if (isChecked[8])
                component = new MondDecorator(component);
            if (isChecked[9])
                component = new HoedjeDecorator(component);
            if (isChecked[10])
                component = new HaarDecorator(component);

            return component;
        }
    }
}
