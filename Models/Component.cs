using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    [Table("components")]

    public class Component
    {
        public int Id { get; set; }
        public string CompName { get; set; }
        public ICollection<AlternateComponent> AlternateComponents { get; set; }
    }
    /*    public class Component
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required]
            public string CompName { get; set; }

            *//*        public virtual ICollection<AlternateComponent> CompId { get; set; }
                    public virtual ICollection<AlternateComponent> AltCompId { get; set; }*//*
            public ICollection<AlternateComponent> AlternateComponents { get; set; }

        }*/
}

