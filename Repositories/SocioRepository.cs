using Microsoft.EntityFrameworkCore;
using TrabajoFinal.Data;
using TrabajoFinal.Models;
using TrabajoFinal.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrabajoFinal.Repositories
{
    public class SocioRepository : ISocioRepository
    {
        private readonly GimnasioContext _context;

        public SocioRepository(GimnasioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Socio>> GetAllAsync()
        {
            return await _context.Socios.ToListAsync();  
        }

        public async Task<Socio> GetByIdAsync(int id)
        {
            return await _context.Socios.FindAsync(id);
        }

        public async Task AddAsync(Socio socio)
        {
            await _context.Socios.AddAsync(socio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Socio socio)
        {
            _context.Socios.Update(socio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var socio = await _context.Socios.FindAsync(id);
            if (socio != null)
            {
                _context.Socios.Remove(socio);
                await _context.SaveChangesAsync();
            }
        }
    }
}
