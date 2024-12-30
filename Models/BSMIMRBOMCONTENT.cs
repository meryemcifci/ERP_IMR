using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.Models
{
    public class BSMIMRBOMCONTENT
    {

        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRBOM001")]
        [MaxLength(4)]
        [Required]
        public string BOMDOCTYPE { get; set; }

        
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string BOMDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime BOMDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public DateTime BOMDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string MATDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(10)
        [Required]
        public string MATDOCNUM { get; set; }

        [Key]
        [MaxLength(4)]
        [Required]
        public string CONTENTNUM { get; set; }

        [MaxLength(25)]
        public string COMPONENT { get; set; }

        [ForeignKey("BSMIMRBOM001")]
        [MaxLength(4)]
        public string COMPBOMDOCTYPE { get; set; }

        [MaxLength(25)]
        public string COMPBOMDOCNUM { get; set; }

        [MaxLength(5)]
        public decimal QUANTITY { get; set; }

      
    }
}
