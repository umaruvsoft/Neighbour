using System;

using Xamarin.Forms;

namespace Neighbour
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();
            MainPage = new Neighbour.Views.Menu.MainPage();
        }
    }
}
