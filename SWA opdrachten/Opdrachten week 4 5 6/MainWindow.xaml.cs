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

namespace Opdrachten_week_4_5_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private short val;
        public MainWindow()
        {
            InitializeComponent();
            Sudoku.Game game = new Sudoku.Game();
            game.create();
            
            for (short y = 1; y <= 9; y++)
            {
                for (short x = 1; x <= 9; x++)
                {
                    
                    game.get(x, y, out val);
                    Console.Write(val.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
