using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimuladorDeNegocios.Models;

namespace SimuladorDeNegocios.Models
{
    public class SimuladorDeNegociosContext : DbContext
    {
        public SimuladorDeNegociosContext (DbContextOptions<SimuladorDeNegociosContext> options)
            : base(options)
        {
        }

        public DbSet<SimuladorDeNegocios.Models.producto_servicio> producto_servicio { get; set; }

        public DbSet<SimuladorDeNegocios.Models.estimacion_servicios> estimacion_servicios { get; set; }
    }
}
