using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MVVM.Models;

namespace MVVM.Services
{
    public static class ClienteService
    {
        // Lista de clientes registrados
        public static List<Cliente> ClientesRegistrados { get; set; } = new List<Cliente>();

        // Cliente activo después de iniciar sesión
        public static Cliente ClienteActivo { get; set; }

        // Método para buscar un cliente por correo y contraseña
        public static Cliente BuscarCliente(string correo, string contraseña)
        {
            return ClientesRegistrados.FirstOrDefault(c => c.Correo == correo && c.Contraseña == contraseña);
        }
    }
}
