using OperationScreens;
using System;
using System.Windows.Forms;

namespace MainFlightSimulator
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_dashboard());
        }
    }
}
