using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; } // Nuevo campo
        public string Ciudad { get; set; } // Nuevo campo
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
    }
}