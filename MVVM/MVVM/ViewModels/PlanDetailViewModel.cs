using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM.ViewModels;

namespace MVVM.ViewModels
{

    public class PlanDetailViewModel : BaseViewModel
    {
        public Plan PlanSeleccionado { get; set; }
        public ICommand ReservarCommand { get; }

        public PlanDetailViewModel(Plan plan)
        {
            PlanSeleccionado = plan;
            ReservarCommand = new Command(async () => await Reservar());
        }

        private async Task Reservar()
        {
            // Aquí puedes implementar la lógica para realizar la reserva
            await Application.Current.MainPage.DisplayAlert("Reserva", $"Reserva realizada para el plan: {PlanSeleccionado.Nombre}", "OK");
        }
    }
}
