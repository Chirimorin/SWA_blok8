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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Opdrachten_week_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            

            bool[] isChecked = new bool[11];
            isChecked[0] = (bool)Strikje.IsChecked;
            isChecked[1] = (bool)Linkeroog.IsChecked;
            isChecked[2] = (bool)Rechteroog.IsChecked;
            isChecked[3] = (bool)Linkerwenkbrauw.IsChecked;
            isChecked[4] = (bool)Rechterwenkbrauw.IsChecked;
            isChecked[5] = (bool)Neus.IsChecked;
            isChecked[6] = (bool)BlosOpWangen.IsChecked;
            isChecked[7] = (bool)RoodOmMond.IsChecked;
            isChecked[8] = (bool)Mond.IsChecked;
            isChecked[9] = (bool)Hoedje.IsChecked;
            isChecked[10] = (bool)Haar.IsChecked;

            IComponent component = ClownFactory.create(isChecked);
            

            component.Draw(canvas);
        }
    }
}
