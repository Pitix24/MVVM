using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using MVVM.Models;
using MVVM.Services;
using Xamarin.Forms;

namespace MVVM.ViewModels
{

    public class SignUpViewModel : BaseViewModel
    {
        private DatabaseService _databaseService;

        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.Today;
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }

        public ICommand SignUpCommand { get; }

        public SignUpViewModel()
        {
            _databaseService = new DatabaseService();
            SignUpCommand = new Command(async () => await OnSignUpClicked());
        }

        private async Task OnSignUpClicked()
        {
            // Validaciones
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(ApellidoPaterno) ||
                string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Contraseña) ||
                string.IsNullOrEmpty(ConfirmarContraseña) || string.IsNullOrEmpty(Telefono) ||
                string.IsNullOrEmpty(Ciudad))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            if (!Correo.Contains("@") || !Correo.Contains("."))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingresa un correo válido.", "OK");
                return;
            }

            if (Telefono.Length == 9 || !Telefono.All(char.IsDigit))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingresa un número de teléfono válido.", "OK");
                return;
            }

            if (Contraseña.Length < 6)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "La contraseña debe tener al menos 6 caracteres.", "OK");
                return;
            }

            if (Contraseña != ConfirmarContraseña)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
                return;
            }

            // Crear un nuevo cliente
            var nuevoCliente = new Cliente
            {
                Id = GenerarNuevoId(), // Método para generar un nuevo ID
                Nombre = Nombre,
                ApellidoPaterno = ApellidoPaterno,
                ApellidoMaterno = ApellidoMaterno,
                FechaNacimiento = FechaNacimiento,
                Correo = Correo,
                Telefono = Telefono,
                Ciudad = Ciudad,
                Contraseña = Contraseña
            };

            // Agregar el cliente a la lista estática
            ClienteService.ClientesRegistrados.Add(nuevoCliente);

            await Application.Current.MainPage.DisplayAlert("Éxito", "Cuenta creada exitosamente.", "OK");

            // Redirigir al usuario a la página de Login
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        // Método para generar un nuevo ID (puedes usar un contador o GUID)
        private int GenerarNuevoId()
        {
            return ClienteService.ClientesRegistrados.Count + 1; // Simple contador
        }

    }
}
