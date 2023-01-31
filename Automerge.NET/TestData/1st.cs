//using System;
//
//using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automerge.NET
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {// проверка add 1 строка
            //1.1первая строка добавлена
            Application.EnableVisualStyles();
            // проверка удаление 1 строки
            Application.Run(new MainForm());
            // проверка добавление 2 строк
            //2.1первая строка добавлена
            //2.2первая строка добавлена
            // проверка удаление 2 строк
        }
    }
}
89
90