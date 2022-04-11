using System.Collections.Generic;
using System.Threading.Tasks;
using controle_escolar.Models;

namespace controle_escolar.Repositories.Interfaces
{
    public interface IChamadaRepository :IBaseRepository
    {
        Task<IEnumerable<Chamada>> GetAllChamadas();
            
        Task<Chamada> GetChamadaByIdAsync(int id);
    }
}