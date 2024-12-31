using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRWCMOPR
    {
        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRWCM001")]
        [MaxLength(4)]
        [Required]
        public string WCMDOCTYPE { get; set; }

      
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string WCMDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime WCMDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public DateTime WCMDOCUNTIL { get; set; }

        [Key]
        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string OPRDOCTYPE { get; set; }


    }
}
