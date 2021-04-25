using ApiTest.Dto;
using ApiTest.Entidades;
using ApiTest.Mapper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Mapper.Clases
{
    public class MapperUsuario : IMapperUsuario
    {
        public DtoUsuarios MapEntidadDto(Usuarios Entidad)
        {
            DtoUsuarios ObjUsuario = new DtoUsuarios()
            {
                Id = Entidad.Id,
                Estado = Entidad.Estado,
                Nombre = Entidad.Nombre,
                FechaActualizacion = Entidad.FechaActualizacion
            };

            if (Entidad.Estado == 1)
                ObjUsuario.EstadoDescripcion = "Activo";
            else if (Entidad.Estado == 2)
                ObjUsuario.EstadoDescripcion = "Inactivo";
            else
                ObjUsuario.EstadoDescripcion = "Pendiente Validacion";

            return ObjUsuario;

        }

        public List<DtoUsuarios> MapEntidadDtoList(List<Usuarios> ListaEntidades)
        {
            List<DtoUsuarios> Lista = new List<DtoUsuarios>();
            foreach (var item in ListaEntidades)
            {
                var UsuarioDto = MapEntidadDto(item);
                Lista.Add(UsuarioDto);
            }
            return Lista;
        }

    }
}
