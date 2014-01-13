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
        private MainWindowModel _mainWindowModel;
        private sudokubasis.SudokuController _sudokuController;

        public MainWindow()
        {
            InitializeComponent();
            _mainWindowModel = new MainWindowModel();
            DataContext = _mainWindowModel;
            _sudokuController = new sudokubasis.SudokuController(_mainWindowModel);
            _mainWindowModel.RegisterController(_sudokuController);
        }

        private void VulIn_Click(object sender, RoutedEventArgs e)
        {
            _sudokuController.SetValueWithNotify((Row.SelectedIndex+1), (Column.SelectedIndex+1), (Value.SelectedIndex));
        }

        private void Controleer_Click(object sender, RoutedEventArgs e)
        {
            if (_sudokuController.CheckGame())
            {
                MessageBox.Show("Alles (tot nu toe) is correct!");
            }
            else
            {
                MessageBox.Show("Er zitten nog wat foutjes in je sudoku.");
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _sudokuController.ResetGame();
        }

        private void Nieuw_Click(object sender, RoutedEventArgs e)
        {
            _sudokuController.NewGame();
        }

        private void Cheat_Click(object sender, RoutedEventArgs e)
        {
            _sudokuController.Cheat();
        }

        private void Hint_Click(object sender, RoutedEventArgs e)
        {
            _sudokuController.Hint();
        }
    }
}
