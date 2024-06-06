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

namespace GlobalSolutionAdmin.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Sidebar.xaml
    /// </summary>
    public partial class Sidebar : UserControl
    {
  
        public Sidebar()
        {
            InitializeComponent();
            
        }

        private void NavigateToHome(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            var navigationService = NavigationService.GetNavigationService(this);

            if (navigationService != null)
            {
                navigationService.Navigate(new Homepage
                    ());
            }
        }


        private void NavigateToClient(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            var navigationService = NavigationService.GetNavigationService(this);

            if (navigationService != null)
            {
                navigationService.Navigate(new ClientPage());
            }
        }

        private void LogoutPopup(object sender, MouseButtonEventArgs e)
        {
            LogoutWindow popup = new LogoutWindow();
            popup.ShowDialog();
        }

        private void NavigateToSite(object sender, MouseButtonEventArgs e)
        {
            var navigationService = NavigationService.GetNavigationService(this);

            if (navigationService != null)
            {
                navigationService.Navigate(new SitePage());
            }
        }
    }
}
