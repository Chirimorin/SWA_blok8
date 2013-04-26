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
    public class RoodOmMondDecorator : BasicDecorator
    {
        public RoodOmMondDecorator(IComponent component)
            : base(component)
        {
        }

        public override void Draw(Canvas c)
        {
            base.Draw(c);

            Polygon polygon = new Polygon();
            polygon.Fill = Brushes.Red;
            polygon.Stroke = Brushes.Black;
            polygon.StrokeThickness = 1;

            PointCollection pointCollection = new PointCollection();
            pointCollection.Add(new Point(130, 162));

            pointCollection.Add(new Point(145, 158));
            pointCollection.Add(new Point(155, 155));
            pointCollection.Add(new Point(160, 160));
            pointCollection.Add(new Point(160, 165));
            pointCollection.Add(new Point(155, 170));
            pointCollection.Add(new Point(140, 177));

            pointCollection.Add(new Point(120, 177));
            pointCollection.Add(new Point(105, 170));
            pointCollection.Add(new Point(100, 165));
            pointCollection.Add(new Point(100, 160));
            pointCollection.Add(new Point(105, 155));
            pointCollection.Add(new Point(115, 158));

            polygon.Points = pointCollection;

            c.Children.Add(polygon);
        }
    }
}
