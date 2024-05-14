using System.ComponentModel.DataAnnotations;

namespace ReactCRUD.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string studentname { get; set; }

        public string course { get; set; }
    }
}
