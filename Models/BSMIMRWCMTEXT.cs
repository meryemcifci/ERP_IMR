using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.Models
{
    public class BSMIMRWCMTEXT
    {
        // Foreign Keys
        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRWCM001")]
        [MaxLength(4)]
        [Required]
        public string WCMDOCTYPE { get; set; }

      
        [MaxLength(25)]
        [Required]
        public string WCMDOCNUM { get; set; }

        [MaxLength(10)]
        [Required]
        public DateTime WCMDOCFROM { get; set; }

        [MaxLength(10)]
        [Required]
        public DateTime WCMDOCUNTIL { get; set; }


        [ForeignKey("BSMIMRGEN001")] // Dil Kodu
        [MaxLength(3)] // VARCHAR(2)
        [Required]
        public string LANCODE { get; set; }

        [Key]//emin değilim
        [MaxLength(50)] // VARCHAR(50)
        [Required]
        public string WCMSTEXT { get; set; } // Malzeme Kısa Açıklaması

        [MaxLength(250)] // VARCHAR(250)
        [Required]
        public string WCMLTEXT { get; set; } // Malzeme Uzun Açıklaması





    }
}
