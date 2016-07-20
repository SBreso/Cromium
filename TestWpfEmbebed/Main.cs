using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Integration;

namespace TestWpfEmbebed
{
    sealed class MainApp
    {
        [STAThread()]
        static internal void Main()
        {
            try
            {
                MainWindow win = new MainWindow();
                ElementHost.EnableModelessKeyboardInterop(win);
                win.Show();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
