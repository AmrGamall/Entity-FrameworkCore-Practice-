using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class InstructorCourse
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string? Evaluation { get; set; }

    }
}
