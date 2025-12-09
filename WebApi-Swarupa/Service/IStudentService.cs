using WebApi_Swarupa.Models;

namespace WebApi_Swarupa.Service
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudent();
        Task<Student> GetById(int id);
        Task<Student> AddStudent(Student student);
        Task<Student> UpdateStudent(Student student);
        Task<bool> DeleteStudent(int id);
    }
}
