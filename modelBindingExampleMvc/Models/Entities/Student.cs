using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace modelBindingExampleMvc.Models.Entities
{
    [Table("tblStudents")]
    public class Student
    {
        public int id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(25)]
      
        public string name { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(35)]
        
        public string sname { get; set; }
    }
}
