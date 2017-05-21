using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TareaDeCiudades.DAL
{
    public class CiudadesDb : DbContext 
    {
        public CiudadesDb() : base("ConStr")
        {

        }
        public DbSet<Models.Ciudades> Ciudad { get; set; }
        public DbSet<Models.Provincias> Provincia { get; set; }

    }
}