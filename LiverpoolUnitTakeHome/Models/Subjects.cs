using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiverpoolUnitTakeHome.Models
{
    public class Subject
    {
        public int ID { get; set; }
        
        [Column("Subject")]
        public  string CourseName { get; set; }
        public virtual ICollection<StudentSubject> StudentSubject { get; set; }

    }
}
