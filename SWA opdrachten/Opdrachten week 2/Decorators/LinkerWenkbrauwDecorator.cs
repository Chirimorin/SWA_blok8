using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Opdrachten_week_2
{
    public class LinkerWenkbrauwDecorator : BasicDecorator
    {
        public LinkerWenkbrauwDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);
            c.Children.Add(Drawer.DrawTriangle(Brushes.Blue, 1, Brushes.Black, 102, 110, 110, 95, 95, 85));
        }
    }
}
