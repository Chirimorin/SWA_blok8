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
            IComponent component = null;

            if ((bool)Strikje.IsChecked) //Strikje eerst, komt achter hoofd
                component = new StrikjeDecorator(component);
            component = new HoofdDecorator(component);
            if ((bool)Linkeroog.IsChecked)
                component = new LinkerOogDecorator(component);
            if ((bool)Rechteroog.IsChecked)
                component = new RechterOogDecorator(component);
            if ((bool)Linkerwenkbrauw.IsChecked)
                component = new LinkerWenkbrauwDecorator(component);
            if ((bool)Rechterwenkbrauw.IsChecked)
                component = new RechterWenkbrauwDecorator(component);
            if ((bool)Neus.IsChecked)
                component = new NeusDecorator(component);
            if ((bool)BlosOpWangen.IsChecked)
                component = new BlosOpWangenDecorator(component);
            if ((bool)RoodOmMond.IsChecked)
                component = new RoodOmMondDecorator(component);
            if ((bool)Mond.IsChecked)
                component = new MondDecorator(component);
            if ((bool)Hoedje.IsChecked)
                component = new HoedjeDecorator(component);
            if ((bool)Haar.IsChecked)
                component = new HaarDecorator(component);

            component.Draw(canvas);
        }
    }
}
