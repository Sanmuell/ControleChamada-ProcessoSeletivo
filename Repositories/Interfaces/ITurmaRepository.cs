using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Models;

namespace controle_escolar.Repositories.Interfaces
{
    public interface ITurmaRepository :IBaseRepository
    {
        Task<IEnumerable<Turma>> GetAllTurmas();
            
        Task<Turma> GetTurmaByIdAsync(int id);
        
    }
}