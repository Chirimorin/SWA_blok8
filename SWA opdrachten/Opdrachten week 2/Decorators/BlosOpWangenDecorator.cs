using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class BlosOpWangenDecorator : BasicDecorator
    {
        public BlosOpWangenDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            
            c.Children.Add(Drawer.DrawEllipse(Brushes.Blue, 1, Brushes.Black, 35, 35, 75, 140));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Blue, 1, Brushes.Black, 35, 35, 150, 140));
        }
    }
}
