using ElearningApi.BL.Interfaces;
using ElearningApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ElearningApi.BL.Services
{
    public class CursoService : ICurso
    {
        public async Task<List<Curso>> ObtenerCursos()
        {
            using (var conexion = new EleanirngDbContext())
            {
                var response = await conexion.Cursos.ToListAsync();
                return response;
            }
        }
    }
}
