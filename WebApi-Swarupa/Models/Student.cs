using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Swarupa.Models
{
    [Table("Student")]
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string course {  get; set; }
        public int fee {  get; set; }
    }
}
