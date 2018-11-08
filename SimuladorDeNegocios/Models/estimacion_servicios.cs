using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimuladorDeNegocios.Models
{
    public class estimacion_servicios
    {
        [Key]

        public int  id_suscripcion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "La unidad de produccion debe de tener de 1 a 50 caracteres")]
        public string unidad_produccion { get; set; }

        public int total_suscripciones { get; set; }

        public Double total_mensual { get; set; }

        public int producto_servicios_id_producto { get; set; }
    }
}
