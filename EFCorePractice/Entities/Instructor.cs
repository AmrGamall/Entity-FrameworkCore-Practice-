using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class Instructor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Bonus { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public virtual Department ManageDepartment { get; set; }    //Navigational Property => One

        [ForeignKey(nameof(WorkForDepartment))]
        public int? DepartmentId { get; set; }  //FK

        [InverseProperty(nameof(Department.Instructors))]
        public virtual Department WorkForDepartment { get; set; }   //Navigational Property => One


        public virtual ICollection<InstructorCourse>  instructorCourses { get; set; } = new HashSet<InstructorCourse>();


    }
}
