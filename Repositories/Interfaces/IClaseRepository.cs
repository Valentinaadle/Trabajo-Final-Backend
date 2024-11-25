using System.Collections.Generic;
using System.Threading.Tasks;
using TrabajoFinal.Models;


namespace TrabajoFinal.Repositories.Interfaces
{
    public interface IClaseRepository
    {
        Task<IEnumerable<Clase>> GetAllAsync(); // Mostrar todas las clases
        Task<Clase> GetByIdAsync(int id); // Obtener una clase por su id
        Task AddAsync(Clase clase); // Agregar una nueva clase
        Task UpdateAsync(Clase clase); // Actualizar los datos de una clase
        Task DeleteAsync(int id); // Eliminar una clase por su id
    }
}
