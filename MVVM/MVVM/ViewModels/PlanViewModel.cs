using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM.Models;
using MVVM.Services;
using MVVM.Views.Plans;

namespace MVVM.ViewModels
{
    public class PlanViewModel : BaseViewModel
    {
        public ObservableCollection<Plan> Planes { get; set; } // Lista de planes
        public Plan PlanSeleccionado { get; set; } // Plan seleccionado para los detalles
        public ICommand ReservarCommand { get; }
        public ICommand VerDetallesCommand { get; }

        public PlanViewModel()
        {
            // Inicializar la lista de planes
            Planes = new ObservableCollection<Plan>(PlanService.PlanesDisponibles);

            // Comando para ver los detalles de un plan
            VerDetallesCommand = new Command<Plan>(async (plan) => await VerDetalles(plan));

        }

        private async Task VerDetalles(Plan plan)
        {
            // Establecer el plan seleccionado
            PlanSeleccionado = plan;

            // Navegar a la página de detalles
            var planDetailPage = new PlanDetailPage();
            planDetailPage.BindingContext = this; // Usar el mismo ViewModel
            App.MasterD.IsPresented = false; // Cerrar el menú lateral
            App.MasterD.Detail = new NavigationPage(planDetailPage); // Navegar a la página de detalles
            await Task.CompletedTask;
        }
        private async Task Reservar()
        {
            // Aquí puedes implementar la lógica para realizar la reserva
            await Application.Current.MainPage.DisplayAlert("Reserva", $"Reserva realizada para el plan: {PlanSeleccionado.Nombre}", "OK");
        }

    }
}
