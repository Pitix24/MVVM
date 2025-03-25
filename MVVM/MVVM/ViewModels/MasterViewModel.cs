using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Services;
using MVVM.Views;
using MVVM.Views.Plans;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        public string UserName { get; set; }
        public ICommand NavigateToNosotrosCommand { get; }
        public ICommand NavigateToContactoCommand { get; }
        public ICommand NavigateToInicioCommand { get; }
        public ICommand NavigateToPlanesCommand { get; }
        public ICommand LogoutCommand { get; }


        public MasterViewModel()
        {
            ActualizarClienteActivo();
            NavigateToNosotrosCommand = new Command(async () => await NavigateToNosotros());
            NavigateToContactoCommand = new Command(async () => await NavigateToContacto());
            NavigateToInicioCommand = new Command(async () => await NavigateToInicio());
            NavigateToPlanesCommand = new Command(async () => await NavigateToPlanes());
            LogoutCommand = new Command(CerrarSesion);
        }
        public void ActualizarClienteActivo()
        {
            if (ClienteService.ClienteActivo != null)
            {
                UserName = $"{ClienteService.ClienteActivo.Nombre} {ClienteService.ClienteActivo.ApellidoPaterno} {ClienteService.ClienteActivo.ApellidoMaterno}";
            }
            else
            {
                UserName = "Usuario desconocido";
            }

            // Notificar a la vista que la propiedad UserName ha cambiado
            OnPropertyChanged(nameof(UserName));
        }


        private async Task NavigateToNosotros()
        {
            try
            {
                App.MasterD.IsPresented = false;
                App.MasterD.Detail = new NavigationPage(new NosotrosPage());
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
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

        private async Task NavigateToPlanes()
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail = new NavigationPage(new PlanListView());
            await Task.CompletedTask;
        }

        private void CerrarSesion()
        {
            // Limpiar el cliente activo
            ClienteService.ClienteActivo = null;

            // Actualizar el nombre del cliente activo
            ActualizarClienteActivo();

            // Navegar al LoginPage
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}
