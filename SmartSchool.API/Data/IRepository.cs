using NPOI.SS.Formula.Functions;
using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Aluno[] GetAllAlunos(bool includeProfessor = false);
        Aluno[] GetAllAlunosByDisciplinasId(int disciplinaId, bool includeProfessor = false);
        Aluno GetAllAlunosId(int alunoId, bool includeProfessor = false);
        Professor[] GetAllProfessor(bool includeAlunos = false);
        Professor[] GetAllProfessorByDisciplinasId(int disciplinaId, bool includeAlunos = false);
        Professor GetAllProfessorId(int professorId, bool includeAlunos = false);

    }
}
