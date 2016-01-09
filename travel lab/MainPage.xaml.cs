using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace travel_lab
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void create_new_trip_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(new_trip));
        }

        private void view_existing_trip_button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(View_prev));
        }

        private void Add_profile_button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Add_profile));
        }
    }
}
