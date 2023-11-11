using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.InfrastructureBasis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure.IRepository
{
    public interface IStudentRepository : IGenericRepositoryAsync<Student>
    {
        public Task<List<Student>> GetStudentsAsync(); 
    }
}
