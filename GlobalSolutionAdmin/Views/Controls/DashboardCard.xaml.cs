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
    /// Interaction logic for DashboardCard.xaml
    /// </summary>
    public partial class DashboardCard : UserControl
    {
        public DashboardCard()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
          DependencyProperty.Register("Title", typeof(string), typeof(DashboardCard), new PropertyMetadata(null));

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
          DependencyProperty.Register("Value", typeof(string), typeof(DashboardCard), new PropertyMetadata(null));

        public string ViewText
        {
            get { return (string)GetValue(ViewTextProperty); }
            set { SetValue(ViewTextProperty, value); }
        }

        public static readonly DependencyProperty ViewTextProperty =
          DependencyProperty.Register("ViewText", typeof(string), typeof(DashboardCard), new PropertyMetadata(null));
    }

}
