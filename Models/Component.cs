using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VCA.Models
{
    [Table("components")]
    public class Component
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ?CompName { get; set; }


        public ICollection<AlternateComponent> AlternateComponents { get; set; }
    }
}

