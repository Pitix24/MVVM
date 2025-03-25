using System;
using System.Collections.Generic;
using System.Text;
using MVVM.Models;

namespace MVVM.Services
{
    public static class PlanService
    {
        public static List<Plan> PlanesDisponibles { get; set; } = new List<Plan>
    {
        new Plan
        {
            Id = 1,
            Nombre = "Aventura en la Selva",
            Ruta = "Selva Amazónica",
            PuntosDeInteres = new List<string> { "Cataratas", "Reserva Natural", "Pueblo Indígena" },
            DiasDeEstadia = 5,
            CostoPorPersona = 500,
            CostoPaquete2Personas = 950,
            CostoPaquete4Personas = 1800,
            Descripcion = "Explora la rica biodiversidad de la selva amazónica.",
            Tareas = new List<string> { "Visitar cataratas", "Explorar la reserva", "Interacción con comunidades indígenas" },
            RutinasYEventos = "Caminatas guiadas, talleres de artesanía, avistamiento de fauna."
        },
        new Plan
        {
            Id = 2,
            Nombre = "Tour por la Montaña",
            Ruta = "Cordillera de los Andes",
            PuntosDeInteres = new List<string> { "Mirador", "Lago Escondido", "Cueva de Cristal" },
            DiasDeEstadia = 3,
            CostoPorPersona = 300,
            CostoPaquete2Personas = 570,
            CostoPaquete4Personas = 1100,
            Descripcion = "Disfruta de impresionantes vistas de los Andes.",
            Tareas = new List<string> { "Caminata al mirador", "Navegación en el lago", "Exploración de cuevas" },
            RutinasYEventos = "Trekking, fotografía de paisajes, actividades culturales."
        },
        new Plan
        {
            Id = 3,
            Nombre = "Descubre Ica",
            Ruta = "Ica, Perú",
            PuntosDeInteres = new List<string> { "Huacachina", "Bodegas de Vino", "Líneas de Nazca" },
            DiasDeEstadia = 2,
            CostoPorPersona = 250,
            CostoPaquete2Personas = 480,
            CostoPaquete4Personas = 900,
            Descripcion = "Un viaje a Ica para disfrutar de sus paisajes y cultura.",
            Tareas = new List<string> { "Visitar Huacachina", "Tour de bodegas", "Sobrevuelo de las Líneas de Nazca" },
            RutinasYEventos = "Sandboarding, degustación de vinos, avistamiento de geoglifos."
        },
        new Plan
        {
            Id = 4,
            Nombre = "Cuzco Mágico",
            Ruta = "Cuzco, Perú",
            PuntosDeInteres = new List<string> { "Machu Picchu", "Sacsayhuamán", "Valle Sagrado" },
            DiasDeEstadia = 4,
            CostoPorPersona = 600,
            CostoPaquete2Personas = 1150,
            CostoPaquete4Personas = 2200,
            Descripcion = "Explora la historia y cultura del antiguo Imperio Inca.",
            Tareas = new List<string> { "Visitar Machu Picchu", "Explorar Sacsayhuamán", "Recorrido por el Valle Sagrado" },
            RutinasYEventos = "Trekking, visitas guiadas, talleres de artesanía."
        }
    };
    }
}
