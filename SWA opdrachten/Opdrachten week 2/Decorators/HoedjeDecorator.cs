using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class HoedjeDecorator : BasicDecorator
    {
        public HoedjeDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);

            c.Children.Add(Drawer.DrawEllipse(Brushes.LightGreen, 1, Brushes.Black, 52, 24, 104, 48));
            c.Children.Add(Drawer.DrawRectangle(Brushes.LightGreen, 1, Brushes.Black, 120, 140, 35, 60));
            c.Children.Add(Drawer.DrawRectangle(Brushes.Red, 0, Brushes.Black, 120, 140, 55, 60));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Green, 1, Brushes.Black, 20, 12, 120, 29));
        }
    }
}
