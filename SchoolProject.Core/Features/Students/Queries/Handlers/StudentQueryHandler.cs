using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Models;
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
    public class StudentQueryHandler :ResponseHandler, IRequestHandler<GetStudentsListQuery,Response<List<StudentResponse>>>,
                                                       IRequestHandler<GetStudentByIdQuery , Response<GetStudentByIdResult>>
    {
        private readonly IStudentService _studentService;

        private readonly IMapper _mapper;
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<List<StudentResponse>>> Handle(GetStudentsListQuery request, CancellationToken cancellationToken)
        {
            var studentsList = await _studentService.GetStudentsListAsync();
            return Success(_mapper.Map<List<StudentResponse>>(studentsList));
        }

        public async Task<Response<GetStudentByIdResult>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null) return NotFound<GetStudentByIdResult>("Student Not Found");
            var result = _mapper.Map<GetStudentByIdResult>(student);
            return Success(result);
        }
    }
}
