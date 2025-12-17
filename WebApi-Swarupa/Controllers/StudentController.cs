using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi_Swarupa.Models;
using WebApi_Swarupa.Repository;
using WebApi_Swarupa.Service;

namespace WebApi_Swarupa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService context)
        {
            _studentService = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var student = await  _studentService.GetAllStudent();
            return Ok(student);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var student = await _studentService.GetById(id);
            if (student == null)
            {
                return NotFound("Student not found");

            }
            return Ok(student);

        }
        [HttpPost]
        public async Task<IActionResult> AddStudent(Student student)
        {
            var std = await _studentService.AddStudent(student);
            return Ok(std);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.id)
                return BadRequest("ID mismatch");

            var updated = await _studentService.UpdateStudent(student);
            return Ok(updated);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _studentService.DeleteStudent(id);

            if (!result)
                return NotFound("Student not found");

            return Ok("Student deleted successfully");
        }


    }
}
