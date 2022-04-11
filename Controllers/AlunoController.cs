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
    public class AlunoController : ControllerBase
    {

        private readonly IAlunoRepository _repository;

        public AlunoController(IAlunoRepository repository)
        {
            _repository = repository;
        }
        

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var alunos = await _repository.GetAllAlunos();
            return alunos.Any()
                ? Ok(alunos)
                : BadRequest("Alunos(a) não encontrados");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAlunoById(int id)
        {
            var aluno = await _repository.GetAlunoByIdAsync(id);

            return aluno != null
                ? Ok(aluno)
                : BadRequest("Aluno não encontrado");
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(Aluno aluno)
        {
            try
            {
                _repository.Add(aluno);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok(" Aluno(a) salvo com sucesso !");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} ");

            }

            return await _repository.SaveChangesAsync()
                ? Ok("Empresa adicionada")
                : BadRequest("Erro ao adicionar a Empresa");
            

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            if (id <= 0) return BadRequest("Aluno(a) não informada");

            var aluno = await _repository.GetAlunoByIdAsync(id);

            if (aluno == null)
                return NotFound("Aluno(a) não encontrado na base de dados");

            _repository.Delete(aluno);

            return await _repository.SaveChangesAsync()
                ? Ok("Removido com sucesso")
                : BadRequest("Erro ao deletar Aluno(a)");


        }
    }
}