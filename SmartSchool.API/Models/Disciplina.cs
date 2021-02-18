using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Models
{
    public class Disciplina
    {
        public Disciplina() { }
        public Disciplina(int id, string nomeDisciplina, int professorId) 
        {
            this.Id = id;
            this.NomeDisciplina = nomeDisciplina;
            this.ProfessorId = professorId;
        }
        public int Id { get; set; }
        public string NomeDisciplina { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }           
}
