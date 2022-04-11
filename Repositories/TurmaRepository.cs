using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Data;
using controle_escolar.Models;
using controle_escolar.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace controle_escolar.Repositories
{
    public class TurmaRepository : BaseRepository, ITurmaRepository
    {
        private readonly DataContext _context;
        public TurmaRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Turma>> GetAllTurmas()
        {
            return await _context.Turmas.ToListAsync();
        }
        
        
        public async Task<Turma> GetTurmaByIdAsync(int id)
        {
            return await _context.Turmas.FindAsync(id);
        }
        
    }
}