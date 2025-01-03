using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models.Deneme
{
    public class BSMIMRWCMHEADTEXTOPR
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

        [Key]
        [MaxLength(25)]
        [Required]
        public string WCMDOCNUM { get; set; }

      
        [Required]
        public DateTime WCMDOCFROM { get; set; }

      
        [Required]
        public DateTime WCMDOCUNTIL { get; set; }

        [MaxLength(4)]
        [Required]
        public string MAINWCMDOCTYPE { get; set; }

        [MaxLength(25)]
        [Required]
        public string MAINWCMDOCNUM { get; set; }

        [MaxLength(4)]
        [Required]
        public string CCMDOCTYPE { get; set; }

        [MaxLength(25)]
        [Required]
        public string CCMDOCNUM { get; set; }

        [MaxLength(3)]
        public string WORKTIME { get; set; }


        public bool ISDELETED { get; set; }


        public bool ISPASSIVE { get; set; }

        [ForeignKey("BSMIMRGEN001")] // Dil Kodu
        [MaxLength(3)] // VARCHAR(2)
        [Required]
        public string LANCODE { get; set; }

     
        [MaxLength(50)] // VARCHAR(50)
        [Required]
        public string WCMSTEXT { get; set; } // Malzeme Kısa Açıklaması

        [MaxLength(250)] // VARCHAR(250)
        [Required]
        public string WCMLTEXT { get; set; } // Malzeme Uzun Açıklaması
      
        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string OPRDOCTYPE { get; set; }

    }
}
