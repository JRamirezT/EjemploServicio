using ApiTest.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Servicios.Interfaces
{
    public interface IServicioUsuarios
    {
        //DtoUsuarios ObtenerUsuario();
        ValueTask<DtoUsuarios> ObtenerUsuario();
        ValueTask<List<DtoUsuarios>> ObtenerUsuariosFecha();
        ValueTask<DtoUsuarios> Actualizar(int Id, string Nombre);
    }
}
