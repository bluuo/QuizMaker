using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    internal class HelperClass
    {
        void showScreen()
        {

        }

        public static void showMenu()
        {
            QuizMaker.Screens.Menu Menu = new QuizMaker.Screens.Menu();
            Menu.Show();
        }
    }
}
