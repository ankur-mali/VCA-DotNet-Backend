using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Segment")]
        public int SegId { get; set; }
        public Segment Segment { get; set; }

        [ForeignKey("Manufacturer")]
        public int? ManuId { get; set; }
        public Manufacturer? Manufacturer { get; set; }

        [Required]
        public string? ModName { get; set; }

        [Required]
        public int Price { get; set; }

        [Column]
        [DefaultValue(5)]
        public int SafetyRating { get; set; }

        [Required]
        public string? ImagePath { get; set; }

        [Column]
        public int MinQty { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }


        public ICollection<AlternateComponent>? alternateComponents { get; set; }

    }
}
