using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TileWithContextmenu.UserControls
{
    /// <summary>
    /// Interaktionslogik für UserControlMain.xaml
    /// </summary>
    public partial class UserControlMain : UserControl
    {
        public UserControlMain()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cm_Opened(object sender, RoutedEventArgs e)
        {

        }

        private void cm_Closed(object sender, RoutedEventArgs e)
        {

        }

        private void EMail_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Instance.CurrentIndex = 1;
        }

        private void Another_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Instance.CurrentIndex = 2;
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Instance.CurrentIndex = 3;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Color main = Color.FromRgb((byte)61, (byte)61, (byte)61);

                Color vtegreen = Color.FromRgb(0, 148, 134);

                mainframe.Background = new SolidColorBrush(main);

                userssettings.Background = new SolidColorBrush(vtegreen);

                mailsettings.Background = new SolidColorBrush(vtegreen);

                settings.Background = new SolidColorBrush(vtegreen);

            }
            catch(Exception ex)
            {

            }
        }

        private void taskscheduler_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Instance.CurrentIndex = 4;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeigen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eigenschaten_Click(object sender, RoutedEventArgs e)
        {

        }

        private void info_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
