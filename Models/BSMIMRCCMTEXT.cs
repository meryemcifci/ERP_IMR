using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRCCMTEXT
    {
        // Foreign Keys
        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRCCM001")]
        [MaxLength(4)]
        [Required]
        public string CCMDOCTYPE { get; set; }


        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string CCMDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime CCMDOCFROM { get; set; }


        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public DateTime CCMDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRGEN001")] // Dil Kodu
        [MaxLength(3)] // VARCHAR(2)
        [Required]
        public string LANCODE { get; set; }

        [Key]//emin değilim
        [MaxLength(50)] // VARCHAR(50)
        [Required]
        public string CCMSTEXT { get; set; } // Malzeme Kısa Açıklaması

        [MaxLength(250)] // VARCHAR(250)
        [Required]
        public string CCMLTEXT { get; set; } // Malzeme Uzun Açıklaması
    }
}
