
using WebApi_Swarupa.Models;
using WebApi_Swarupa.Repository;

namespace WebApi_Swarupa.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<List<Student>> GetAllStudent()
         => _studentRepository.GetAllAsync();

        public Task<Student> GetById(int id)
       => _studentRepository.GetByIdAsync(id);

        public Task<Student> AddStudent(Student student)
        => _studentRepository.AddAsync(student);

        public Task<Student> UpdateStudent(Student student)
            => _studentRepository.UpdateAsync(student);

        public Task<bool> DeleteStudent(int id)
            => _studentRepository.DeleteAsync(id);
    }
}
