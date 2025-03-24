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
	public partial class Detail : ContentPage
	{
		public Detail ()
		{
			InitializeComponent ();
		}

        private async void btnNosotros_Clicked(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            await App.MasterD.Detail.Navigation.PushAsync(new NosotrosPage());
        }
    }
}