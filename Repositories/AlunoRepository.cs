using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Data;
using controle_escolar.Models;
using controle_escolar.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace controle_escolar.Repositories
{
    public class AlunoRepository : BaseRepository, IAlunoRepository
    {
        private readonly DataContext _context;
        public AlunoRepository(DataContext context) : base(context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }
        
        
        public async Task<Aluno> GetAlunoByIdAsync(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }
        
    }
}