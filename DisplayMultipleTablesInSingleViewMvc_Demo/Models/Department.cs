using System.ComponentModel.DataAnnotations;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
    }
}