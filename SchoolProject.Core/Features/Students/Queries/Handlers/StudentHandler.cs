using MediatR;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentsListQuery, List<StudentResponse>>
    {
        private readonly IStudentService _studentService;


        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<List<StudentResponse>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsListAsync();
        }
    }
}
