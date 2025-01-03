using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models.Deneme
{
    public class BSMIMRCCMHEADTEXT
    {
        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRCCM001")]
        [MaxLength(4)]
        [Required]
        public string CCMDOCTYPE { get; set; }

        [Key]
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string CCMDOCNUM { get; set; }

    
        [Required]
        public DateTime CCMDOCFROM { get; set; }

        [Required]
        public DateTime CCMDOCUNTIL { get; set; }

        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string MAINCCMDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(10)
        [Required]
        public string MAINCCMDOCNUM { get; set; }

        public bool ISDELETED { get; set; }

        public bool ISPASSIVE { get; set; }

        [ForeignKey("BSMIMRGEN001")] // Dil Kodu
        [MaxLength(3)] // VARCHAR(2)
        [Required]
        public string LANCODE { get; set; }

        [MaxLength(50)] // VARCHAR(50)
        [Required]
        public string CCMSTEXT { get; set; } // Malzeme Kısa Açıklaması

        [MaxLength(250)] // VARCHAR(250)
        [Required]
        public string CCMLTEXT { get; set; } // Malzeme Uzun Açıklaması
    }
}
