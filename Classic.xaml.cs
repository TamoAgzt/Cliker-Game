using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace clickerApp
{
    /// <summary>
    /// Interaction logic for Classic.xaml
    /// </summary>
    public partial class Classic : Page
    {
        public Classic()
        {
            InitializeComponent();
            Progression();
        }

        private void btnClicker_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current as App).iClicks++;
            Progression();
        }

        private void Progression()
        {
            lblClickCount.Content = (Application.Current as App).iClicks + " clicks";
        }
    }
}
