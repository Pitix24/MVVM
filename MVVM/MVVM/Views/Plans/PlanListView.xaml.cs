using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Views.Plans
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlanListView : ContentPage
	{
		public PlanListView ()
		{
			InitializeComponent ();
            BindingContext = new PlanViewModel(); // Asignar el ViewModel
        }
    }
}