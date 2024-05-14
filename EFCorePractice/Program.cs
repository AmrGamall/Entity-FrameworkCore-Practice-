using EFCorePractice.Contexts;
using EFCorePractice.Entities;

namespace EFCorePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();

            #region Crud Operations

            #region Instructor

            #region Insert

            //Instructor Ins01 = new Instructor() { Name = "Amr", Bonus = 10, Salary = 5_000, HourRate = 10};
            //Instructor Ins02 = new Instructor() { Name = "Ahmed", Bonus = 20, Salary = 10_000, HourRate = 8 };

            //dbContext.Add(Ins01);
            //dbContext.Add(Ins02);

            //dbContext.SaveChanges();

            #endregion

            #region Select

            //var Instructor = (from Ins in dbContext.Instructors
            //                  where Ins.Id == 1
            //                  select Ins).FirstOrDefault();

            //Console.WriteLine(Instructor?.Name?? "NA");


            #endregion

            #region Update

            //Instructor.Name = "Amr Gamal";

            //dbContext.SaveChanges();

            #endregion

            #region Delete

            //dbContext.Remove(Instructor);

            //dbContext.SaveChanges();

            #endregion

            #endregion


            #region Department

            #region Insert
            //Department D01 = new Department() { Name = "D01", HiringDate = DateTime.Now };
            //Department D02 = new Department() { Name = "D02", HiringDate = DateTime.Now };

            //Console.WriteLine(dbContext.Entry(D01).State); // Detached

            //dbContext.Add(D01);
            //dbContext.Add(D02);

            //Console.WriteLine(dbContext.Entry(D01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(D01).State); // Unchanged
            #endregion

            #region Select

            //var department = (from D in dbContext.Set<Department>()
            //                  where D.Id == 20
            //                  select D).FirstOrDefault();

            //Console.WriteLine(department?.Name ?? "NA");
            #endregion

            #region Update

            //department.Name = "Test";
            //dbContext.SaveChanges();


            #endregion

            #region Delete

            //dbContext.Remove(department);
            //dbContext.SaveChanges();
            #endregion

            #endregion

            #region Students
            #region Insert
            //Student S01 = new Student() { FName = "Doaa", LName = "Elfawal", Age = 24, Address = "New Cairo" };
            //Student S02 = new Student() { FName = "Mohamed", LName = "Gamal", Age = 27, Address = "Nasr City" };

            //Console.WriteLine(dbContext.Entry(S01).State); // Detached

            //dbContext.Students.Add(S01);
            //dbContext.Students.Add(S02);

            //Console.WriteLine(dbContext.Entry(S01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(S01).State); // Unchanged 
            #endregion

            #region Select
            //var student = (from S in dbContext.Students
            //               where S.Id == 2
            //               select S).FirstOrDefault();

            ////Console.WriteLine(student?.FName ?? "NA"); 
            #endregion

            #region Update
            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged

            //student.FName = "Dina";

            //Console.WriteLine(dbContext.Entry(student).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged 
            #endregion

            #region Delete
            //Console.WriteLine(dbContext.Entry(student).State); // Unchanged

            //dbContext.Remove(student);

            //Console.WriteLine(dbContext.Entry(student).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(student).State); // Detached 
            #endregion
            #endregion

            #region Topics

            #region Insert

            //Topic t01 = new Topic() { Name = "binding" };
            //Topic t02 = new Topic() { Name = "l2e" };

            //dbContext.Add(t01);
            //dbContext.Add(t02);

            //dbContext.SaveChanges();



            #endregion

            #region Select

            //var Topic = (from T in dbContext.Topic
            //             where T.Id == 2
            //             select T).FirstOrDefault();
            //Console.WriteLine(Topic?.Name ?? "NA");
            #endregion

            #region Update

            //Console.WriteLine(dbContext.Entry(Topic).State); // Unchanged

            //Topic.Name = "Test";

            //Console.WriteLine(dbContext.Entry(Topic).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Topic).State); // Unchanged

            #endregion

            #region Delete

            //Console.WriteLine(dbContext.Entry(Topic).State); // Unchanged

            //dbContext.Remove(topic);

            //Console.WriteLine(dbContext.Entry(Topic).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Topic).State); // Detached
            #endregion
            #endregion

            #region Courses

            #region Insert

            //Course Crs01 = new Course() { Name = "C#", Duration = 5, TopicId = 1 };
            //Course Crs02 = new Course() { Name = "LINQ", Duration = 2, TopicId = 1 };


            //Console.WriteLine(dbContext.Entry(Crs01).State); // Detached

            //dbContext.Add(Crs01);
            //dbContext.Add(Crs02);

            //Console.WriteLine(dbContext.Entry(Crs01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(Crs01).State); // Unchanged

            #endregion


            #region Select

            //var course = (from Crs in dbContext.Courses
            //              where Crs.Id == 2
            //              select Crs).FirstOrDefault();

            ////Console.WriteLine(course?.Name ?? "NA");
            #endregion

            #region Update
            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged

            //course.Name = "OOP";

            //Console.WriteLine(dbContext.Entry(course).State); // Modified

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged
            #endregion

            #region Delete
            //Console.WriteLine(dbContext.Entry(course).State); // Unchanged

            //dbContext.Remove(course);

            //Console.WriteLine(dbContext.Entry(course).State); // Deleted

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(course).State); // Detached

            #endregion
            #endregion

            #region Student_Course

            #region Insert
            //StudentCourse SC01 = new StudentCourse() { CourseId = 1, StudentId = 1, Grade = 100 };
            //StudentCourse SC02 = new StudentCourse() { CourseId = 2, StudentId = 1, Grade = 80 };

            //Console.WriteLine(dbContext.Entry(SC01).State); // Detached

            //dbContext.Add(SC01);
            //dbContext.Add(SC02);

            //Console.WriteLine(dbContext.Entry(SC01).State); // Added

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(SC01).State); // Unchanged 
            #endregion


            #endregion

            #endregion



            //var ins = (from I in dbContext.Instructors
            //          .Include(I => I.WorkForDepartment)
            //          where I.Id == 2
            //          select I).FirstOrDefault();

            //Console.WriteLine($"InstructorId: {ins?.Id} ::: InstructorName: {ins?.Name} ::: Department: {ins?.WorkForDepartment?.Name}");

            //var result = from I in dbContext.Instructors
            //             join D in dbContext.Departments
            //             on I.DepartmentId equals D.Id
            //             where I.Address == "Dokki"
            //             select new
            //             {
            //                 InsId = I.Id,
            //                 InsName = I.Name,
            //                 DeptId = D.Id,
            //                 DeptName = D.Name,
            //                 I.Address
            //             };

            //result = dbContext.Instructors.Join(dbContext.Departments,
            //                                     I => I.DepartmentId,
            //                                     D => D.Id,
            //                                     (I, D) => new
            //                                     {
            //                                         InsId = I.Id,
            //                                         InsName = I.Name,
            //                                         DeptId = D.Id,
            //                                         DeptName = D.Name,
            //                                         I.Address

            //                                     }).Where(I => I.Address == "Cairo");

            //foreach (var item in result)
            //    Console.WriteLine($"Instructor:{item.InsName} , Department: {item.DeptName}");
        }
    }
}
