using SIS.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIS
{
    public class StudentRepository
    {
        private static List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student> {new Student {Id=1, Email="rlevch@gmail.com", FirstName="Roman", LastName="Levchenkov"}};
        }

        public async Task<List<Student>> GetStudents()
        {
            return await Task.Run(() => _students);
        }

        public async Task<Student> GetStudent( int id)
        {
            return await Task.Run(() => _students.FirstOrDefault(f => f.Id == id));
        }

        /*
        public async Task<Student> AddStudent(Student student)
        {
            _students.Add(student);
            return ;
        }
        */


    }
}