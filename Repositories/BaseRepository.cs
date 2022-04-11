using controle_escolar.Data;
using controle_escolar.Models;
using controle_escolar.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace controle_escolar.Repositories
{
    public class BaseRepository : IBaseRepository
    {

        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }


        public async Task<IEnumerable<Aluno>> GetAllAlunos()
        {
            return await _context.Alunos.ToListAsync();
        }

        public async Task<IEnumerable<Turma>> GetAllTurmas()
        {
            return await _context.Turmas.ToListAsync();
        }

        public async Task<IEnumerable<Chamada>> GetAllChamadas()
        {
            return await _context.Chamada.ToListAsync();
        }

        public async Task<Aluno> GetAlunoByIdAsync(int id)
        {
            return await _context.Alunos.FindAsync(id);
        }

        public async Task<Turma> GetTurmaByIdAsync(int id)
        {
            return await _context.Turmas.FindAsync(id);
        }


        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }


    }
}
