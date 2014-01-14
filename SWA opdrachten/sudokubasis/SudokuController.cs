using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokubasis
{
    public class SudokuController
    {
        private IPropertyChanged _propertyChanged;
        private Sudoku.Game _game;

        public SudokuController(IPropertyChanged propertyChanged)
        {
            _propertyChanged = propertyChanged;
            _game = new Sudoku.Game();
            _game.create();
            _propertyChanged.NotifyPropertyChanged();
        }

        /// <summary>
        /// Gets the current value of the field. 
        /// </summary>
        /// <param name="x">The row to check.</param>
        /// <param name="y">The column to check.</param>
        /// <returns>The string representation of the fields value.</returns>
        public string GetValue(int x, int y)
        {
            short val;
            _game.get((short)x, (short)y, out val);
            if (val == 0)
            {
                return "";
            }
            return val.ToString();
        }

        /// <summary>
        /// Sets the value of the given field. Will send a notification if a change occurs. 
        /// </summary>
        /// <param name="x">The x to change.</param>
        /// <param name="y">The y to change.</param>
        /// <param name="value">The new value that the field should be set to.</param>
        public void SetValueWithNotify(int x, int y, int value)
        {
            if (SetValueNoNotify(x, y, value))
            {
                _propertyChanged.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Sets the value of the given field. Will not send a notification.
        /// Use if a batch of fields should be changed and manually call NotifyPropertyChanged() of the ViewModel yourself.
        /// For single values, use SetValueWithNotify(int row, int column, int value);
        /// </summary>
        /// <param name="x">The x to change.</param>
        /// <param name="y">The y to change.</param>
        /// <param name="value">The new value that the field should be set to.</param>
        /// <returns>Returns true if the field was changed.</returns>
        public bool SetValueNoNotify(int x, int y, int value)
        {
            int succeeded;
            _game.set((short)x, (short)y, (short)value, out succeeded);
            if (succeeded == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if all filled fields are correct.
        /// </summary>
        /// <returns>returns true if everything is currently correct.</returns>
        public bool CheckGame()
        {
            int isValid;
            _game.isValid(out isValid);
            if (isValid == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Resets the game to the begin state. Does not make a new game. 
        /// </summary>
        public void ResetGame()
        {
            for (int x = 1; x <= 9; x++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    SetValueNoNotify(y, x, 0);
                }
            }
            _propertyChanged.NotifyPropertyChanged();
        }

        /// <summary>
        /// Clears the field and starts a new game.
        /// </summary>
        public void NewGame()
        {
            _game = new Sudoku.Game();
            _game.create();
            _propertyChanged.NotifyPropertyChanged();
        }

        /// <summary>
        /// Will finish the sudoku minus 2 fields. Use for checking if you can finish the game.
        /// </summary>
        public void Cheat()
        {
            while (Hint()) ; //Fill in all values using the hint functionality

            int counter = 0;
            for (int x = 1; x <= 9; x++) //Loop through all fields and remove the first 2 changable values. 
            {
                for (int y = 1; y <= 9; y++)
                {
                    if (counter < 2)
                    {
                        if (SetValueNoNotify(x, y, 0))
                        {
                            counter++;
                        }
                    }
                }
            }
            _propertyChanged.NotifyPropertyChanged();
        }

        /// <summary>
        /// Sets a random field to the correct value. Prioritizes incorrect fields. 
        /// </summary>
        /// <returns>Returns true if a field was changed, false if all the fields were correct already.</returns>
        public bool Hint()
        {
            short x;
            short y;
            short value;
            int succeeded;
            _game.hint(out x, out y, out value, out succeeded);

            if (succeeded == 1)
            {
                SetValueWithNotify((int)x, (int)y, (int)value);
                return true;
            }
            return false;
        }
    }
}
