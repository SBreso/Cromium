using CefSharp;
using System.Windows;

namespace TestWpfEmbebed
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Browser.LoadHtml("./WLogin.html", "./WLogin.html");
        }
    }
}
