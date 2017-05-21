using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TareaDeCiudades.Models
{
    public class Provincias
    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }

        public static IQueryable<Provincias> GetProvincias()
        {
            return new List<Provincias>
            {
                new Provincias{ ProvinciaId = 1, NombreProvincia = "Azua" },
                new Provincias{ ProvinciaId = 2, NombreProvincia = "Bahoruco" }
            }.AsQueryable();
        }
    }
}