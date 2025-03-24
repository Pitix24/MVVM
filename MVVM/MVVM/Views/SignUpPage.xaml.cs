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
	public partial class SignUpPage : ContentPage
	{
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpViewModel();
            NavigationPage.SetHasNavigationBar(this, false); // Ocultar la barra de navegación
        }

        private async void TapGestureRecognizer_Tapped_Login(object sender, EventArgs e)
        {
            // Navegar a la página de inicio de sesión
            await Navigation.PopAsync();
        }
    }
}