using System.ComponentModel.DataAnnotations;

namespace LiverpoolUnitTakeHome.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Surname")]
        public string LastName { get; set;}
        [Display(Name = "Date Of Birth")]        
        //TODO validation to make sure dob is earlier than today
        public DateOnly DateOfBirth { get; set; }
        [Range(1,3)]
        [Display(Name = "Year Of Study")]
        public int YearOfStudy { get; set; }
        public ICollection<StudentSubject> StudentSubject { get; set; } = new List<StudentSubject>();

    }
}
