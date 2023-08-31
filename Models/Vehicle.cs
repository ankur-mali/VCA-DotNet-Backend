using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    public enum CompType
    {
        S, C, I, E
    }

    public enum IsConfigurable
    {
        Y, N
    }

    [Table("vehicles")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public CompType CompType { get; set; }


        [Required]

        public IsConfigurable IsConfigurable { get; set; }

        [Required]
        [ForeignKey("model")]
        public int ModId { get; set; }
        public virtual Model Model { get; set; }

        [Required]
        [ForeignKey("component")]
        public int CompId { get; set; }
        public virtual Component Component { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
}
