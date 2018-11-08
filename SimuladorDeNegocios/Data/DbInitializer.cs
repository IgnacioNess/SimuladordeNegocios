using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimuladorDeNegocios.Models;

namespace SimuladorDeNegocios.Data
{
    public class DbInitializer
    {
        public static void Initialize(SimuladorDeNegociosContext context)
        {
            context.Database.EnsureCreated();
            if (context.producto_servicio.Any())
            {
                return;
            }
            var producto_servicio = new producto_servicio[]
            {
              //new Alumno {Nombres="Leonel", ApellidoP="Gonzalez", ApellidoM ="Vidales", Edad =20, NumTelefono = "7321080568", Domicilio = "Av. Pungarabato Pte S/N", Colonia="Morelos", Ciudad ="Cd. Altamirano", CP =40660, Estado ="Guerrero"}
            };

            foreach (producto_servicio a in producto_servicio)
            {
                context.producto_servicio.Add(a);

            }
            context.SaveChanges();

        }
    }
}
