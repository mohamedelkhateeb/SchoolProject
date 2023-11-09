﻿using AutoMapper;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.studentMapper
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            StudentListMapping();
        }
    }
}
