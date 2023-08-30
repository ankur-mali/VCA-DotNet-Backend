using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
  [Table("alternate_components")]
    public class AlternateComponent
    {
        public long Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double DeltaPrice { get; set; }

        [ForeignKey("mod_id")]
        public Model? ModId { get; set; }

        [ForeignKey("comp_id")]
        public Component CompId { get; set; }

        [ForeignKey("alt_comp_id")]
        public Component? AltCompId { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }
    }
    }

