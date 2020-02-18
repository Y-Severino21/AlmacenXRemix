using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenXRemix.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Column(TypeName ="varchar(32)")]
        [Required]
        public string Cedula { get; set; }
        [Column(TypeName = "varchar(12)")]
        public string CNombre{ get; set; }
        [Column(TypeName = "varchar(24)")]
        public string Direccion { get; set; }
        [Column(TypeName ="varchar(82)")]
        public string Correo { get; set; }
        [Column(TypeName = "varchar(48)")]
        public string Genero { get; set; }
        
    }
}
