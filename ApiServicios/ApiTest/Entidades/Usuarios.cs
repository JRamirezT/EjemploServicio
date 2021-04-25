using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Entidades
{
    [Table("FW_TUSUARIO")]
    public class Usuarios
    {
        [Key, Column("usu_id")]
        public int Id { get; set; }

        [Column("usu_nombres")]
        public string Nombre { get; set; }

        [Column("usu_fecha_modificacion")]
        public DateTime FechaActualizacion { get; set; }

        [Column("usu_estado")]
        public int Estado { get; set; }

        [Column("usu_clave")]
        public string Clave { get; set; }

    }
}
