using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Nombre = "Andrik De La Cruz Martinez";
            string Matricula = "1863369";
                       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new splashScreen());
            Application.Run(new principal(Nombre,Matricula));
        }
    }
}
