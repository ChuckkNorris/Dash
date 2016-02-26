using Dash.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Dash
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

//        private void Set() {
//            this.txtToDos.Document.SetText(Windows.UI.Text.TextSetOptions.FormatRtf, @"Dash
//•	Set Lunch w / Oliver->Click Opens calendar
//•	Build Angular2->Opens powerPoint
//Presentation
//•	Build Dash App->Opens Visual Studio
//•	             One Never - Ending List
//•	Available in a dash
//All Windows 10 Devices
//•	Always opens scrolled to the bottom.
//•	Keep your todos ALWAYS in the foreground



//");
//        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            Item myButton = (Item)((Button)sender).DataContext;
            StorageFolder myFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile toOpen = await myFolder.CreateFileAsync(myButton.FileName, CreationCollisionOption.OpenIfExists);

            await Launcher.LaunchFileAsync(toOpen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {

        }
    }
}
