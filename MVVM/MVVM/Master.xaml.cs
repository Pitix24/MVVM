using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : ContentPage
	{
		public Master()
		{
            InitializeComponent();

            // Aquí puedes agregar el contenido del menú lateral
            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Menú Lateral", FontSize = 24, HorizontalOptions = LayoutOptions.Center }
                    // Agrega más elementos de menú aquí
                }
            };
        }

        private async void btnNosotros_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new NosotrosPage());
        }

        private async void btnContacto_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new ContactoPage());
        }

        private async void btnInicio_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new Detail());
        }
    }
}