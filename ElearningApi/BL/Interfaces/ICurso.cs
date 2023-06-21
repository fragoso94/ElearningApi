using ElearningApi.Models;

namespace ElearningApi.BL.Interfaces
{
    public interface ICurso
    {
        public Task<List<Curso>> ObtenerCursos();        
    }
}
