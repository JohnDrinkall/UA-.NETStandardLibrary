using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Server.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Server
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Backing field for the view model.
        /// </summary>
        MainPageViewModel model;

#region Constructors
        /// <summary>
        /// Initializes the MainPage
        /// </summary>
        public MainPage()
        {
            model = new MainPageViewModel();
            this.DataContext = model;
        }
#endregion

        // When the application has been navigaed to.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            model.OnNavigatedTo(e);
        }
    }
}
