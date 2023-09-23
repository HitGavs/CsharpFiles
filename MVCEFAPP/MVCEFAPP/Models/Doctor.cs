using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEFAPP.Models
{
    public class Doctor
    {
        [Key]
        [Column("doctorno")]
        public int Id { get; set; }

        [Required] // 
        [StringLength(20)]
        [MinLength(3, ErrorMessage =("name must be between 3 and 20 characters"))]
        public String Name { get; set; } = String.Empty;
        [Required]
        public string Speciality { get; set; } = String.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal VisitingFee  { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]

        public Decimal PhoneNumber {  get; set; }

    }
}
