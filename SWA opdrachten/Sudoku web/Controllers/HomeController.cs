using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sudoku_web.Controllers
{
    public class HomeController : Controller, sudokubasis.IPropertyChanged
    {
        sudokubasis.SudokuController _controller;
        public ActionResult Index()
        {
            _controller = new sudokubasis.SudokuController(this);
            Initialize(ViewBag);
            ViewBag.controller = _controller;
            return View();
        }

        /// <summary>
        /// Initializes the game by putting all relevant numbers into the ViewBag
        /// </summary>
        /// <param name="ControllerBase">The ViewBag to be filled with numbers</param>
        private void Initialize(dynamic ControllerBase)
        {
            ViewBag.Lbl00 = _controller.GetValue(1, 1);
            ViewBag.Lbl01 = _controller.GetValue(1, 2);
            ViewBag.Lbl02 = _controller.GetValue(1, 3);
            ViewBag.Lbl03 = _controller.GetValue(1, 4);
            ViewBag.Lbl04 = _controller.GetValue(1, 5);
            ViewBag.Lbl05 = _controller.GetValue(1, 6);
            ViewBag.Lbl06 = _controller.GetValue(1, 7);
            ViewBag.Lbl07 = _controller.GetValue(1, 8);
            ViewBag.Lbl08 = _controller.GetValue(1, 9);

            ViewBag.Lbl10 = _controller.GetValue(2, 1);
            ViewBag.Lbl11 = _controller.GetValue(2, 2);
            ViewBag.Lbl12 = _controller.GetValue(2, 3);
            ViewBag.Lbl13 = _controller.GetValue(2, 4);
            ViewBag.Lbl14 = _controller.GetValue(2, 5);
            ViewBag.Lbl15 = _controller.GetValue(2, 6);
            ViewBag.Lbl16 = _controller.GetValue(2, 7);
            ViewBag.Lbl17 = _controller.GetValue(2, 8);
            ViewBag.Lbl18 = _controller.GetValue(2, 9);

            ViewBag.Lbl20 = _controller.GetValue(3, 1);
            ViewBag.Lbl21 = _controller.GetValue(3, 2);
            ViewBag.Lbl22 = _controller.GetValue(3, 3);
            ViewBag.Lbl23 = _controller.GetValue(3, 4);
            ViewBag.Lbl24 = _controller.GetValue(3, 5);
            ViewBag.Lbl25 = _controller.GetValue(3, 6);
            ViewBag.Lbl26 = _controller.GetValue(3, 7);
            ViewBag.Lbl27 = _controller.GetValue(3, 8);
            ViewBag.Lbl28 = _controller.GetValue(3, 9);

            ViewBag.Lbl30 = _controller.GetValue(4, 1);
            ViewBag.Lbl31 = _controller.GetValue(4, 2);
            ViewBag.Lbl32 = _controller.GetValue(4, 3);
            ViewBag.Lbl33 = _controller.GetValue(4, 4);
            ViewBag.Lbl34 = _controller.GetValue(4, 5);
            ViewBag.Lbl35 = _controller.GetValue(4, 6);
            ViewBag.Lbl36 = _controller.GetValue(4, 7);
            ViewBag.Lbl37 = _controller.GetValue(4, 8);
            ViewBag.Lbl38 = _controller.GetValue(4, 9);

            ViewBag.Lbl40 = _controller.GetValue(5, 1);
            ViewBag.Lbl41 = _controller.GetValue(5, 2);
            ViewBag.Lbl42 = _controller.GetValue(5, 3);
            ViewBag.Lbl43 = _controller.GetValue(5, 4);
            ViewBag.Lbl44 = _controller.GetValue(5, 5);
            ViewBag.Lbl45 = _controller.GetValue(5, 6);
            ViewBag.Lbl46 = _controller.GetValue(5, 7);
            ViewBag.Lbl47 = _controller.GetValue(5, 8);
            ViewBag.Lbl48 = _controller.GetValue(5, 9);

            ViewBag.Lbl50 = _controller.GetValue(6, 1);
            ViewBag.Lbl51 = _controller.GetValue(6, 2);
            ViewBag.Lbl52 = _controller.GetValue(6, 3);
            ViewBag.Lbl53 = _controller.GetValue(6, 4);
            ViewBag.Lbl54 = _controller.GetValue(6, 5);
            ViewBag.Lbl55 = _controller.GetValue(6, 6);
            ViewBag.Lbl56 = _controller.GetValue(6, 7);
            ViewBag.Lbl57 = _controller.GetValue(6, 8);
            ViewBag.Lbl58 = _controller.GetValue(6, 9);

            ViewBag.Lbl60 = _controller.GetValue(7, 1);
            ViewBag.Lbl61 = _controller.GetValue(7, 2);
            ViewBag.Lbl62 = _controller.GetValue(7, 3);
            ViewBag.Lbl63 = _controller.GetValue(7, 4);
            ViewBag.Lbl64 = _controller.GetValue(7, 5);
            ViewBag.Lbl65 = _controller.GetValue(7, 6);
            ViewBag.Lbl66 = _controller.GetValue(7, 7);
            ViewBag.Lbl67 = _controller.GetValue(7, 8);
            ViewBag.Lbl68 = _controller.GetValue(7, 9);

            ViewBag.Lbl70 = _controller.GetValue(8, 1);
            ViewBag.Lbl71 = _controller.GetValue(8, 2);
            ViewBag.Lbl72 = _controller.GetValue(8, 3);
            ViewBag.Lbl73 = _controller.GetValue(8, 4);
            ViewBag.Lbl74 = _controller.GetValue(8, 5);
            ViewBag.Lbl75 = _controller.GetValue(8, 6);
            ViewBag.Lbl76 = _controller.GetValue(8, 7);
            ViewBag.Lbl77 = _controller.GetValue(8, 8);
            ViewBag.Lbl78 = _controller.GetValue(8, 9);

            ViewBag.Lbl80 = _controller.GetValue(9, 1);
            ViewBag.Lbl81 = _controller.GetValue(9, 2);
            ViewBag.Lbl82 = _controller.GetValue(9, 3);
            ViewBag.Lbl83 = _controller.GetValue(9, 4);
            ViewBag.Lbl84 = _controller.GetValue(9, 5);
            ViewBag.Lbl85 = _controller.GetValue(9, 6);
            ViewBag.Lbl86 = _controller.GetValue(9, 7);
            ViewBag.Lbl87 = _controller.GetValue(9, 8);
            ViewBag.Lbl88 = _controller.GetValue(9, 9);
        }



        public void NotifyPropertyChanged()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}