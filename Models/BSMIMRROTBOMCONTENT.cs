using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.Models
{
    public class BSMIMRROTBOMCONTENT
    {

        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string ROTDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string ROTDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(4)
        [Required]
        public DateTime ROTDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(4)
        [Required]
        public DateTime ROTDOCUNTIL { get; set; }

        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string MATDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string MATDOCNUM { get; set; }

        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public int OPRNUM { get; set; }

        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string BOMDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string BOMDOCNUM { get; set; }

        [Key]
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public int CONTENTNUM { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string COMPONENT { get; set; }


        [MaxLength(5)] // VARCHAR(4)
        [Required]
        public decimal QUANTITY { get; set; }


        
        
        
        
        
        
        
        
        
        
        
        
        
    }
}
