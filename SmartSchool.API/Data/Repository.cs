using SmartSchool.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.API.Data
{
    public class Repository : IRepository
    {
        private readonly SmartContext _context;
        public Repository(SmartContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() > 0);
        }

        public Aluno[] GetAllAlunos()
        {
            throw new NotImplementedException();
        }

        public Aluno[] GetAllAlunosByDisciplinasId()
        {
            throw new NotImplementedException();
        }

        public Aluno[] GetAllAlunosId()
        {
            throw new NotImplementedException();
        }

        public Professor[] GetAllProfessor()
        {
            throw new NotImplementedException();
        }

        public Professor[] GetAllProfessorByDisciplinasId()
        {
            throw new NotImplementedException();
        }

        public Professor[] GetAllProfessorId()
        {
            throw new NotImplementedException();
        }
    }
}
