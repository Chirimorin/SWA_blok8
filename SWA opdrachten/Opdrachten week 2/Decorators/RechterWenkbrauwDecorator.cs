using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class RechterWenkbrauwDecorator : BasicDecorator
    {
        public RechterWenkbrauwDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            c.Children.Add(Drawer.DrawTriangle(Brushes.Blue, 1, Brushes.Black, 158, 150, 150, 95, 95, 85));
        }
    }
}
