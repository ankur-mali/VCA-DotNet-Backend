using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    [Table("Invoices")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Model")]
        public int ModelId { get; set; }
        public Model? Model { get; set; }



        [ForeignKey("AlternateComponent")]
        public int? AltCompId { get; set; }
        public AlternateComponent? AlternateComponent { get; set; }




        [Required]
        public double Price { get; set; }




        [ForeignKey("Registration")]
        public int? AuthId { get; set; }
        public Registration? Registration { get; set; }




        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }


    }
}
