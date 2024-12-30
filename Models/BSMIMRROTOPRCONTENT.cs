using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.Models
{
    public class BSMIMRROTOPRCONTENT
    {


        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

        [ForeignKey("BSMIMRROT001")]
        [MaxLength(4)]
        [Required]
        public string ROTDOCTYPE { get; set; }

        [MaxLength(25)] 
        [Required]
        public string ROTDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime ROTDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public DateTime ROTDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(4)] 
        [Required]
        public string MATDOCTYPE { get; set; }

        [MaxLength(25)] // VARCHAR(10)
        [Required]
        public string MATDOCNUM { get; set; }

        [Key]
        [MaxLength(4)]
        [Required]
        public int OPRNUM { get; set; }

        [ForeignKey("BSMIMRWCM001")]
        [MaxLength(4)]
        public string WCMDOCTYPE { get; set; }

        [MaxLength(4)]
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
