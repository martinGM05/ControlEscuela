using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPeñaNieto.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Apellido { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String Cedula { get; set; }
        [Required]
        public int RolesId { get; set; }
        public Roles Roles { get; set; }
        [Required]
        public int SalonId { get; set; }
        public Grupos Salon { get; set; }
    }
}
