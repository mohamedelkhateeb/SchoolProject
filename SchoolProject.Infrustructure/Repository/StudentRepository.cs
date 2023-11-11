using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.InfrastructureBasis;
using SchoolProject.Infrustructure.Data;
using SchoolProject.Infrustructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.Repository
{
    public class StudentRepository : GenericRepositoryAsync<Student>,IStudentRepository
    {
        private readonly DbSet<Student> _students;
        public StudentRepository(AppDbContext dbcontext) : base(dbcontext)
        {
            _students = _dbContext.Set<Student>();
            
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _students.Include(x=> x.Department).ToListAsync();
        }
    }
}
