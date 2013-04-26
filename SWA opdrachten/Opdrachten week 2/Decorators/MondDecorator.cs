using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Opdrachten_week_2
{
    public class MondDecorator : BasicDecorator
    {
        public MondDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);

            c.Children.Add(Drawer.DrawLine(Brushes.Black, 1, 150, 135, 164, 170));
            c.Children.Add(Drawer.DrawLine(Brushes.Black, 1, 135, 125, 170, 170));
            c.Children.Add(Drawer.DrawLine(Brushes.Black, 1, 125, 110, 170, 164));

        }
    }
}
