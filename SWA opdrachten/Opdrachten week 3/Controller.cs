using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_3
{
    public class Controller
    {
        private MainWindow mainWindow;
        private NumberView numberView;
        private DotView dotView;
        private int openWindows;

        public Controller()
        {
            mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Closed += MainWindowClosed;

            numberView = new NumberView();
            numberView.Show();
            numberView.Closed += WindowClosed;
            Factory.getDice().DiceRolled += numberView.DiceRolled;

            dotView = new DotView();
            dotView.Show();
            dotView.Closed += WindowClosed;
            Factory.getDice().DiceRolled += dotView.DiceRolled;

            openWindows = 2;
        }

        private void MainWindowClosed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void WindowClosed(object sender, EventArgs e)
        {
            openWindows--;
            if (openWindows <= 0)
                App.Current.Shutdown();
        }
    }
}
