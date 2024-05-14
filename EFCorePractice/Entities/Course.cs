using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Dinturation { get; set; }
        public string? Description { get; set; }

        public int? TopicId { get; set; }   //FK
        public Topic Topic { get; set; }   // Navigational Property =>  ONE

        public virtual ICollection<StudentCourse> CourseStudents = new HashSet<StudentCourse>();   // Navigational Property => Many

        public virtual ICollection<InstructorCourse> CourseInstructors = new HashSet<InstructorCourse>();




    }
}
