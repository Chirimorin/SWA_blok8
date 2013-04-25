using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class HoofdDecorator : BasicDecorator
    {
        public HoofdDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            //Omtrek hoofd
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 140, 140, 60, 60));
            //Linkeroor
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 30, 60, 45, 90));
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 20, 40, 50, 100));
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 5, 10, 58, 116));
            //Rechteroor
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 30, 60, 185, 90));
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 20, 40, 190, 100));
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 1, Brushes.Black, 5, 10, 198, 116));
            //Vulling Hoofd
            c.Children.Add(Drawer.DrawEllipse(Brushes.White, 0, Brushes.Black, 138, 138, 61, 61));
        }
    }
}
