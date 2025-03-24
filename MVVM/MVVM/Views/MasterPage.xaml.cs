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
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
            InitializeComponent();
            Title = "Menu"; // Configura el título de la página
            BindingContext = new MasterViewModel(); // Configura el ViewModel
        }
    }
}