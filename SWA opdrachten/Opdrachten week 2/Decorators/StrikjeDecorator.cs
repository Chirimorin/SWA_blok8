using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class StrikjeDecorator : BasicDecorator
    {
        public StrikjeDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);

            c.Children.Add(Drawer.DrawTriangle(Brushes.Aquamarine, 1, Brushes.Black, 130, 85, 175, 160, 215, 215));
            c.Children.Add(Drawer.DrawTriangle(Brushes.Yellow, 1, Brushes.Black, 70, 70, 138, 202, 230, 215));
            c.Children.Add(Drawer.DrawTriangle(Brushes.Yellow, 1, Brushes.Black, 190, 190, 122, 202, 230, 215));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Yellow, 1, Brushes.Black, 22, 26, 119, 202));
        }
    }
}
