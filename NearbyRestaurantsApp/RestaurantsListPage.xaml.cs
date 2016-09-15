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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NearbyRestaurantsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RestaurantsListPage : Page
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Location curloc = e.Parameter as Location;
            if (!string.IsNullOrWhiteSpace(curloc.CurrentLocation)) {
                textBlock.Text = "List of all restaurants nearby " + curloc.CurrentLocation;
            }

        }

        //private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        //{
        //    var curloc = (Location)e.NavigationParameter;

        //    if (!string.IsNullOrWhiteSpace(curloc.CurrentLocation))
        //    {
        //        textBlock.Text = "List of all restaurants nearby " + curloc.CurrentLocation;
        //    }
        //}

        public RestaurantsListPage()
        {
            this.InitializeComponent();
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
