using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Studentski_servis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string baza = Application.ExecutablePath;
            int ime = baza.LastIndexOf('\\');
            baza = baza.Substring(0, ime) + "\\Baza.sdf";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new pocetna(baza));
        }
    }
}
