using System;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            // проверка удаление 1 строки
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // проверка добавление 2 строк
            // проверка удаление 2 строк
            //3.1первая строка добавлена
            //3.2первая строка добавлена
        }
    }
}
