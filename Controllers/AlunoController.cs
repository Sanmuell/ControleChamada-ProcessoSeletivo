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

        private readonly IBaseRepository _repository;

        public AlunoController(IBaseRepository repository)
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


    }
}
