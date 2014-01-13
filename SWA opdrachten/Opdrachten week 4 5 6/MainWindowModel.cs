using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdrachten_week_4_5_6
{
    public class MainWindowModel : sudokubasis.IPropertyChanged
    {
        private sudokubasis.SudokuController _controller;

        #region Labels
        public string Lbl00 { get { return _controller.GetValue(1, 1); } }
        public string Lbl01 { get { return _controller.GetValue(2, 1); } }
        public string Lbl02 { get { return _controller.GetValue(3, 1); } }
        public string Lbl03 { get { return _controller.GetValue(4, 1); } }
        public string Lbl04 { get { return _controller.GetValue(5, 1); } }
        public string Lbl05 { get { return _controller.GetValue(6, 1); } }
        public string Lbl06 { get { return _controller.GetValue(7, 1); } }
        public string Lbl07 { get { return _controller.GetValue(8, 1); } }
        public string Lbl08 { get { return _controller.GetValue(9, 1); } }

        public string Lbl10 { get { return _controller.GetValue(1, 2); } }
        public string Lbl11 { get { return _controller.GetValue(2, 2); } }
        public string Lbl12 { get { return _controller.GetValue(3, 2); } }
        public string Lbl13 { get { return _controller.GetValue(4, 2); } }
        public string Lbl14 { get { return _controller.GetValue(5, 2); } }
        public string Lbl15 { get { return _controller.GetValue(6, 2); } }
        public string Lbl16 { get { return _controller.GetValue(7, 2); } }
        public string Lbl17 { get { return _controller.GetValue(8, 2); } }
        public string Lbl18 { get { return _controller.GetValue(9, 2); } }

        public string Lbl20 { get { return _controller.GetValue(1, 3); } }
        public string Lbl21 { get { return _controller.GetValue(2, 3); } }
        public string Lbl22 { get { return _controller.GetValue(3, 3); } }
        public string Lbl23 { get { return _controller.GetValue(4, 3); } }
        public string Lbl24 { get { return _controller.GetValue(5, 3); } }
        public string Lbl25 { get { return _controller.GetValue(6, 3); } }
        public string Lbl26 { get { return _controller.GetValue(7, 3); } }
        public string Lbl27 { get { return _controller.GetValue(8, 3); } }
        public string Lbl28 { get { return _controller.GetValue(9, 3); } }

        public string Lbl30 { get { return _controller.GetValue(1, 4); } }
        public string Lbl31 { get { return _controller.GetValue(2, 4); } }
        public string Lbl32 { get { return _controller.GetValue(3, 4); } }
        public string Lbl33 { get { return _controller.GetValue(4, 4); } }
        public string Lbl34 { get { return _controller.GetValue(5, 4); } }
        public string Lbl35 { get { return _controller.GetValue(6, 4); } }
        public string Lbl36 { get { return _controller.GetValue(7, 4); } }
        public string Lbl37 { get { return _controller.GetValue(8, 4); } }
        public string Lbl38 { get { return _controller.GetValue(9, 4); } }

        public string Lbl40 { get { return _controller.GetValue(1, 5); } }
        public string Lbl41 { get { return _controller.GetValue(2, 5); } }
        public string Lbl42 { get { return _controller.GetValue(3, 5); } }
        public string Lbl43 { get { return _controller.GetValue(4, 5); } }
        public string Lbl44 { get { return _controller.GetValue(5, 5); } }
        public string Lbl45 { get { return _controller.GetValue(6, 5); } }
        public string Lbl46 { get { return _controller.GetValue(7, 5); } }
        public string Lbl47 { get { return _controller.GetValue(8, 5); } }
        public string Lbl48 { get { return _controller.GetValue(9, 5); } }

        public string Lbl50 { get { return _controller.GetValue(1, 6); } }
        public string Lbl51 { get { return _controller.GetValue(2, 6); } }
        public string Lbl52 { get { return _controller.GetValue(3, 6); } }
        public string Lbl53 { get { return _controller.GetValue(4, 6); } }
        public string Lbl54 { get { return _controller.GetValue(5, 6); } }
        public string Lbl55 { get { return _controller.GetValue(6, 6); } }
        public string Lbl56 { get { return _controller.GetValue(7, 6); } }
        public string Lbl57 { get { return _controller.GetValue(8, 6); } }
        public string Lbl58 { get { return _controller.GetValue(9, 6); } }

        public string Lbl60 { get { return _controller.GetValue(1, 7); } }
        public string Lbl61 { get { return _controller.GetValue(2, 7); } }
        public string Lbl62 { get { return _controller.GetValue(3, 7); } }
        public string Lbl63 { get { return _controller.GetValue(4, 7); } }
        public string Lbl64 { get { return _controller.GetValue(5, 7); } }
        public string Lbl65 { get { return _controller.GetValue(6, 7); } }
        public string Lbl66 { get { return _controller.GetValue(7, 7); } }
        public string Lbl67 { get { return _controller.GetValue(8, 7); } }
        public string Lbl68 { get { return _controller.GetValue(9, 7); } }

        public string Lbl70 { get { return _controller.GetValue(1, 8); } }
        public string Lbl71 { get { return _controller.GetValue(2, 8); } }
        public string Lbl72 { get { return _controller.GetValue(3, 8); } }
        public string Lbl73 { get { return _controller.GetValue(4, 8); } }
        public string Lbl74 { get { return _controller.GetValue(5, 8); } }
        public string Lbl75 { get { return _controller.GetValue(6, 8); } }
        public string Lbl76 { get { return _controller.GetValue(7, 8); } }
        public string Lbl77 { get { return _controller.GetValue(8, 8); } }
        public string Lbl78 { get { return _controller.GetValue(9, 8); } }

        public string Lbl80 { get { return _controller.GetValue(1, 9); } }
        public string Lbl81 { get { return _controller.GetValue(2, 9); } }
        public string Lbl82 { get { return _controller.GetValue(3, 9); } }
        public string Lbl83 { get { return _controller.GetValue(4, 9); } }
        public string Lbl84 { get { return _controller.GetValue(5, 9); } }
        public string Lbl85 { get { return _controller.GetValue(6, 9); } }
        public string Lbl86 { get { return _controller.GetValue(7, 9); } }
        public string Lbl87 { get { return _controller.GetValue(8, 9); } }
        public string Lbl88 { get { return _controller.GetValue(9, 9); } }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Notifies that a property changed. Use after updating any field.
        /// </summary>
        public void NotifyPropertyChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(null));
        }

        /// <summary>
        /// Registers the controller to this object.
        /// </summary>
        /// <param name="controller">The controller to be registered.</param>
        public void RegisterController(sudokubasis.SudokuController controller)
        {
            _controller = controller;
        }
    }
}
