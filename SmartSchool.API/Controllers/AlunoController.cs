using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Marcos",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Marcos",
                Telefone = "123456"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Laura",
                Sobrenome = "Marcos",
                Telefone = "123456"
            },
        };

        public AlunoController() { }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok (Alunos);
        }

        [HttpGet("byId")]
        public IActionResult Get(int id)
        {
            var aluno = Alunos.FirstOrDefault(alunos => alunos.Id == id);
            return Ok(aluno);
        }
        [HttpGet("ByName")]
        public IActionResult GetById(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(alunos => alunos.Nome.Contains(nome) &&
            alunos.Sobrenome.Contains(sobrenome));
            return Ok(aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            return Ok(aluno);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
