using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VCA.Models;

namespace VCA.Models
{
    [Table("manufacturers")]
    public class Manufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string ManuName { get; set; }

        [ForeignKey("Segment")]
        [Required]
        public int SegId { get; set; }
       
        public virtual Segment Segment { get; set; }

       
    }
}
