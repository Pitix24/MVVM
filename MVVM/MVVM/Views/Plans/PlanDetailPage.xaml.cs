using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.Models;
using MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.Views.Plans
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlanDetailPage : ContentPage
	{
		public PlanDetailPage ()
		{
			InitializeComponent ();
        }
    }
}