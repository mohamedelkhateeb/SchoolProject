using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
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
    public class StudentHandler :ResponseHandler, IRequestHandler<GetStudentsListQuery,Response<List<StudentResponse>>>
    {
        private readonly IStudentService _studentService;

        private readonly IMapper _mapper;
        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<StudentResponse>>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var studentsList = await _studentService.GetStudentsListAsync();
            return Success(_mapper.Map<List<StudentResponse>>(studentsList));
        }
    }
}
