using SchoolManagmentSystem_DevFayaz.PL.AuthenticationForms.UserControlForms;
using SchoolManagmentSystem_DevFayaz.PL.DashboardForms.SimpleForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboardfrm());
        }
    }
}
