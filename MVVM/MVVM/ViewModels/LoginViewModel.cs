using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Models;
using MVVM.Services;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private DatabaseService _databaseService;

        public string Correo { get; set; }
        public string Contraseña { get; set; }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            _databaseService = new DatabaseService();
            LoginCommand = new Command(async () => await OnLoginClicked());
        }

        private async Task OnLoginClicked()
        {
            Debug.WriteLine($"Correo: {Correo}, Contraseña: {Contraseña}");

            if (string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Contraseña))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            // Validar formato de correo
            if (!Correo.Contains("@") || !Correo.Contains("."))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingresa un correo válido.", "OK");
                return;
            }

            var cliente = await _databaseService.GetClienteAsync(Correo, Contraseña);

            if (cliente != null)
            {
                // Establecer el cliente activo
                ClienteService.ClienteActivo = cliente;

                await Application.Current.MainPage.DisplayAlert("Éxito", "Inicio de sesión exitoso. ¡Bienvenido!", "OK");

                // Navegar a MainPage después de iniciar sesión
                var mainPage = new MainPage();
                Application.Current.MainPage = mainPage;

                // Inicializar App.MasterD
                App.MasterD = mainPage;

                // Llamar a ActualizarClienteActivo en el MasterViewModel
                var masterViewModel = (MasterViewModel)mainPage.Flyout.BindingContext;
                masterViewModel.ActualizarClienteActivo();
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Correo o contraseña incorrectos.", "OK");
            }
        }
    }
}
