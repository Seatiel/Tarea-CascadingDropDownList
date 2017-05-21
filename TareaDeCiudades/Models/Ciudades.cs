using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaDeCiudades.Models
{
    public class Ciudades
    {
        public int ProvinciaId { get; set; }
        public int CiudadesId { get; set; }
        public string NombreCiudad { get; set; }

        public static IQueryable<Ciudades> GetCiudades()
        {
            return new List<Ciudades>
            {
                new Ciudades{ ProvinciaId = 1, CiudadesId = 1, NombreCiudad = "Azua de Compostela" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 2, NombreCiudad = "Estebanía" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 3, NombreCiudad = "Guayabal" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 4, NombreCiudad = "Las Charcas" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 5, NombreCiudad = "Las Yayas de Viajama" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 6, NombreCiudad = "Padre Las Casas" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 7, NombreCiudad = "Peralta" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 8, NombreCiudad = "Pueblo Viejo" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 9, NombreCiudad = "Sabana Yegua" },
                new Ciudades{ ProvinciaId = 1, CiudadesId = 10, NombreCiudad = "Tábara Arriba" },
                new Ciudades{ ProvinciaId = 2, CiudadesId = 1, NombreCiudad = "Neiba" },
                new Ciudades{ ProvinciaId = 2, CiudadesId = 2, NombreCiudad = "Galván" },
                new Ciudades{ ProvinciaId = 2, CiudadesId = 3, NombreCiudad = "Los Ríos" },
                new Ciudades{ ProvinciaId = 2, CiudadesId = 4, NombreCiudad = "Tamayo" },
                new Ciudades{ ProvinciaId = 2, CiudadesId = 5, NombreCiudad = "Villa Jaragua" }
            }.AsQueryable();
        }
    }
}