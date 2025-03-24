using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
            NavigationPage.SetHasNavigationBar(this, false); // Ocultar la barra de navegación
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            // Navegar a la página de registro
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}