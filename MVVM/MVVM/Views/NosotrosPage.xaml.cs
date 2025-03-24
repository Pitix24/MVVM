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
	public partial class NosotrosPage : ContentPage
	{
		public NosotrosPage ()
		{
            InitializeComponent();
            BindingContext = new NosotrosViewModel(); // Asegúrate de que este ViewModel esté definido
        }
    }
}