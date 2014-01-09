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
    /// Interaction logic for NumberView.xaml
    /// </summary>
    public partial class NumberView : Window, IObserver
    {
        public NumberView()
        {
            InitializeComponent();
        }

        public void Update()//Object sender, EventArgs e)
        {
            Number.Content = Factory.Dice.Value;
        }

        
    }
}
