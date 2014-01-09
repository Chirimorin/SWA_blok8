using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Opdrachten_week_3
{
    /// <summary>
    /// Interaction logic for DotView.xaml
    /// </summary>
    public partial class DotView : Window, IObserver
    {
        private Ellipse[] Dots;
        public DotView()
        {
            InitializeComponent();
            Dots = new Ellipse[7];
            Dots[0] = Dot1;
            Dots[1] = Dot2;
            Dots[2] = Dot3;
            Dots[3] = Dot4;
            Dots[4] = Dot5;
            Dots[5] = Dot6;
            Dots[6] = Dot7;
        }

        public void Update()
        {
            for (int i = 0; i < 7; i++ )
            {
                Dots[i].Visibility = Visibility.Hidden;
            }
                switch (Factory.Dice.Value)
                {
                    case 1:
                        SetVisible(3);
                        break;
                    case 2:
                        SetVisible(1);
                        SetVisible(5);
                        break;
                    case 3:
                        SetVisible(1);
                        SetVisible(3);
                        SetVisible(5);
                        break;
                    case 4:
                        SetVisible(0);
                        SetVisible(1);
                        SetVisible(5);
                        SetVisible(6);
                        break;
                    case 5:
                        SetVisible(0);
                        SetVisible(1);
                        SetVisible(3);
                        SetVisible(5);
                        SetVisible(6);
                        break;
                    case 6:
                        SetVisible(0);
                        SetVisible(1);
                        SetVisible(2);
                        SetVisible(4);
                        SetVisible(5);
                        SetVisible(6);
                        break;
                    default:

                        break;
                }

        }

        private void SetVisible(int i)
        {
            Dots[i].Visibility = Visibility.Visible;
        }
    }
}
