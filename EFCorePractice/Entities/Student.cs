using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }

        
        public int? DepartmentId { get; set; }   //FK

        public virtual Department Department { get; set; }   // Navigational Property =>  ONE


        public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();   // Navigational Property => Many
    }
}
