using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM.Views;
using MVVM.ViewModels;

namespace MVVM
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Configura la página Flyout (menú lateral)
            Flyout = new MasterPage();

            // Configura la página Detail (contenido principal)
            Detail = new NavigationPage(new DetailPage())
            {
                BarBackgroundColor = Color.Transparent,
                BarTextColor = Color.White
            };

            // Configura el comportamiento del menú
            FlyoutLayoutBehavior = FlyoutLayoutBehavior.Popover; // O usa Split si prefieres un menú fijo
        }
    }
}
