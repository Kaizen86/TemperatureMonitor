using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void execute_app()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window());
        }

        [STAThread]
        static void Main()
        {
            try { execute_app(); }
            catch (Exception err) { MessageBox.Show("Unable to start application.\n\nFull error: "+err.Message); }
        }
    }
}
