using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using controle_escolar.Models;
using controle_escolar.Repositories.Interfaces;

namespace controle_escolar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmaController : ControllerBase
    {

        private readonly IBaseRepository _repository;

        public TurmaController(IBaseRepository repository)
        {
            _repository = repository;
        }



        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var turmas = await _repository.GetAllTurmas();
            return turmas.Any()
                ? Ok(turmas)
                : BadRequest("Turmas não encontradass");
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetTurmaById(int id)
        {
            var turma = await _repository.GetTurmaByIdAsync(id);

            return turma != null
                ? Ok(turma)
                : BadRequest("Turma não encontrada");
        }
        

        [HttpPost]
        public async Task<IActionResult> Post(Turma turma)
        {
            try
            {
                _repository.Add(turma);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok("Turma salva com sucesso !");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} ");

            }

            return await _repository.SaveChangesAsync()
                ? Ok("Turma adicionada")
                : BadRequest("Erro ao adicionar a Turma");

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurma(int id)
        {
            if (id <= 0) return BadRequest("Turma não informada");

            var turma = await _repository.GetAlunoByIdAsync(id);

            if (turma == null)
                return NotFound("Turma não encontrada na base de dados");

            _repository.Delete(turma);

            return await _repository.SaveChangesAsync()
                ? Ok("Removido com sucesso")
                : BadRequest("Erro ao deletar Turma");

        }

    }
}
