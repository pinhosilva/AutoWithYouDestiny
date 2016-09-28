using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WYD.Automatizar.Projeto.Core.WFA.View.Views;
using WYD.Automatizar.Projeto.Core.WFA.View.Views.PrincipalView;

namespace WYD.Automatizar.Projeto.Core.WFA.View
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
            Application.Run(new Principal());
        }
    }
}
