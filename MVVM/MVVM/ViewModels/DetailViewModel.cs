using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class DetailViewModel
    {
        public ICommand NavigateToNosotrosCommand { get; }
        public ICommand OpenMenuCommand { get; }

        public DetailViewModel()
        {
            OpenMenuCommand = new Command(OpenMenu);
            NavigateToNosotrosCommand = new Command(async () => await NavigateToNosotros());
        }
        private void OpenMenu()
        {
            if (App.MasterD != null)
            {
                App.MasterD.IsPresented = true; // Abre el menú lateral
            }
        }

        private async Task NavigateToNosotros()
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail = new NavigationPage(new NosotrosPage());
            await Task.CompletedTask;
        }
    }
}
