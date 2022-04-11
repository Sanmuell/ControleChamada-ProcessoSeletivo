using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Data;
using controle_escolar.Models;
using controle_escolar.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace controle_escolar.Repositories
{
    public class ChamadaRepository : BaseRepository, IChamadaRepository
    {
        private readonly DataContext _context;
        public ChamadaRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Chamada>> GetAllChamadas()
        {
            return await _context.Chamada.ToListAsync();
        }

        public async Task<Chamada> GetChamadaByIdAsync(int id)
        {
            return await _context.Chamada.FindAsync(id);
        }
    }
}