using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Opdrachten_week_2
{
    public class NeusDecorator : BasicDecorator
    {
        public NeusDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            
            //Drawing here
        }
    }
}
