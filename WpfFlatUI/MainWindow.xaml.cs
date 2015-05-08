using System.Windows;
using System.Windows.Input;
using System.Windows.Shell;

namespace WpfFlatUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WindowChrome chrome = new WindowChrome();
            chrome.CaptionHeight = 0.0;
            WindowChrome.SetWindowChrome(this, chrome);
        }

        private void OnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
