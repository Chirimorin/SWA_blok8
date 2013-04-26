using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class HaarDecorator : BasicDecorator
    {
        public HaarDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            
            //Drawing here links
            
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 45, 75));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 55, 70));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 60, 80));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 35, 80));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 30, 90));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 28, 100));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 25, 110));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 25, 120));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 28, 130));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 34, 140));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 45, 148));

            // rechts
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 195, 75));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 185, 70));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 180, 80));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 205, 80));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 210, 90));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 212, 100));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 215, 110));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 215, 120));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 212, 130));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 206, 140));
            c.Children.Add(Drawer.DrawEllipse(Brushes.Orange, 0, Brushes.Black, 20, 20, 195, 148));
        }
    }
}
