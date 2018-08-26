﻿using SIS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIS
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _studentRepository.GetStudents();
        }
    }
}