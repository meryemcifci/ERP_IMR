using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRMATTEXT
    {

        // Foreign Keys
        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(4)]
        [Required]
        public string MATDOCTYPE { get; set; }

        [ForeignKey("BSMIMRMATHEAD")] // Malzeme Kodu
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string MATDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public string MATDOCFROM { get; set; }

        
        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public string MATDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRGEN001")] // Dil Kodu
        [MaxLength(3)] // VARCHAR(2)
        [Required]
        public string LANCODE { get; set; }

        [Key]
        [MaxLength(50)] // VARCHAR(50)
        [Required]
        public string MATSTEXT { get; set; } // Malzeme Kısa Açıklaması

        [MaxLength(250)] // VARCHAR(250)
        [Required]
        public string MATLTEXT { get; set; } // Malzeme Uzun Açıklaması
    }
}

