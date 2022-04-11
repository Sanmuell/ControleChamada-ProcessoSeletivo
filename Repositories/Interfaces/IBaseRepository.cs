using controle_escolar.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace controle_escolar.Repositories.Interfaces
{
    public interface IBaseRepository
    {
        public void Add<T>(T entity) where T : class;

        public void Update<T>(T entity) where T : class;

        public void Delete<T>(T entity) where T : class;

        Task<IEnumerable<Aluno>> GetAllAlunos();

        Task<IEnumerable<Turma>> GetAllTurmas();

        Task<IEnumerable<Chamada>> GetAllChamadas();

        Task<bool> SaveChangesAsync();

    }
}
