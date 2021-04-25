using ApiTest.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        //Usuarios ObtenerUsuario();
        ValueTask<Usuarios> ObtenerUsuario();
        ValueTask<List<Usuarios>> ObtenerUsuariosFecha();
        ValueTask<Usuarios> Actualizar(int Id, string Nombre);
    }
}
