using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRWCMHEAD
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

        [MaxLength(10)]
        [Required]
        public DateTime WCMDOCFROM { get; set; }

        [MaxLength(10)]
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


    }
}
