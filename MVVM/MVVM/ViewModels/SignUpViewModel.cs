using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
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
            SignUpCommand = new Command(OnSignUpClicked);
        }

        private async void OnSignUpClicked()
        {
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(ApellidoPaterno) ||
                string.IsNullOrEmpty(Correo) || string.IsNullOrEmpty(Contraseña) ||
                string.IsNullOrEmpty(ConfirmarContraseña) || string.IsNullOrEmpty(Telefono) ||
                string.IsNullOrEmpty(Ciudad))
            {
                Debug.WriteLine($"Nombre: {Nombre}, ApellidoPaterno: {ApellidoPaterno}, Correo: {Correo}, Telefono: {Telefono}, Ciudad: {Ciudad}");
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
                return;
            }

            // Validar formato de correo
            if (!Correo.Contains("@") || !Correo.Contains("."))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingresa un correo válido.", "OK");
                return;
            }

            // Validar formato del teléfono (mínimo 10 dígitos)
            if (Telefono.Length < 10 || !Telefono.All(char.IsDigit))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Por favor, ingresa un número de teléfono válido.", "OK");
                return;
            }

            // Validar longitud de la contraseña
            if (Contraseña.Length < 6)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "La contraseña debe tener al menos 6 caracteres.", "OK");
                return;
            }

            // Validar que las contraseñas coincidan
            if (Contraseña != ConfirmarContraseña)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Las contraseñas no coinciden.", "OK");
                return;
            }

            var nuevoCliente = new Cliente
            {
                Nombre = Nombre,
                ApellidoPaterno = ApellidoPaterno,
                ApellidoMaterno = ApellidoMaterno,
                FechaNacimiento = FechaNacimiento,
                Correo = Correo,
                Telefono = Telefono,
                Ciudad = Ciudad,
                Contraseña = Contraseña
            };

            await _databaseService.InsertClienteAsync(nuevoCliente);
            await Application.Current.MainPage.DisplayAlert("Éxito", "Cuenta creada exitosamente.", "OK");

            // Redirigir al usuario a la página de Login
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
