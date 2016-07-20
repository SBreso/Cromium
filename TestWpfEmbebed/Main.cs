using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace TestWpfEmbebed
{
    sealed class MainApp
    {
        public static CustomApplicationContext MyContext;

        [STAThread()]
        static internal void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                
               
                //Cef.Initialize(new CefSettings(), shutdownOnProcessExit: true, performDependencyCheck: true);

                MyContext = new CustomApplicationContext();

                Application.Run(MyContext);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
