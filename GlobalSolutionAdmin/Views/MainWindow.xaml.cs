using GlobalSolutionAdmin.Views;
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

namespace GlobalSolutionAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Frame navigationFrame = (Frame)Window.GetWindow(this).FindName("navigationFrame");

            if (navigationFrame != null)
            {
                navigationFrame.Content = null;
                navigationFrame.Navigate(new ClientPage());
            }
            else
            {
                // Handle the case where Frame is not found (optional)
                MessageBox.Show("Navigation Frame not found!");
            }

            
        }
    }
}
