using ApiTest.ContextoBD;
using ApiTest.Entidades;
using ApiTest.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest.Repositorios.Clases
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private readonly AppDbContext _appDbContext;

        public UsuariosRepositorio(AppDbContext _appDbContext)
        {
            this._appDbContext = _appDbContext;
        }

        public async ValueTask<Usuarios> ObtenerUsuario()
        {
            var UsuarioBd = await _appDbContext.Usuarios.FirstOrDefaultAsync(a => a.Id == 9);
            return UsuarioBd;
        }

        public async ValueTask<List<Usuarios>> ObtenerUsuariosFecha()
        {
            //var UsuariosBd = await _appDbContext.Usuarios.Where(a => a.Estado == 1).Take(10).ToListAsync();
            var UsuariosBd = await _appDbContext.Usuarios.Where(a => a.Estado == 1)
                                                         .Where(a => a.Nombre == "JHON ALEXIS")
                                                         .Take(10)
                                                         .ToListAsync();

            Usuarios BD = new Usuarios();
            await _appDbContext.Usuarios.AddAsync(BD);
            await _appDbContext.SaveChangesAsync();

            List<Usuarios> Lista = new List<Usuarios>();
            Usuarios BD1 = new Usuarios();
            Usuarios BD2 = new Usuarios();
            Usuarios BD3 = new Usuarios();

            Lista.Add(BD1);
            Lista.Add(BD2);
            Lista.Add(BD3);

            await _appDbContext.Usuarios.AddRangeAsync(Lista);
            await _appDbContext.SaveChangesAsync();


            //Para borrar siempre se consulta y luego se borra INVIDUAL
            var UsuarioBD = await _appDbContext.Usuarios.FirstOrDefaultAsync(a => a.Id == 9);
            _appDbContext.Usuarios.Remove(UsuarioBD);
            await _appDbContext.SaveChangesAsync();

            //Para borrar siempre se consulta y luego se borra LISTA

            var UsuariosBd2 = await _appDbContext.Usuarios.Where(a => a.Estado == 1)
                                             .Where(a => a.Nombre == "JHON ALEXIS")
                                             .Take(10)
                                             .ToListAsync();

            _appDbContext.Usuarios.RemoveRange(UsuarioBD);
            await _appDbContext.SaveChangesAsync();

            return UsuariosBd;
        }
        public async ValueTask<Usuarios> Actualizar(int Id, string Nombre)
        {
            var UsuarioBD = await _appDbContext.Usuarios.FirstOrDefaultAsync(a => a.Id == Id);

            if (UsuarioBD == null)
                throw new Exception("Usuario no encontrado");

            UsuarioBD.Nombre = Nombre;
            await _appDbContext.SaveChangesAsync();

            return UsuarioBD;
        }
    }
}
