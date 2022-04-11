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
    public class ChamadaController : ControllerBase
    {

        private readonly IBaseRepository _repository;

        public ChamadaController(IBaseRepository repository)
        {
            _repository = repository;
        }



        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var chamadas = await _repository.GetAllChamadas();


            return chamadas.Any()
                ? Ok(chamadas)
                : BadRequest("Nenhum registro de Chamada Encontrado");
        }


        [HttpPost]
        public async Task<IActionResult> Post(Chamada chamada)
        {
            try
            {
                _repository.Add(chamada);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok(" Registro Salvo com Sucesso !");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex} ");

            }

            return await _repository.SaveChangesAsync()
                ? Ok("Registro salvo com Sucesso")
                : BadRequest("Erro ao Salvar registro");

        }


    }
}