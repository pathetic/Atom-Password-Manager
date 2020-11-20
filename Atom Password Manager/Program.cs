using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atom_Password_Manager
{
    static class Program
    {
        public static bool CorrectPassword = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            if (CorrectPassword)
                Application.Run(new MainAtomForm());
        }
    }
}
