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
	public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false); // Ocultar la barra de navegación
            BindingContext = new DetailViewModel(); // Configura el ViewModel
        }
    }
}