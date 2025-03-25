using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactoPage : ContentPage
	{
		public ContactoPage ()
		{
            InitializeComponent();
            BindingContext = new ContactoViewModel(); // Asegúrate de que este ViewModel esté definido
        }
    }
}