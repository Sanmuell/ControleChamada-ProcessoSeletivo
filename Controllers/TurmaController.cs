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


    }
}
