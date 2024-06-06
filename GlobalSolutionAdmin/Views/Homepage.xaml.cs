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

namespace GlobalSolutionAdmin.Views
{
   
    public partial class Homepage : Page
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
            NavigationService.Navigate(new ClientPage());
        }

        private void LogoutEvent(object sender, MouseButtonEventArgs e)
        {
            LogoutWindow popup = new LogoutWindow();
            popup.ShowDialog();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new SitePage());
        }
    }
}
