using ApiTest.Dto;
using ApiTest.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Mapper.Interfaces
{
    public interface IMapperUsuario
    {
        DtoUsuarios MapEntidadDto(Usuarios Entidad);
        List<DtoUsuarios> MapEntidadDtoList(List<Usuarios> ListaEntidades);
    }
}
