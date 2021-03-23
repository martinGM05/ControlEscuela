using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaPeñaNieto.Models
{
    
    public class Alumno
    {
        
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Fecha_Ingreso { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal promedio { get; set; }
        [Required]
        public int GrupoId { get; set; }
        public Grupos Grupo { get; set; }
    }
}
