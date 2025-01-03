using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models.Deneme
{
    public class BSMIMRROTHEADCONTENT
    {

        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [MaxLength(4)]
        [Required]
        public string ROTDOCTYPE { get; set; }

        [Key]
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string ROTDOCNUM { get; set; }

        
        [Required]
        public DateTime ROTDOCFROM { get; set; }

        [Required]
        public DateTime ROTDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string MATDOCTYPE { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(25)] // VARCHAR(10)
        [Required]
        public string MATDOCNUM { get; set; }

        [MaxLength(5)]
        [Required]
        public decimal QUANTITY { get; set; }

        public bool ISDELETED { get; set; }

        public bool ISPASSIVE { get; set; }

        [MaxLength(25)]
        public string DRAWNUM { get; set; }
      
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public int OPRNUM { get; set; }

        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string BOMDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string BOMDOCNUM { get; set; }

     
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public int CONTENTNUM { get; set; }

        [MaxLength(25)] // VARCHAR(4)
        [Required]
        public string COMPONENT { get; set; }

        [ForeignKey("BSMIMRWCM001")]
        [MaxLength(4)]
        public string WCMDOCTYPE { get; set; }

        [MaxLength(25)]
        public string WCMDOCNUM { get; set; }

        [MaxLength(4)]
        public string OPRDOCTYPE { get; set; }

        [MaxLength(3)]
        public decimal SETUPTIME { get; set; }

        [MaxLength(3)]
        public decimal MACHINETIME { get; set; }

        [MaxLength(3)]
        public decimal LABOURTIME { get; set; }
    }
}
