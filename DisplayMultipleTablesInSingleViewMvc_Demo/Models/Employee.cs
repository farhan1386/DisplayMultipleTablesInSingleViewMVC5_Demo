using System;
using System.ComponentModel.DataAnnotations;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Position { get; set; }

        [Required]
        [StringLength(100)]
        public string Office { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        [Required]
        public int IncentiveId { get; set; }
        public Incentive Incentive { get; set; }
    }
}