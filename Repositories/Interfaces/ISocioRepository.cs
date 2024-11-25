using System.Collections.Generic;
using System.Threading.Tasks;
using TrabajoFinal.Models; 
namespace TrabajoFinal.Repositories.Interfaces
{
    public interface ISocioRepository
    {
        Task<IEnumerable<Socio>> GetAllAsync();  // Mostrar todos los socios
        Task<Socio> GetByIdAsync(int id); // Obtener un socio por su id
        Task AddAsync(Socio socio); // Agregar un socio
        Task UpdateAsync(Socio socio); // Actualizar los datos de un socio
        Task DeleteAsync(int id); // Borrar los dstos de un socio a través de su id
    }
}
