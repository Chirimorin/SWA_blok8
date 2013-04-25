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
    abstract class Drawer
    {
        public static Ellipse DrawEllipse(Brush fillColor, int strokeThickness, Brush strokeColor, int width, int height, int xPos, int yPos)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Fill = fillColor;

            if (strokeThickness > 0)
            {
                ellipse.StrokeThickness = strokeThickness;
                ellipse.Stroke = strokeColor;
            }

            ellipse.Width = width;
            ellipse.Height = height;

            ellipse.SetValue(Canvas.LeftProperty, (double)xPos);
            ellipse.SetValue(Canvas.TopProperty, (double)yPos);

            return ellipse;
        }

        public static Polygon DrawTriangle(Brush fillColor, int strokeThickness, Brush strokeColor, int x1, int x2, int x3, int y1, int y2, int y3)
        {
            Polygon triangle = new Polygon();
            triangle.Fill = fillColor;

            if (strokeThickness > 0)
            {
                triangle.StrokeThickness = strokeThickness;
                triangle.Stroke = strokeColor;
            }

            PointCollection pointCollection = new PointCollection(3);
            pointCollection.Add(new Point(x1, y1));
            pointCollection.Add(new Point(x2, y2));
            pointCollection.Add(new Point(x3, y3));


            triangle.Points = pointCollection;

            return triangle;
        }

        public static Polygon DrawRectangle(Brush fillColor, int strokeThickness, Brush strokeColor, int x1, int x2, int y1, int y2)
        {
            Polygon rectangle = new Polygon();
            rectangle.Fill = fillColor;

            if (strokeThickness > 0)
            {
                rectangle.StrokeThickness = strokeThickness;
                rectangle.Stroke = strokeColor;
            }

            PointCollection pointCollection = new PointCollection(4);
            pointCollection.Add(new Point(x1, y1));
            pointCollection.Add(new Point(x1, y2));
            pointCollection.Add(new Point(x2, y2));
            pointCollection.Add(new Point(x2, y1));

            rectangle.Points = pointCollection;

            return rectangle;

        }
    }
}
