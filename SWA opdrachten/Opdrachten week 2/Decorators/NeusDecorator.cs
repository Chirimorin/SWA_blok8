using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

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
            c.Children.Add(Drawer.DrawEllipse(Brushes.Red, 1, Brushes.Black, 40, 40, 110, 115));
        }
    }
}
