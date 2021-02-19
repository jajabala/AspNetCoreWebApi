using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.API.Data;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        [HttpGet("byId")]
        public IActionResult Get(int id)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(prof => prof.Id == id);
            return Ok(prof);
        }

        [HttpGet("ByName")]
        public IActionResult GetById(string nome)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(prof => prof.Nome.Contains(nome));

            return Ok(prof);
        }
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context.Alunos.AsNoTracking().FirstOrDefault(professor => professor.Id == id);

            if (prof == null) return BadRequest("Não foi encontrado o prof");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _context.Alunos.AsNoTracking().FirstOrDefault(professor => professor.Id == id);

            if (prof == null) return BadRequest("Não foi encontrado o prof");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var prof = _context.Professores.FirstOrDefault(prof => prof.Id == id);

            if (prof == null) return BadRequest("Não foi encontrado o aluno");

            _context.Remove(prof);
            _context.SaveChanges();
            return Ok();
        }
    }
}

