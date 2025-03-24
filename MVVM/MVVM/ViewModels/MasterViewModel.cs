using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Views;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class MasterViewModel
    {
        public ICommand NavigateToNosotrosCommand { get; }
        public ICommand NavigateToContactoCommand { get; }
        public ICommand NavigateToInicioCommand { get; }

        public MasterViewModel()
        {
            NavigateToNosotrosCommand = new Command(async () => await NavigateToNosotros());
            NavigateToContactoCommand = new Command(async () => await NavigateToContacto());
            NavigateToInicioCommand = new Command(async () => await NavigateToInicio());
        }

        private async Task NavigateToNosotros()
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail = new NavigationPage(new NosotrosPage());
            await Task.CompletedTask;
        }

        private async Task NavigateToContacto()
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail = new NavigationPage(new ContactoPage());
            await Task.CompletedTask;
        }

        private async Task NavigateToInicio()
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail = new NavigationPage(new DetailPage());
            await Task.CompletedTask;
        }
    }
}
