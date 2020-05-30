using System.ComponentModel.DataAnnotations;

namespace DisplayMultipleTablesInSingleViewMvc_Demo.Models
{
    public class Incentive
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Incentive Amount")]
        public int IncentiveAmount { get; set; }
    }
}