using mvc_project.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace mvc_project.Models
{
    public class Catagory
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(30)")]
        [MinLength(3)]
        public string Name { get; set; }

        [EnumDataType(typeof(CategoryStatus))]
        public CategoryStatus Status { get; set; }
    }
}
