using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } 
        public Cliente Cliente { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public DateTime FechaReserva { get; set; }
        public int NumeroDePersonas { get; set; } 
        public decimal CostoTotal { get; set; } 
    }
}
