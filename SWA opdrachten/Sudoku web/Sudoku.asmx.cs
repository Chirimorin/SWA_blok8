using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;

namespace Sudoku_web
{
    /// <summary>
    /// Web logic for Sudoku.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Sudoku : System.Web.Services.WebService, sudokubasis.IPropertyChanged, IRequiresSessionState
    {
        private sudokubasis.SudokuController Controller
        {
            get
            {
                if (Session != null)
                {
                    if (Session["controller"] == null)
                    {
                        Session["controller"] = new sudokubasis.SudokuController(this);
                    }
                    return Session["controller"] as sudokubasis.SudokuController;
                }
                return null;
            }
        }
       
        [WebMethod(EnableSession = true)]
        public string[] VulIn()
        {
            return FetchTable();
        }

        [WebMethod(EnableSession = true)]
        public string[] Hint()
        {
            Controller.Hint();
            return FetchTable();
        }

        [WebMethod(EnableSession = true)]
        public bool Controleer()
        {
            return Controller.CheckGame();
        }

        [WebMethod(EnableSession = true)]
        public string[] Reset()
        {
            Controller.ResetGame();
            return FetchTable();
        }

        [WebMethod(EnableSession = true)]
        public string[] Nieuw()
        {
            Controller.NewGame();
            return FetchTable();
        }

        [WebMethod(EnableSession = true)]
        public string[] Cheat()
        {
            Controller.Cheat();
            return FetchTable();
        }

        private string[] FetchTable()
        {
            string[] table = new string[81];

            int counter = 0;

            for (int x = 1 ; x <= 9 ; x++)
            {
                for (int y = 1 ; y <= 9 ; y++)
                {
                    table[counter] = Controller.GetValue(x, y);
                    counter++;
                }
            }
            return table;
        }

        public void NotifyPropertyChanged()
        {
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
}
