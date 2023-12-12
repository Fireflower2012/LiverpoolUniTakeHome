using System.ComponentModel.DataAnnotations;

namespace LiverpoolUnitTakeHome.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateOnly DateOfBirth { get; set; }
        [Range(1,3)]
        public int YearOfStudy { get; set; }
        public ICollection<StudentSubject> StudentSubject { get; set; } = new List<StudentSubject>();

     //   public ICollection<Subjects> Subject { get; set; } = new List<Subjects>();

    }
}
