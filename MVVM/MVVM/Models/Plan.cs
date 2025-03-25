using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Models
{
    public class Plan
    {
        public int Id { get; set; } // Identificador único del plan
        public string Nombre { get; set; } // Nombre del plan
        public string Ruta { get; set; } // Descripción de la ruta
        public List<string> PuntosDeInteres { get; set; } // Lista de puntos de interés
        public int DiasDeEstadia { get; set; } // Número de días de estadía
        public decimal CostoPorPersona { get; set; } // Costo por persona
        public decimal CostoPaquete2Personas { get; set; } // Costo para 2 personas
        public decimal CostoPaquete4Personas { get; set; } // Costo para 4 personas
        public string Descripcion { get; set; } // Descripción del plan
        public List<string> Tareas { get; set; } // Lista de tareas
        public string RutinasYEventos { get; set; } // Descripción de rutinas y eventos
    }
}
