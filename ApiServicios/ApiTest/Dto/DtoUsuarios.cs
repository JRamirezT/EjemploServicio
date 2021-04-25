using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Dto
{
    public class DtoUsuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public int Estado { get; set; }
        public string EstadoDescripcion { get; set; }
    }
}
