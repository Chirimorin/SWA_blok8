using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class RechterOogDecorator : BasicDecorator
    {
        public RechterOogDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 12, 16, 148, 100));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Green, 0, Brushes.Black, 6, 8, 150, 104));
        }
    }
}
