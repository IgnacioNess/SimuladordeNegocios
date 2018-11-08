using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SimuladorDeNegocios.Models
{
    public class producto_servicio
    {
        [Key]
        public int id_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre debe de tener de 3 a 50 caracteres")]
        public string nombe { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El Nombre del producto debe de tener de 3 a 50 caracteres")]
        public string producto_nombre { get; set; }
        
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "La unidad produccion debe de tener de 1 a 50 caracteres")]
        public string unidad_produccion { get; set; }

        public int produccion_mensual { get; set; }
        public Double costo_unitario { get; set; }
        public Double margen_utilidad { get; set; }
        public Double precio_publico { get; set; }
        public int datos_empre_id_empresa { get; set; }


    }
}
