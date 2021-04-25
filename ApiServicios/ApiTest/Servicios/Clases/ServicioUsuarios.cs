using ApiTest.Dto;
using ApiTest.Entidades;
using ApiTest.Mapper.Interfaces;
using ApiTest.Repositorios.Interfaces;
using ApiTest.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Servicios.Clases
{
    public class ServicioUsuarios : IServicioUsuarios
    {
        private readonly IMapperUsuario _IMapperUsuario;
        private readonly IUsuariosRepositorio _IUsuariosRepositorio;

        public ServicioUsuarios(IMapperUsuario _IMapperUsuario,
                                IUsuariosRepositorio _IUsuariosRepositorio)
        {
            this._IMapperUsuario = _IMapperUsuario;
            this._IUsuariosRepositorio = _IUsuariosRepositorio;
        }
        public async ValueTask<DtoUsuarios> ObtenerUsuario()
        {
            Usuarios Usuario = await _IUsuariosRepositorio.ObtenerUsuario();
            DtoUsuarios UsuarioDto = _IMapperUsuario.MapEntidadDto(Usuario);
            return UsuarioDto;
        }

        public async ValueTask<List<DtoUsuarios>> ObtenerUsuariosFecha()
        {
            var Usuarios = await _IUsuariosRepositorio.ObtenerUsuariosFecha();
            var UsuariosDto = _IMapperUsuario.MapEntidadDtoList(Usuarios);
            return UsuariosDto;
        }
        public async ValueTask<DtoUsuarios> Actualizar(int Id, string Nombre)
        {
            var Usuarios = await _IUsuariosRepositorio.Actualizar(Id, Nombre);
            var UsuariosDto = _IMapperUsuario.MapEntidadDto(Usuarios);
            return UsuariosDto;
        }
    }
}
