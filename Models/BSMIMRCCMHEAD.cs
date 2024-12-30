using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRCCMHEAD
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

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime CCMDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(25)
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
    }
}
