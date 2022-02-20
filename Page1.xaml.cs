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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            Progression();
        }

        string AchieveName1 = "First Blood", AchieveName2 = "The Four Horsemen", AchieveName3 = "Circles of Hell", AchieveName4 = "Quarter Millenial", AchieveName5 = "Fitty", AchieveName6 = "One Hundo", AchieveName7 = "The Number of the Beast", AchieveName8 = "It's over 9000";

        private void Progression()
        {
            lblAchieve1.Content = AchieveName1+": " + (Application.Current as App).iClicks + "/1";
            lblAchieve2.Content = AchieveName2+": " + (Application.Current as App).iClicks + "/4";
            lblAchieve3.Content = AchieveName3+": " + (Application.Current as App).iClicks + "/9";
            lblAchieve4.Content = AchieveName4+": " + (Application.Current as App).iClicks + "/25";
            lblAchieve5.Content = AchieveName5+": " + (Application.Current as App).iClicks + "/50";
            lblAchieve6.Content = AchieveName6+": " + (Application.Current as App).iClicks + "/100";
            lblAchieve7.Content = AchieveName7+": " + (Application.Current as App).iClicks + "/666";
            lblAchieve8.Content = AchieveName8+": " + (Application.Current as App).iClicks + "/9001";

            barAchieve1.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve1.Maximum)
            {
                barAchieve1.Value = barAchieve1.Maximum;
                lblAchieve1.Content = AchieveName1 + ": " + barAchieve1.Maximum + "/1";
            }
            barAchieve2.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve2.Maximum)
            {
                barAchieve2.Value = barAchieve2.Maximum;
                lblAchieve2.Content = AchieveName2 + ": " + barAchieve2.Maximum + "/4";
            }
            barAchieve3.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve3.Maximum)
            {
                barAchieve3.Value = barAchieve3.Maximum;
                lblAchieve3.Content = AchieveName3 + ": " + barAchieve3.Maximum + "/9";
            }
            barAchieve4.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve4.Maximum)
            {
                barAchieve4.Value = barAchieve4.Maximum;
                lblAchieve4.Content = AchieveName4 + ": " + barAchieve4.Maximum + "/25";
            }
            barAchieve5.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve5.Maximum)
            {
                barAchieve5.Value = barAchieve5.Maximum;
                lblAchieve5.Content = AchieveName5 + ": " + barAchieve5.Maximum + "/50";
            }
            barAchieve6.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve6.Maximum)
            {
                barAchieve6.Value = barAchieve6.Maximum;
                lblAchieve6.Content = AchieveName6 + ": " + barAchieve6.Maximum + "/100";
            }
            barAchieve7.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve7.Maximum)
            {
                barAchieve7.Value = barAchieve7.Maximum;
                lblAchieve7.Content = AchieveName7 + ": " + barAchieve7.Maximum + "/9001";
            }
            barAchieve8.Value = (Application.Current as App).iClicks;
            if ((Application.Current as App).iClicks == barAchieve8.Maximum)
            {
                barAchieve8.Value = barAchieve8.Maximum;
                lblAchieve8.Content = AchieveName8 + ": " + barAchieve8.Maximum + "/9001";
            }
        }
    }
}
