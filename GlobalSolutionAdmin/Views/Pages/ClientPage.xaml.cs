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
    /// <summary>
    /// Interaction logic for ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
        }
        private void AddUserEvent(object sender, RoutedEventArgs e)
        {
            // Create a new instance of AddUserPopup window
            AddUserPopup popup = new AddUserPopup();

            // Option 1: Show the popup as a modal dialog (blocks interaction with main window)
            popup.ShowDialog(); // This method displays the popup

            // Option 2: Show the popup as a non-modal window (allows interaction with main window)
            // popup.Show(); // This method displays the popup, but requires additional logic for closing, dragging, etc.
        }

    }
}
