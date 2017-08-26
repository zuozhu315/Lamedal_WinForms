using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lamedal_UIWinForms.Test.temp;
using Lamedal_UIWinForms.UControl.images;

namespace Lamedal_UIWinForms.Test
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
            //Application.Run(new Form1());
            Application.Run(new Form_Generate());
            //Application.Run(new Form_cSharpCode());
            //Application.Run(new ImageSetup_Form());
            
        }

        private static void System_Runtime()
        {
            // This is not used. Added to ensure System.Runtime dll is included when build
            var configuredTaskAwaitable = new System.Runtime.CompilerServices.ConfiguredTaskAwaitable();
        }
    }
}
