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
            IComponent component = new HoofdDecorator(null);
            if ((bool)Linkeroog.IsChecked)
                component = new LinkerOogDecorator(component);
            if ((bool)Rechteroog.IsChecked)
                component = new RechterOogDecorator(component);

            component.Draw(canvas);
        }
    }
}
