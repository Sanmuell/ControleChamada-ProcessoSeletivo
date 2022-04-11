using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Models;

namespace controle_escolar.Repositories.Interfaces
{
    public interface IAlunoRepository :IBaseRepository
    {
        Task<IEnumerable<Aluno>> GetAllAlunos();
            
        Task<Aluno> GetAlunoByIdAsync(int id);
        
    }
}