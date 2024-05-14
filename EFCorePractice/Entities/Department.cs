using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }


        [ForeignKey(nameof(Manager))]  
        public int? ManagerId { get; set; }   //FK

        [InverseProperty(nameof(Instructor.ManageDepartment))]
        public Instructor Manager { get; set; }    //Navigational Property => One


        [InverseProperty(nameof(Instructor.WorkForDepartment))]
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();   //Navigational Property => Many


        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();   // Navigational Property => Many

    }

}
