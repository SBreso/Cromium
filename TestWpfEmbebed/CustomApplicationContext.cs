using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace TestWpfEmbebed
{
    internal class CustomApplicationContext : ApplicationContext
    { 

        public CustomApplicationContext()
        {
            MainWindow win = new MainWindow();
            ElementHost.EnableModelessKeyboardInterop(win);
            win.Show();
        }
    }
}