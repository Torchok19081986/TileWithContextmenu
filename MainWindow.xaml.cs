using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MahApps.Metro.Controls;

namespace TileWithContextmenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cm_Opened(object sender, RoutedEventArgs e)
        {

        }

        private void cm_Closed(object sender, RoutedEventArgs e)
        {

        }

        private void MetroWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void emailtilebtn_Click(object sender, RoutedEventArgs e)
        { 

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Color main = Color.FromRgb((byte)61, (byte)61, (byte)61);

            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.ResizeMode = ResizeMode.NoResize;

            this.NonActiveWindowTitleBrush = new SolidColorBrush(main);

            this.WindowTitleBrush = new SolidColorBrush(main);
        }
    }
}
