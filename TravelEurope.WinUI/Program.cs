using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEurope.WinUI.Korisnici;

namespace TravelEurope.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmIndex());
            }
        }
    }
}
