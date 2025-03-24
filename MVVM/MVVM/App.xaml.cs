using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
    public partial class App : Application
    {
        public static MainPage MasterD { get; set; }

        public App ()
        {
            InitializeComponent();

            // Configura la página principal como LoginPage
            MainPage = new NavigationPage(new Views.LoginPage());

        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
