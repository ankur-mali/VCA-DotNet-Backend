using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    [Table("alternate_components")]

    /*    public class AlternateComponent
        {
            public long Id { get; set; }
            public double DeltaPrice { get; set; }
            public Model? ModId { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public int CompId { get; set; }
            public Component Component { get; set; }
            public int AltCompId { get; set; }
            public Component AltComponent { get; set; }
        }*/
    public class AlternateComponent
    {
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double DeltaPrice { get; set; }

        [ForeignKey("mod_id")]
        public Model? ModId { get; set; }
        /*
                [Required]
                [ForeignKey("comp_id")]
                public int CompId { get; set; }
                public Component Component { get; set; }*/


        [ForeignKey("comp_id")]
        public int ComponentId { get; set; }
        public virtual Component Component { get; set; }


        [ForeignKey("alt_comp_id")]
        public int AltComponentId { get; set; }
        public virtual Component AltComponent { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }


    }
}